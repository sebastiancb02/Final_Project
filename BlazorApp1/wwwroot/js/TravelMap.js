

let mapsApiPromise;

export async function loadMapsApi(config) {
    if (!mapsApiPromise) {
        mapsApiPromise = new Promise((resolve, reject) => {
            const script = document.createElement("script");

            const parameters = new URLSearchParams({
                key: config.apiKey,
                v: config.version ?? "quarterly",
                language: config.language ?? "en",
                region: config.region ?? "SE",
                loading: "async"
            });

            script.src =
                `https://maps.googleapis.com/maps/api/js?${parameters}`;

            script.async = true;

            script.onload = resolve;

            script.onerror = () => {
                reject(new Error("Google Maps failed to load."));
            };

            document.head.appendChild(script);
        });
    }

    await mapsApiPromise;

    // Load the libraries we need.
    await google.maps.importLibrary("maps");
    await google.maps.importLibrary("marker");
}

export async function initMap(options) {
    const { Map } = await google.maps.importLibrary("maps");

    const element = document.getElementById(options.elementId);

    if (!element) {
        throw new Error(`Map element '${options.elementId}' was not found.`);
    }

    const center = {
        lat: options.center.lat,
        lng: options.center.lng
    };

    const map = new Map(element, {
        center: center,
        zoom: options.zoom ?? 10,
        mapId: options.mapId,
        ...(options.controls ?? {})
    });

    // Add a test marker in Stockholm.
    const { AdvancedMarkerElement } =
        await google.maps.importLibrary("marker");

    new AdvancedMarkerElement({
        map: map,
        position: center,
        title: "My first travel map!"
    });
}


/*
export class GoogleTravelMapJs{
    static importDynamicLibrary =   (g=>{
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
        d[l]
            ?console.warn(p+" only loads once. Ignoring:",g)
            :d[l]=(f,...n)=>r.add(f)&&u().then(()=>d[l](f,...n));
    });

    static loadMapsApi({
        apiKey,
        version = "quarterly",
        libraries = ["marker"],
        language = "en",
        region = "SE"
    }) 
    
    {
        return this.importDynamicLibrary({
        key: apiKey,
        v: version,
        libraries,
        language,
        region
        });
    }
    
    static map;
    
    static async initMapAsync({elementID, mapId, center, zoom, controls})
    {
        const {map} = await google.maps(document.getElementById(elementId), 
            {
                center, 
                zoom, 
                mapId,
                ...controls
            });
            
    }
}

window.TravelMapJs = TravelMapJs();

 */