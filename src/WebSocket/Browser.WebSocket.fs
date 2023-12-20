namespace rec Browser.Types

open System
// open Fable.Core

type WebSocketState =
    | CONNECTING = 0
    | OPEN = 1
    | CLOSING = 2
    | CLOSED = 3

type [<AllowNullLiteral; WebSharper.Stub>] CloseEvent =
    inherit Event
    abstract code: int
    abstract reason: string
    abstract wasClean: bool

type [<AllowNullLiteral; AbstractClass; WebSharper.Stub>] WebSocket =
    inherit EventTarget
    member this.binaryType
        with [<WebSharper.Inline>] get () : string = jsNative
        and [<WebSharper.Inline>] set (v:string): unit = jsNative
    member this.bufferedAmount: float = jsNative
    member this.extensions: string = jsNative
    member this.onclose
        with [<WebSharper.Inline>] get () : (CloseEvent -> unit) = jsNative
        and [<WebSharper.Inline>] set (v:  (CloseEvent -> unit) ) : unit = jsNative
    member this.onerror 
        with [<WebSharper.Inline>] get () : (Event -> unit) = jsNative
        and [<WebSharper.Inline>] set (v: (Event -> unit)) = jsNative
    member this.onmessage
        with get(): (MessageEvent -> unit) = jsNative
        and set (v: (MessageEvent -> unit)) = jsNative
    member this.onopen
        with get(): (Event -> unit) = jsNative
        and set (v: (Event -> unit)) = jsNative
    member this.protocol: string = jsNative
    member this.readyState: WebSocketState = jsNative
    member this.url: string = jsNative
    member this.close(?code: int, ?reason: string): unit = jsNnative
    member this.send(data: obj -> unit) = jsNative
    [<WebSharper.Inline("$this.addEventListener('close',$listener, $useCapture)")>] 
    member this.addEventListener_close(listener: CloseEvent -> unit, ?useCapture: bool): unit = jsNative
    [<WebSharper.Inline("$this.addEventListener('error',$listener, $useCapture)")>] 
    member this.addEventListener_error(listener: ErrorEvent -> unit, ?useCapture: bool): unit = jsNative
    [<WebSharper.Inline("$this.addEventListener('message',$listener, $useCapture)")>] 
    member this.addEventListener_message(listener: MessageEvent -> unit, ?useCapture: bool): unit = jsNative
    [<WebSharper.Inline("$this.addEventListener('open',$listener, $useCapture)")>] 
    member this.addEventListener_open(listener: Event -> unit, ?useCapture: bool): unit = jsNative

type [<AllowNullLiteral>] WebSocketType =
    [<WebSharper.Inline("new $0($1...)")>] abstract Create: url: string * ?protocols: U2<string, string[]> -> WebSocket

namespace Browser

open Browser.Types

[<AutoOpen>]
module WebSocket =
    let [<WebSharper.Inline>] WebSocket: WebSocketType = jsNative
