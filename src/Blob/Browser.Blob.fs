namespace Browser.Types

open System

[<RequireQualifiedAccess>]
type BlobEndings =
    /// Endings are stored in the blob without change
    | [<WebSharper.Constant("transparent")>] Transparent
    /// Line ending characters are changed to match host OS filesystem convention
    | [<WebSharper.Constant("native")>] Native

type [<AllowNullLiteral; WebSharper.Stub>] BlobPropertyBag =
    abstract ``type``: string with get, set
    abstract endings: BlobEndings with get, set

type [<AllowNullLiteral; WebSharper.Stub>] Blob =
    abstract arrayBuffer: unit -> WebSharper.JavaScript.Promise<WebSharper.JavaScript.ArrayBuffer>
    abstract size: int
    abstract ``type``: string
    abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob
    abstract text: unit -> WebSharper.JavaScript.Promise<string>

type [<AllowNullLiteral>] BlobType =
    [<WebSharper.Inline("new Blob($blobParts, $options)")>] 
    member this.Create(?blobParts: obj[], ?options: BlobPropertyBag): Blob = jsNative

type [<AllowNullLiteral; WebSharper.Stub>] FormData =
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
    [<WebSharper.Inline("new FormData()")>] 
    member this.Create(): FormData = jsNative

namespace Browser

open Browser.Types

[<AutoOpen>]
module Blob =
    let [<WebSharper.Inline>] Blob: BlobType = jsNative
    let [<WebSharper.Inline>] FormData: FormDataType = jsNative
