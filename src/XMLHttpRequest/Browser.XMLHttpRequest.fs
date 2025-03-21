namespace Browser.Types

open System
open Fable.Core
type ReadyState =
  /// Client has been created. `open()` was not yet called.
  | Unsent = 0
  /// `open()` has been called.
  | Opened = 1
  /// `send()` has been called, and headers and status are available.
  | HeadersReceived = 2
  /// Downloading; responseText holds partial data.
  | Loading = 3
  /// The operation is complete.
  | Done = 4


type [<Global;AllowNullLiteral>] XMLHttpRequestUpload =
    inherit EventTarget


type [<Global;AllowNullLiteral>] XMLHttpRequest =
    inherit EventTarget
    abstract onreadystatechange: (unit -> unit) with get, set
    abstract readyState: ReadyState
    abstract response: obj
    abstract responseText: string
    abstract responseType: string with get, set
    abstract responseURL: string
    abstract responseXML: obj
    abstract status: int
    abstract statusText: string
    abstract timeout: int with get, set
    abstract upload: XMLHttpRequestUpload
    abstract withCredentials: bool with get, set
    abstract abort: unit -> unit
    abstract getAllResponseHeaders: unit -> string
    abstract getResponseHeader: header: string -> string
    abstract ``open``: ``method``: string * url: string * ?async: bool * ?user: string * ?password: string -> unit
    abstract overrideMimeType: mime: string -> unit
    abstract send: ?data: obj -> unit
    abstract setRequestHeader: header: string * value: string -> unit

type [<AllowNullLiteral>] XMLHttpRequestType =
    [<Emit("new $0($1...)")>] 
    abstract Create: unit -> XMLHttpRequest

namespace Browser

open Fable.Core

open Browser.Types

[<AutoOpen>]
module XMLHttpRequest =
    let [<Global>] XMLHttpRequest: XMLHttpRequestType = 
        jsNative