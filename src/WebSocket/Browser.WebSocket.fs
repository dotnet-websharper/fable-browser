namespace rec Browser.Types

open System

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif

type WebSocketState =
    | CONNECTING = 0
    | OPEN = 1
    | CLOSING = 2
    | CLOSED = 3


#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] CloseEvent =
    inherit Event
    abstract code: int
    abstract reason: string
    abstract wasClean: bool


#if !JAVASCRIPT
[<Global>]
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
    #if JAVASCRIPT
    [<Inline("$this.addEventListener('close',$listener,$useCapture)")>]
    #else
    [<Emit("$0.addEventListener('close',$1...)")>] 
    #endif
    abstract addEventListener_close: listener: (CloseEvent -> unit) * ?useCapture: bool -> unit
    #if JAVASCRIPT
    [<Inline("$this.addEventListener('error',$listener,$useCapture)")>]
    #else
    [<Emit("$0.addEventListener('error',$1...)")>] 
    #endif
    abstract addEventListener_error: listener: (ErrorEvent -> unit) * ?useCapture: bool -> unit
    #if JAVASCRIPT
    [<Inline("$this.addEventListener('message',$listener,$useCapture)")>]
    #else
    [<Emit("$0.addEventListener('message',$1...)")>] 
    #endif
    abstract addEventListener_message: listener: (MessageEvent -> unit) * ?useCapture: bool -> unit
    #if JAVASCRIPT
    [<Inline("$this.addEventListener('open',$listener,$useCapture)")>]
    #else
    [<Emit("$0.addEventListener('open',$1...)")>] 
    #endif
    abstract addEventListener_open: listener: (Event -> unit) * ?useCapture: bool -> unit

#if JAVASCRIPT
type U2<'A,'B> = JavaScript.Union<'A,'B>
#endif

type [<AllowNullLiteral>] WebSocketType =
    #if JAVASCRIPT
    [<Inline("")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif 
    abstract Create: url: string * ?protocols: U2<string, string[]> -> WebSocket

namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif

open Browser.Types

[<AutoOpen>]
module WebSocket =
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif 
    let WebSocket: WebSocketType = 
        #if JAVASCRIPT
        Unchecked.defaultof<_>
        #else
        jsNative
        #endif
