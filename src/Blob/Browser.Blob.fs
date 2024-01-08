namespace Browser.Types

open System
#if JAVASCRIPT
open WebSharper
open WebSharper.JavaScript

[<AutoOpen>]
module internal FableUtil =
    let [<Inline>] jsNative<'t> = Unchecked.defaultof<'t>
#else
open Fable.Core
open Fable.Core.JS
#endif

type EnumNameAttribute =
    #if JAVASCRIPT
    WebSharper.ConstantAttribute
    #else
    CompiledNameAttribute
    #endif

[<RequireQualifiedAccess>]
type BlobEndings =
    /// Endings are stored in the blob without change
    | [<EnumName("transparent")>] Transparent
    /// Line ending characters are changed to match host OS filesystem convention
    | [<EnumName("native")>] Native

type [<AllowNullLiteral>] BlobPropertyBag =
    abstract ``type``: string with get, set
    abstract endings: BlobEndings with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] Blob =
    abstract arrayBuffer: unit -> Promise<ArrayBuffer>
    abstract size: int
    abstract ``type``: string
    abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob
    abstract text: unit -> Promise<string>

type [<AllowNullLiteral>] BlobType =
    #if JAVASCRIPT
    [<Inline("new Blob($blobParts, $options)")>]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create: ?blobParts: obj[] * ?options: BlobPropertyBag -> Blob

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] FormData =
    abstract append: name: string * value: string -> unit
    abstract append: name: string * value: Blob * ?filename: string -> unit
    abstract delete: name: string -> unit
    abstract entries: unit -> (string * obj) seq
    abstract get: name: string -> obj
    abstract getAll: name: string -> obj[]
    abstract has: name: string -> bool
    abstract keys: unit -> string seq
    abstract set: name: string * value: string -> unit
    abstract set: name: string * value: Blob * ?filename: string -> unit
    abstract values: unit -> obj seq

type [<AllowNullLiteral>] FormDataType =
    #if JAVASCRIPT
    [<Inline("new FormData()")>]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create: unit -> FormData

namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

[<AutoOpen>]
module Blob =
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let Blob: BlobType = 
        jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let FormData: FormDataType = 
        jsNative
