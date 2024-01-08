namespace Browser.Types

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types
#if !JAVASCRIPT
[<StringEnum>]
#endif
type MediaRecorderState =
| Inactive
| Recording
| Paused

type DOMHighResTimeStamp = System.Double

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] BlobEvent =
    inherit Event
    abstract data: Blob
    abstract timecode: DOMHighResTimeStamp

type [<AllowNullLiteral>] BlobEventType =
    #if JAVASCRIPT
    [<Inline("new BlobEvent($data,$timecode)")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: data: Blob * ?timecode: DOMHighResTimeStamp -> BlobEvent

type [<AllowNullLiteral>] MediaRecorderErrorEvent =
    inherit Event
    abstract error: DOMException
#if !JAVASCRIPT
[<Global>]
#endif
type  MediaRecorder =
    abstract mimeType: string
    abstract state: MediaRecorderState
    abstract stream: MediaStream
    abstract videoBitsPerSecond: uint32
    abstract audioBitsPerSecond: uint32

    abstract pause: unit -> unit
    abstract requestData: unit -> unit
    abstract resume: unit -> unit
    abstract start: ?timeslice: float -> unit
    abstract stop: unit -> unit

    abstract isTypeSupported: string -> bool

    abstract ondataavailable: (BlobEvent -> unit) with get, set
    abstract onerror: (MediaRecorderErrorEvent -> unit) with get, set
    abstract onpause: (Event -> unit) with get, set
    abstract onresume: (Event -> unit) with get, set
    abstract onstart: (Event -> unit) with get, set
    abstract onstop: (Event -> unit) with get, set

type MediaRecorderOptions =
    abstract mimeType: string with get, set
    abstract audioBitsPerSecond: uint32 with get, set
    abstract videoBitsPerSecond: uint32 with get, set
    abstract bitsPerSecond: uint32 with get, set

type MediaRecorderType =
    #if JAVASCRIPT
    [<Inline("new MediaRecorder($stream,$options)")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: stream: MediaStream * ?options: MediaRecorderOptions -> MediaRecorder
    abstract isTypeSupported: mimeType: string -> bool

namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

[<AutoOpen>]
module MediaRecorder =
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let MediaRecorder: MediaRecorderType = jsNative
