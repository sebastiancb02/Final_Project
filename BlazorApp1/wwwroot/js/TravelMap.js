export class TravelMapJs{
    static importDynamicLibrary = (g=>{
        var h,a,k,p="The Google Maps JavaScript API",c="google",l="importLibrary",q="__ib__",
            m=document,b=window;b=b[c]||(b[c]={});
        var d=b.maps||(b.maps={}),r=new Set,e=new URLSearchParams,
            u=()=>h||(h=new Promise(async(f,n)=>{
                await (a=m.createElement("script"));
                e.set("libraries",[...r]+"");
                for(k in g)e.set(k.replace(/[A-Z]/g,t=>"_"+t[0].toLowerCase()),g[k]);
                e.set("callback",c+".maps."+q);
                a.src=`https://maps.${c}apis.com/maps/api/js?`+e;
                d[q]=f;
                a.onerror=()=>h=n(Error(p+" could not load."));
                a.nonce=m.querySelector("script[nonce]")?.nonce||"";
                m.head.append(a)
            }));
        d[l] ?console.warn(p+" only loads once. Ignoring:",g) :d[l]=(f,...n)=>r.add(f)&&u().then(()=>d[l](f,...n));
    });

    static loadMapsApi({apiKey, version = "quarterly", libraries = "maps,marker", language = "en", region = "SE"})
    {
        this.importDynamicLibrary({
            key: apiKey,
            v: version,
            libraries,
            language,
            region
        });
    }
    
    static map;
    
    static async initMapAsync({elementId, mapId, center, zoom, controls})
    {
        const {Map} = await google.maps.importLibrary("maps");
        
        this.map = new Map(document.getElementById(elementId), 
            {
                center, 
                zoom, 
                mapId,
                ...controls
            });
            
    }
    
    static async addMarkersAsync(markers)
    {
        const {InfoWindow} = await google.maps.importLibrary("maps");
        const {AdvancedMarkerElement, PinElement} = await google.maps.importLibrary("marker");
        
        const infoWindow = new InfoWindow();
        
        markers.forEach(({info, position, clickable, pin}, i) =>
        {
            const {title, content} = info;
            const {background, borderColor, glyph, glyphColor, isGlyphIcon, scale} = pin;
            
            let icon;
            if (isGlyphIcon)
            {
                icon = document.createElement("div");
                icon.innerHTML = glyph;
            }    
            
            const glyphContent = isGlyphIcon ? icon : glyph;
            
            const pinElement = new PinElement({background, borderColor, glyph: glyphContent, glyphColor, scale})
            
            const marker = new AdvancedMarkerElement({
                map: this.map,
                title: title,
                position,
                gmpClickable: clickable,
                content: pinElement.element
            });

            if (!clickable) return;

            marker.addListener("click", ({domEvent,}) => {
                const {target } = domEvent;

                infoWindow.close();
                infoWindow.setHeaderContent(marker.title);
                infoWindow.setContent(content);
                infoWindow.open(marker.map, marker);
            });
        });
        
    }
    
}

window.TravelMapJs = TravelMapJs;