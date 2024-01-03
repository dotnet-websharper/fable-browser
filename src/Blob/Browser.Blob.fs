namespace Browser.Types
#if FABLE_COMPILER || JAVASCRIPT
open System
#if FABLE_COMPILER
open Fable.Core
open Fable.Core.JS
#else
open WebSharper
open WebSharper.JavaScript
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

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
[<Stub>]
#endif
type [<AllowNullLiteral>] Blob =
    abstract arrayBuffer: unit -> Promise<ArrayBuffer>
    abstract size: int
    abstract ``type``: string
    abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob
    abstract text: unit -> Promise<string>

type [<AllowNullLiteral>] BlobType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #else
    [<Inline("new Blob($blobParts, $options)")>]
    #endif
    abstract Create: ?blobParts: obj[] * ?options: BlobPropertyBag -> Blob

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
[<Stub>]
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
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #else
    [<Inline("new FormData()")>]
    #endif
    abstract Create: unit -> FormData

namespace Browser

#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types

[<AutoOpen>]
module Blob =
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let Blob: BlobType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let FormData: FormDataType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif
#endif