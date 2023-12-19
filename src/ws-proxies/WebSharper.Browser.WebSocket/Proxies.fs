module private Proxies

open WebSharper
open WebSharper.JavaScript

[<AutoOpen;InternalProxy("Fable.Core.Util, Fable.Core")>]
module UtilProxies =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>

// TODO: needs check/convo about compat with WS.JS.Union
[<InternalProxy(typeof<Fable.Core.U2<_,_>>)>]
type U2Proxy<'a,'b> = 
| [<Inline>] Case1 of 'a
| [<Inline>] Case2 of 'b

[<Proxy(typeof<Browser.Types.WebSocketState>)>]
type WebSocketState =
    | CONNECTING = 0
    | OPEN = 1
    | CLOSING = 2
    | CLOSED = 3

type [<Proxy(typeof<Browser.Types.CloseEvent>)>] CloseEvent =
    inherit Browser.Types.Event
    [<Inline>] abstract code: int
    [<Inline>] abstract reason: string
    [<Inline>] abstract wasClean: bool

type [<Proxy(typeof<Browser.Types.WebSocket>)>] WebSocket =
    inherit Browser.Types.EventTarget
    [<Inline>] abstract binaryType: string with get, set
    [<Inline>] abstract bufferedAmount: float
    [<Inline>] abstract extensions: string
    [<Inline>] abstract onclose: (Browser.Types.CloseEvent -> unit) with get, set
    [<Inline>] abstract onerror: (Browser.Types.Event -> unit) with get, set
    [<Inline>] abstract onmessage: (Browser.Types.MessageEvent -> unit) with get, set
    [<Inline>] abstract onopen: (Browser.Types.Event -> unit) with get, set
    [<Inline>] abstract protocol: string
    [<Inline>] abstract readyState: Browser.Types.WebSocketState
    [<Inline>] abstract url: string
    [<Inline>] abstract close: ?code: int * ?reason: string -> unit
    [<Inline>] abstract send: data: obj -> unit
    [<Inline("$0.addEventListener('close', $listener, $useCapture)")>] abstract addEventListener_close: listener: (Browser.Types.CloseEvent -> unit) * ?useCapture: bool -> unit
    [<Inline("$0.addEventListener('error', $listener, $useCapture)")>] abstract addEventListener_error: listener: (Browser.Types.ErrorEvent -> unit) * ?useCapture: bool -> unit
    [<Inline("$0.addEventListener('message', $listener, $useCapture)")>] abstract addEventListener_message: listener: (Browser.Types.MessageEvent -> unit) * ?useCapture: bool -> unit
    [<Inline("$0.addEventListener('open', $listener, $useCapture)")>] abstract addEventListener_open: listener: (Browser.Types.Event -> unit) * ?useCapture: bool -> unit

type [<Proxy(typeof<Browser.Types.WebSocketType>)>] WebSocketType =
    [<Inline("new WebSocket($url, $protocols)")>] abstract Create: url: string * ?protocols: Fable.Core.U2<string, string[]> -> Browser.Types.WebSocket

[<AutoOpen>]
module WebSocket =
    let [<Inline>] WebSocket: Browser.Types.WebSocketType = jsNative