namespace Browser.Types
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types
#if FABLE_COMPILER
[<StringEnum>]
#endif
type MediaRecorderState =
| Inactive
| Recording
| Paused

type DOMHighResTimeStamp = System.Double

#if FABLE_COMPILER
[<Global>]
#else
//[<Stub>]
#endif
type [<AllowNullLiteral>] BlobEvent =
    inherit Event
    abstract data: Blob
    abstract timecode: DOMHighResTimeStamp

type [<AllowNullLiteral>] BlobEventType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>]
    #else
    [<Inline("new BlobEvent($data,$timecode)")>]
    #endif
    abstract Create: data: Blob * ?timecode: DOMHighResTimeStamp -> BlobEvent

type [<AllowNullLiteral>] MediaRecorderErrorEvent =
    inherit Event
    abstract error: DOMException
#if FABLE_COMPILER
[<Global>]
#else
//[<Stub>]
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
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>]
    #else
    [<Inline("new MediaRecorder($stream,$options)")>]
    #endif
    abstract Create: stream: MediaStream * ?options: MediaRecorderOptions -> MediaRecorder
    abstract isTypeSupported: mimeType: string -> bool

namespace Browser

#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types

[<AutoOpen>]
module MediaRecorder =
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let MediaRecorder: MediaRecorderType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif

#endif