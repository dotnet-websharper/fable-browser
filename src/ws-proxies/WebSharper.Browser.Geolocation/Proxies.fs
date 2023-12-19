module private rec Proxies
open WebSharper
open WebSharper.JavaScript

type WindowOrWorkerGlobalScope with
    [<Inline>] 
    static member Geolocation = Unchecked.defaultof<Browser.Types.Geolocation>

[<Proxy(typeof<Browser.Types.Geolocation>)>]
type GeolocationProxy =
    [<Inline>] abstract clearWatch: watchId: float -> unit
    [<Inline>] abstract getCurrentPosition: successCallback: (Browser.Types.Position->unit) * ?errorCallback: (Browser.Types.PositionError->unit) * ?options: Browser.Types.PositionOptions -> unit
    [<Inline>] abstract watchPosition: successCallback: (Browser.Types.Position->unit) * ?errorCallback: (Browser.Types.PositionError->unit) * ?options: Browser.Types.PositionOptions -> float

    [<Inline>] 
    default this.clearWatch(watchId) = (this |> As<Geolocation.Geolocation>).ClearWatch(int watchId)
    [<Inline>] 
    default this.getCurrentPosition(successCallback, errorCallback, options) = 
        (this |> As<Geolocation.Geolocation>).GetCurrentPosition(new System.Action<_>(As >> successCallback),new System.Action<_>(As >> (Option.defaultValue ignore errorCallback)),options |> As)
    [<Inline>] 
    default this.watchPosition(successCallback, errorCallback, options) =
        (this |> As<Geolocation.Geolocation>).WatchPosition(new System.Action<_>(As >> successCallback),new System.Action<_>(As >> (Option.defaultValue ignore errorCallback)),options |> As)

[<Proxy(typeof<Browser.Types.Coordinates>)>]
type CoordinatesProxy =
    /// Returns a double representing the position's latitude in decimal degrees.
    [<Inline>] abstract latitude: float
    /// Returns a double representing the position's longitude in decimal degrees.
    [<Inline>] abstract longitude: float
    /// Returns a double representing the position's altitude in meters, relative to sea level. This value can be null if the implementation cannot provide the data.
    [<Inline>] abstract altitude: float option
    /// Returns a double representing the accuracy of the latitude and longitude properties, expressed in meters.
    [<Inline>] abstract accuracy: float
    /// Returns a double representing the accuracy of the altitude expressed in meters. This value can be null.
    [<Inline>] abstract altitudeAccuracy: float option
    /// Returns a double representing the direction in which the device is traveling. This value, specified in degrees, indicates how far off from heading true north the device is. 0 degrees represents true north, and the direction is determined clockwise (which means that east is 90 degrees and west is 270 degrees). If speed is 0, heading is NaN. If the device is unable to provide heading information, this value is null.
    [<Inline>] abstract heading: float option
    /// Returns a double representing the velocity of the device in meters per second. This value can be null.
    [<Inline>] abstract speed: float option

    [<Inline>] default this.latitude = (this |> As<Geolocation.Coordinates>).Latitude
    [<Inline>] default this.longitude = (this |> As<Geolocation.Coordinates>).Longitude
    [<Inline>] default this.altitude = Some (this |> As<Geolocation.Coordinates>).Altitude
    [<Inline>] default this.accuracy = (this |> As<Geolocation.Coordinates>).Accuracy
    [<Inline>] default this.altitudeAccuracy = Some (this |> As<Geolocation.Coordinates>).AltitudeAccuracy
    [<Inline>] default this.heading = Some (this |> As<Geolocation.Coordinates>).Heading
    [<Inline>] default this.speed = Some (this |> As<Geolocation.Coordinates>).Speed

[<Proxy(typeof<Browser.Types.Position>)>]
type PositionProxy =
    [<Inline>] abstract coords: Browser.Types.Coordinates
    [<Inline>] abstract timestamp: float

    [<Inline>] default this.coords = (this |> As<Geolocation.Position>).Coords |> As
    [<Inline>] default this.timestamp = (this |> As<Geolocation.Position>).Timestamp |> As

[<Proxy(typeof<Browser.Types.PositionErrorCode>)>]
type PositionErrorCodeProxy =
    | PERMISSION_DENIED = 1
    | POSITION_UNAVAILABLE = 2
    | TIMEOUT = 3

[<Proxy(typeof<Browser.Types.PositionError>)>]
type PositionErrorProxy =
    [<Inline>] abstract code: Browser.Types.PositionErrorCode
    [<Inline>] abstract message: string

    [<Inline>] default this.code = (this |> As<Geolocation.PositionError>).Code |> As
    [<Inline>] default this.message = (this |> As<Geolocation.PositionError>).Message

[<Proxy(typeof<Browser.Types.PositionOptions>)>]
type PositionOptions =
    [<Inline>] abstract enableHighAccuracy: bool option with get, set
    [<Inline>] abstract timeout: int option with get, set
    [<Inline>] abstract maximumAge: int option with get, set

    default this.enableHighAccuracy
        with [<Inline>]  get () = Some (this |> As<Geolocation.PositionOptions>).EnableHighAccuracy
        and [<Inline>] set (v) = (this |> As<Geolocation.PositionOptions>).EnableHighAccuracy <- Option.defaultValue false v
    default this.timeout
        with [<Inline>] get () = Some (this |> As<Geolocation.PositionOptions>).Timeout
        and [<Inline>] set (v) = (this |> As<Geolocation.PositionOptions>).Timeout <- Option.defaultValue 0 v
    default this.maximumAge
        with [<Inline>] get () = Some (this |> As<Geolocation.PositionOptions>).MaximumAge
        and [<Inline>] set (v) = (this |> As<Geolocation.PositionOptions>).MaximumAge <- Option.defaultValue 0 v
