namespace Browser.Types

open System

open Fable.Core

type [<Global;AllowNullLiteral>] Storage =
    abstract length: int
    #if JAVASCRIPT
    [<WebSharper.Inline "$this[$key]">]
    abstract Item: key: string -> string with get

    [<WebSharper.Inline "$this[$key]=$2">]
    abstract Item: key: string -> string with set
    #else
    [<Emit("$0[$1]{{=$2}}")>]
    abstract Item: key: string -> string with get, set
    #endif
    #if JAVASCRIPT
    [<WebSharper.Inline "$this[$index]">]
    abstract Item: index: int -> string with get
    [<WebSharper.Inline "$this[$index]=$2">]
    abstract Item: index: int -> string with set
    #else
    [<Emit("$0[$1]{{=$2}}")>]
    abstract Item: index: int -> string with get, set
    #endif
    abstract clear: unit -> unit
    abstract getItem: key: string -> string
    abstract key: index: float -> string
    abstract removeItem: key: string -> unit
    abstract setItem: key: string * data: string -> unit


type [<Global;AllowNullLiteral>] StorageEvent =
    inherit Event
    abstract url: string
    abstract key: string
    abstract oldValue: string
    abstract newValue: string
    abstract storageArea: Storage

namespace Browser


open Fable.Core
open Browser.Types

[<AutoOpen>]
module WebStorage =

    let [<Global>] localStorage: Storage = 
        jsNative
    
    
    let [<Global>] sessionStorage: Storage = 
        jsNative
    
