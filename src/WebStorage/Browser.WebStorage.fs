namespace Browser.Types

open System
#if FABLE_COMPILER
open Fable.Core
#elif JAVASCRIPT
open WebSharper
#endif


#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] Storage =
    abstract length: int
#if FABLE_COMPILER
    [<Emit("$0[$1]{{=$2}}")>] 
#elif JAVASCRIPT
// TODO: bro how do I
#endif
    abstract Item: key: string -> string with get, set
#if FABLE_COMPILER
    [<Emit("$0[$1]{{=$2}}")>] 
#elif JAVASCRIPT
// TODO: bro how do I
#endif
    abstract Item: index: int -> string with get, set
    abstract clear: unit -> unit
    abstract getItem: key: string -> string
    abstract key: index: float -> string
    abstract removeItem: key: string -> unit
    abstract setItem: key: string * data: string -> unit


#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] StorageEvent =
    inherit Event
    abstract url: string
    abstract key: string
    abstract oldValue: string
    abstract newValue: string
    abstract storageArea: Storage

namespace Browser

#if FABLE_COMPILER
open Fable.Core
#elif JAVASCRIPT
open WebSharper
#endif

open Browser.Types

[<AutoOpen>]
module WebStorage =

    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<Inline>]
    #endif
    let localStorage: Storage = 
        #if FABLE_COMPILER
        jsNative

        #else
        Unchecked.defaultof<_>
        #endif
    
    
    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<Inline>]
    #endif
    let sessionStorage: Storage = 
        #if FABLE_COMPILER
        jsNative

        #else
        Unchecked.defaultof<_>
        #endif
    
