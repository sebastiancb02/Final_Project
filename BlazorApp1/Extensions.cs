using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorApp1;

public record GoogleMapsLoadConfig
{
    public required string ApiKey { get; set; }
    public string Version { get; set; } = "quarterly";
    public string Libraries { get; set; } = "maps,marker";
    public string Language { get; set; } = "en";
    public string Region { get; set; } = "SE";
}

public record GoogleMapCoordinate(double lat, double lng);

public record GoogleMapControls(
    bool? ZoomControl = true,
    bool? CameraControl = false,
    bool? MapTypeControl = true,
    bool? ScaleControl = false,
    bool? StreetViewControl = false,
    bool? FullScreenControl = true,
    bool? DisableDefaultUI = false
    );

public record GoogleMapOptions(
    string ElementId,
    string MapId,
    GoogleMapCoordinate Center,
    int? Zoom = 10,
    GoogleMapControls? Controls = null
);

public static class Extensions
{
    public static async Task ImportGoogleTravelMapJsAsync(this IJSRuntime jsRuntime)
    {
        await jsRuntime.InvokeVoidAsync("import", "./js/TravelMap.js");
    }

    public static ValueTask LoadGoogleMapsApiAsync(this IJSRuntime jsRuntime, GoogleMapsLoadConfig config)
    {
        return jsRuntime.InvokeVoidAsync("TravelMapJs.loadMapsApi", config);
    }

    public static ValueTask InitGoogleMapsApiAsync(this IJSRuntime jsRuntime, GoogleMapOptions mapOptions)
    {
        return jsRuntime.InvokeVoidAsync("TravelMapJs.initMapAsync", mapOptions);
    }
}