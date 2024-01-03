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
[<Stub>]
#endif
type [<AllowNullLiteral>] URLSearchParams =
    /// Appends a specified key/value pair as a new search parameter.
    abstract append: name: string * value: string -> unit
    /// Deletes the given search parameter, and its associated value, from the list of all search parameters.
    abstract delete: name: string -> unit
    /// Returns the first value associated to the given search parameter.
    abstract get: name: string -> string option
    /// Returns all the values association with a given search parameter.
    abstract getAll: name: string -> array<string>
    /// Returns a Boolean indicating if such a search parameter exists.
    abstract has: name: string -> bool
    /// Sets the value associated to a given search parameter to the given value. If there were several values, delete the others.
    abstract set: name: string * value: string -> unit

type [<AllowNullLiteral>] URLSearchParamsType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #elif JAVASCRIPT
    [<Inline("new URLSearchParams($arg)")>] 
    #endif
    abstract Create: arg: obj -> URLSearchParams

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
[<Stub>]
#endif
type [<AllowNullLiteral>] URL =
    abstract hash: string with get, set
    abstract host: string with get, set
    abstract hostname: string with get, set
    abstract href: string with get, set
    abstract origin: string
    abstract password: string with get, set
    abstract pathname: string with get, set
    abstract port: string with get, set
    abstract protocol: string with get, set
    abstract search: string with get, set
    abstract username: string with get, set
    abstract searchParams: URLSearchParams
    abstract toString: unit -> string
    abstract toJSON: unit -> string

type [<AllowNullLiteral>] URLType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #elif JAVASCRIPT
    [<Inline("new URL($url,$base)")>] 
    #endif
    abstract Create: url: string * ?``base``: string -> URL
    /// Returns a DOMString containing a unique blob URL, that is a URL with blob: as its scheme, followed by an opaque string uniquely identifying the object in the browser.
    abstract createObjectURL: obj -> string
    /// Revokes an object URL previously created using URL.createObjectURL().
    abstract revokeObjectURL: string -> unit

namespace Browser

#if FABLE_COMPILER
open Fable.Core
#endif
open Browser.Types

[<AutoOpen>]
module Url =
    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<WebSharper.Inline>]
    #endif
    let URL: URLType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif

    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<WebSharper.Inline>]
    #endif
    let URLSearchParams: URLSearchParamsType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif
