namespace Browser.Types

open System
open WebSharper
open WebSharper.JavaScript

[<AutoOpen;InternalProxy("Fable.Core.Util,Fable.Core")>]
module UtilProxy =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>

// [<Proxy(typeof<Browser.Types.ReadyState>)>]
// type ReadyStateProxy =
//   /// Client has been created. `open()` was not yet called.
//   | Unsent = 0
//   /// `open()` has been called.
//   | Opened = 1
//   /// `send()` has been called, and headers and status are available.
//   | HeadersReceived = 2
//   /// Downloading; responseText holds partial data.
//   | Loading = 3
//   /// The operation is complete.
//   | Done = 4

// type [<Proxy(typeof<Browser.Types.XMLHttpRequestUpload>)>] XMLHttpRequestUploadProxy =
//     inherit Browser.Types.EventTarget

// type [<Proxy(typeof<Browser.Types.XMLHttpRequest>)>] XMLHttpRequestProxy =
//     inherit Browser.Types.EventTarget
//     [<Inline>] abstract onreadystatechange: (unit -> unit) with get, set
//     [<Inline>] abstract readyState: ReadyState
//     [<Inline>] abstract response: obj
//     [<Inline>] abstract responseText: string
//     [<Inline>] abstract responseType: string with get, set
//     [<Inline>] abstract responseURL: string
//     [<Inline>] abstract responseXML: obj
//     [<Inline>] abstract status: int
//     [<Inline>] abstract statusText: string
//     [<Inline>] abstract timeout: int with get, set
//     [<Inline>] abstract upload: Browser.Types.XMLHttpRequestUpload
//     [<Inline>] abstract withCredentials: bool with get, set
//     [<Inline>] abstract abort: unit -> unit
//     [<Inline>] abstract getAllResponseHeaders: unit -> string
//     [<Inline>] abstract getResponseHeader: header: string -> string
//     [<Inline>] abstract ``open``: ``method``: string * url: string * ?async: bool * ?user: string * ?password: string -> unit
//     [<Inline>] abstract overrideMimeType: mime: string -> unit
//     [<Inline>] abstract send: ?data: obj -> unit
//     [<Inline>] abstract setRequestHeader: header: string * value: string -> unit

// type [<Proxy(typeof<Browser.Types.XMLHttpRequestType>)>] XMLHttpRequestTypeProxy =
//     [<Inline("new XMLHttpRequest()")>] abstract Create: unit -> XMLHttpRequest


// [<Proxy("Browser.XMLHttpRequest, Browser.XMLHttpRequest")>]
// module XMLHttpRequestProxy =
//     let [<Inline>] XMLHttpRequest: Browser.Types.XMLHttpRequestType = jsNative
