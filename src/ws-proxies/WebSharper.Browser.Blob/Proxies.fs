namespace Browser.Types
    open WebSharper
    open WebSharper.JavaScript

    [<AutoOpen;InternalProxy("Fable.Core.Util, Fable.Core")>]
    module internal UtilProxy =
        let [<Inline>] inline jsNative<'a> = Unchecked.defaultof<'a>
    module internal JsProxy =
        type PromiseProxy<'T> = Promise<'T>

    // [<Stub>]
    // type BlobEndings =
    //     /// Endings are stored in the blob without change
    //     | [<Constant("transparent")>] Transparent
    //     /// Line ending characters are changed to match host OS filesystem convention
    //     | [<Constant("native")>] Native

    // [<Stub>]
    // type BlobPropertyBag =
    //     [<Inline>] 
    //     abstract ``type``: string with get, set
    //     [<Inline>] 
    //     abstract endings: Browser.Types.BlobEndings with get, set

    // [<Stub>]
    // type Blob =
    //     [<Inline>] 
    //     abstract arrayBuffer: unit -> Promise<ArrayBuffer>
    //     [<Inline>] 
    //     abstract size: int
    //     [<Inline>] 
    //     abstract ``type``: string
    //     [<Inline>] 
    //     abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob
    //     [<Inline>] 
    //     abstract text: unit -> Promise<string>

    // type BlobType =
    //     [<Inline("new Blob($blobParts, $options)")>] member this.Create(?blobParts: obj[], ?options: BlobPropertyBag): Blob = jsNative
    
    // [<Stub>]
    // type FormData =
    //     [<Inline>] 
    //     abstract append: name: string * value: string -> unit
    //     [<Inline>] 
    //     abstract append: name: string * value: Blob * ?filename: string -> unit
    //     [<Inline>] 
    //     abstract delete: name: string -> unit
    //     [<Inline>] 
    //     abstract entries: unit -> (string * obj) seq
    //     [<Inline>] 
    //     abstract get: name: string -> obj
    //     [<Inline>] 
    //     abstract getAll: name: string -> obj[]
    //     [<Inline>] 
    //     abstract has: name: string -> bool
    //     [<Inline>] 
    //     abstract keys: unit -> string seq
    //     [<Inline>] 
    //     abstract set: name: string * value: string -> unit
    //     [<Inline>] 
    //     abstract set: name: string * value: Blob * ?filename: string -> unit
    //     [<Inline>] 
    //     abstract values: unit -> obj seq

    // type FormDataType =
    //     [<Inline "new FormData()">]
    //     member _.Create() = Unchecked.defaultof<FormData>

    // [<Proxy("Browser.Blob, Browser.Blob")>]
    // module BlobModuleProxy =
        
    //     let [<Inline>] FormData : Browser.Types.FormDataType = jsNative
    //     let [<Inline>] Blob : Browser.Types.BlobType = jsNative
