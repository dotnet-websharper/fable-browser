namespace Browser.Types

open System
#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif


#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] Storage =
    abstract length: int
#if JAVASCRIPT
// TODO: bro how do I
#else
    [<Emit("$0[$1]{{=$2}}")>]
#endif
    abstract Item: key: string -> string with get, set
#if JAVASCRIPT
// TODO: bro how do I
#else
    [<Emit("$0[$1]{{=$2}}")>]
#endif
    abstract Item: index: int -> string with get, set
    abstract clear: unit -> unit
    abstract getItem: key: string -> string
    abstract key: index: float -> string
    abstract removeItem: key: string -> unit
    abstract setItem: key: string * data: string -> unit


#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] StorageEvent =
    inherit Event
    abstract url: string
    abstract key: string
    abstract oldValue: string
    abstract newValue: string
    abstract storageArea: Storage

namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif

open Browser.Types

[<AutoOpen>]
module WebStorage =

    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let localStorage: Storage = 
        #if FABLE_COMPILER
        jsNative

        #else
        Unchecked.defaultof<_>
        #endif
    
    
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let sessionStorage: Storage = 
        #if FABLE_COMPILER
        jsNative

        #else
        Unchecked.defaultof<_>
        #endif
    
