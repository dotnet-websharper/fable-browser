namespace Browser.Types

open Fable.Core
open Browser.Types
[<StringEnum>]
type MediaRecorderState =
| Inactive
| Recording
| Paused

type DOMHighResTimeStamp = System.Double

type [<Global;AllowNullLiteral>] BlobEvent =
    inherit Event
    abstract data: Blob
    abstract timecode: DOMHighResTimeStamp

type [<AllowNullLiteral>] BlobEventType =
    #if JAVASCRIPT
    [<WebSharper.Inline("new BlobEvent($data,$timecode)")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: data: Blob * ?timecode: DOMHighResTimeStamp -> BlobEvent

type [<AllowNullLiteral>] MediaRecorderErrorEvent =
    inherit Event
    abstract error: DOMException
type [<Global>]  MediaRecorder =
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
    [<WebSharper.Inline("new MediaRecorder($stream,$options)")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: stream: MediaStream * ?options: MediaRecorderOptions -> MediaRecorder
    abstract isTypeSupported: mimeType: string -> bool

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module MediaRecorder =
    let [<Global>] MediaRecorder: MediaRecorderType = 
        #if JAVASCRIPT
        // TODO: move to jsNative proxy
        Unchecked.defaultof<_>
        #else
        jsNative
        #endif
