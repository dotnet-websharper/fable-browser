namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS

type private EnumNameAttribute =
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

type [<Global;AllowNullLiteral>] Blob =
    abstract arrayBuffer: unit -> Promise<ArrayBuffer>
    abstract size: int
    abstract ``type``: string
    abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob
    abstract text: unit -> Promise<string>

type [<AllowNullLiteral>] BlobType =
    [<Emit("new $0($1...)")>]
    abstract Create: ?blobParts: obj[] * ?options: BlobPropertyBag -> Blob

type [<Global;AllowNullLiteral>] FormData =
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
    [<Emit("new $0($1...)")>]
    abstract Create: unit -> FormData

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Blob =
    let [<Global>] Blob: BlobType = 
        jsNative
    let [<Global>] FormData: FormDataType = 
        jsNative
