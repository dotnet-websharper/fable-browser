namespace rec Browser.Types
#if FABLE_COMPILER || JAVASCRIPT
open System

#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif

type WebSocketState =
    | CONNECTING = 0
    | OPEN = 1
    | CLOSING = 2
    | CLOSED = 3


#if FABLE_COMPILER
[<Global>]
#else
//[<Stub>]
#endif
type [<AllowNullLiteral>] CloseEvent =
    inherit Event
    abstract code: int
    abstract reason: string
    abstract wasClean: bool


#if FABLE_COMPILER
[<Global>]
#else
//[<Stub>]
#endif
type [<AllowNullLiteral>] WebSocket =
    inherit EventTarget
    abstract binaryType: string with get, set
    abstract bufferedAmount: float
    abstract extensions: string
    abstract onclose: (CloseEvent -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set
    abstract onmessage: (MessageEvent -> unit) with get, set
    abstract onopen: (Event -> unit) with get, set
    abstract protocol: string
    abstract readyState: WebSocketState
    abstract url: string
    abstract close: ?code: int * ?reason: string -> unit
    abstract send: data: obj -> unit
    #if FABLE_COMPILER
    [<Emit("$0.addEventListener('close',$1...)")>] 
    #else
    [<Inline("$this.addEventListener('close',$listener,$useCapture)")>]
    #endif
    abstract addEventListener_close: listener: (CloseEvent -> unit) * ?useCapture: bool -> unit
    #if FABLE_COMPILER
    [<Emit("$0.addEventListener('error',$1...)")>] 
    #else
    [<Inline("$this.addEventListener('error',$listener,$useCapture)")>]
    #endif
    abstract addEventListener_error: listener: (ErrorEvent -> unit) * ?useCapture: bool -> unit
    #if FABLE_COMPILER
    [<Emit("$0.addEventListener('message',$1...)")>] 
    #else
    [<Inline("$this.addEventListener('message',$listener,$useCapture)")>]
    #endif
    abstract addEventListener_message: listener: (MessageEvent -> unit) * ?useCapture: bool -> unit
    #if FABLE_COMPILER
    [<Emit("$0.addEventListener('open',$1...)")>] 
    #else
    [<Inline("$this.addEventListener('open',$listener,$useCapture)")>]
    #endif
    abstract addEventListener_open: listener: (Event -> unit) * ?useCapture: bool -> unit

#if JAVASCRIPT
type U2<'A,'B> = JavaScript.Union<'A,'B>
#endif

type [<AllowNullLiteral>] WebSocketType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>]
    #else
    [<Inline("")>]
    #endif 
    abstract Create: url: string * ?protocols: U2<string, string[]> -> WebSocket

namespace Browser

#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif

open Browser.Types

[<AutoOpen>]
module WebSocket =
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif 
    let WebSocket: WebSocketType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif

#endif