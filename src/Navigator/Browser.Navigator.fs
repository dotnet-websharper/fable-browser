namespace Browser.Types

open System
#if JAVASCRIPT
open WebSharper
open WebSharper.JavaScript

module internal JS =
    type Promise<'a> = JavaScript.Promise<'a>
#else
open Fable.Core
#endif

#if !JAVASCRIPT
[<Global>]
#endif
type MimeType =
    abstract description: string
    abstract enabledPlugin: Plugin
    abstract suffixes: string
    abstract ``type``: string

#if !JAVASCRIPT
and [<Global>] Plugin =
#else
and Plugin =
#endif
    abstract description: string
    abstract filename: string
    abstract length: int
    abstract name: string
    abstract version: string
    abstract item: index: int -> MimeType
    abstract namedItem: ``type``: string -> MimeType

type ShareData =
    abstract url: string with get, set
    abstract text: string with get, set
    abstract title: string with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type Clipboard =
    abstract writeText: string -> JS.Promise<unit>
    abstract readText: unit -> JS.Promise<string>

type NavigatorID =
    abstract appName: string
    abstract appVersion: string
    abstract platform: string
    abstract product: string
    abstract productSub: string
    abstract userAgent: string
    abstract vendor: string
    abstract vendorSub: string

type NavigatorOnLine =
    abstract onLine: bool

type NavigatorUserMediaSuccessCallback = MediaStream -> unit
type NavigatorUserMediaErrorCallback = MediaStreamError -> unit // TODO: missing MediaStreamError class in WS.JS

#if !JAVASCRIPT
[<StringEnum>]
#endif
[<RequireQualifiedAccess>]
type PermissionState =
    | Granted
    | Denied
    | Prompt

[<AllowNullLiteral>]
type PermissionStatus =
    abstract state: PermissionState
    abstract status: PermissionState
    abstract onchange: 
        #if JAVASCRIPT
        (Dom.Event -> unit)
        #else
        (Event -> unit) 
        #endif
        with get, set

#if JAVASCRIPT
[<RequireQualifiedAccess>]
type PermissionName =
    | [<Constant "geolocation">] Geolocation
    | [<Constant "notifications">] Notifications
    | [<Constant "push">] Push
    | [<Constant "midi">] Midi
    | [<Constant "camera">] Camera
    | [<Constant "microphone">] Microphone
    | [<Constant "speaker-selection">] SpeakerSelection
    | [<Constant "device-info">] DeviceInfo
    | [<Constant "background-fetch">] BackgroundFetch
    | [<Constant "background-sync">] BackgroundSync
    | [<Constant "bluetooth">] Bluetooth
    | [<Constant "persistent-storage">] PersistentStorage
    | [<Constant "ambient-light-sensor">] AmbientLightSensor
    | [<Constant "accelerometer">] Accelerometer
    | [<Constant "gyroscope">] Gyroscope
    | [<Constant "magnetometer">] Magnetometer
    | [<Constant "clipboard.read">] ClipboardRead
    | [<Constant "clipboard-write">] ClipboardWrite
    | [<Constant "display-capture">] DisplayCapture
    | [<Constant "nfc">] NFC
#else
[<StringEnum(CaseRules.KebabCase); RequireQualifiedAccess>]
type PermissionName =
    | Geolocation
    | Notifications
    | Push
    | Midi
    | Camera
    | Microphone
    | SpeakerSelection
    | DeviceInfo
    | BackgroundFetch
    | BackgroundSync
    | Bluetooth
    | PersistentStorage
    | AmbientLightSensor
    | Accelerometer
    | Gyroscope
    | Magnetometer
    | ClipboardRead
    | ClipboardWrite
    | DisplayCapture
    | NFC
#endif

[<AllowNullLiteral>]
type PermissionDescriptor =
    abstract name: PermissionName with get, set
    abstract userVisibleOnly: bool with get, set
    abstract sysex: bool with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type Permissions =
    #if JAVASCRIPT
   abstract query: (PermissionDescriptor -> Promise<PermissionStatus>)
    #else
    abstract query: (PermissionDescriptor -> JS.Promise<PermissionStatus>)
    #endif
    // TODO, currently not supported in any browser: abstract request: unit -> unit
    // TODO, currently not supported in any browser: abstract requestAll: unit -> unit

#if !JAVASCRIPT
[<Global>]
#endif
type Navigator =
    inherit NavigatorID
    inherit NavigatorOnLine
    // TODO: abstract activeVRDisplays
    abstract appCodeName: string
    abstract appMinorVersion: string
    // abstract battery // Deprecated
    abstract clipboard: Clipboard option
    // TODO: abstract connection
    abstract cookieEnabled: bool
    abstract geolocation: Geolocation option
    abstract hardwareConcurrency: int
    // TODO: abstract keyboard
    abstract cpuClass: string
    abstract language: string option
    abstract languages: string[] option
    // TODO: abstract locks
    // TODO: abstract mediaCapabilities
    abstract maxTouchPoints: int
    abstract mimeTypes: MimeType[] option
    abstract oscpu: string
    abstract permissions: Permissions
    // abstract platform: string // Not reliable
    abstract plugins: Plugin[] option
    abstract serviceWorker: ServiceWorkerContainer option
    // TODO: abstract storage: StorageManager
    abstract userAgent: string
    abstract webdriver: bool
    abstract getGamepads: unit -> ResizeArray<Gamepad option>
    abstract webkitGetGamepads: unit -> ResizeArray<float>

// ## Methods

    abstract canShare: unit -> bool
    // TODO: abstract getVRDisplays()

    // NOT TODO: Navigator.getUserMedia is deprecated in favor of navigator.mediaDevices.getUserMedia()
    // See: https://developer.mozilla.org/en-US/docs/Web/API/Navigator/getUserMedia
    // abstract getUserMedia: constraints: MediaStreamConstraints * successCallback: NavigatorUserMediaSuccessCallback * errorCallback: NavigatorUserMediaErrorCallback -> unit

    // TODO: abstract registerProtocolHandler()
    // TODO: abstract requestMediaKeySystemAccess()
    // TODO: abstract sendBeacon()
    abstract share: ShareData -> JS.Promise<unit>
    /// Pulses the vibration hardware on the device, if such hardware exists. If the device doesn't support vibration, this method has no effect. If a vibration pattern is already in progress when this method is called, the previous pattern is halted and the new one begins instead.
    /// - pattern: Provides a pattern of vibration and pause intervals. Each value indicates a number of milliseconds to vibrate or pause, in alternation. You may provide either a single value (to vibrate once for that many milliseconds) or an array of values to alternately vibrate, pause, then vibrate again. See Vibration API for details.
    abstract vibrate: pattern: obj -> bool

namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif

open Browser.Types

[<AutoOpen>]
module Navigator =
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let navigator: Navigator = jsNative