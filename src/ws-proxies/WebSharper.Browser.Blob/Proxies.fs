module private Proxies
    open WebSharper
    open WebSharper.JavaScript

    [<Proxy("Fable.Core.Util, Fable.Core")>]
    module private UtilProxy =
        let [<Inline>] inline jsNative<'a> = Unchecked.defaultof<'a>

    // [<Proxy(typeof<Browser.Types.BlobEndings>)>]
    // type BlobEndings =
    //     /// Endings are stored in the blob without change
    //     | [<Constant("transparent")>] Transparent
    //     /// Line ending characters are changed to match host OS filesystem convention
    //     | [<Constant("native")>] Native

    // [<AbstractClass; Proxy(typeof<Browser.Types.BlobPropertyBag>)>]
    // type BlobPropertyBag =
    //     abstract ``type``: string with get, set
    //     abstract endings: Browser.Types.BlobEndings with get, set

    // [<AbstractClass; Stub; Proxy(typeof<Browser.Types.Blob>)>]
    // type Blob =
    //     abstract arrayBuffer: unit -> Promise<ArrayBuffer>
    //     abstract size: int
    //     abstract ``type``: string
    //     abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob
    //     abstract text: unit -> Promise<string>

    // [<Proxy(typeof<Browser.Types.BlobType>)>]
    // type BlobType =
    //     [<Inline("new Blob($1...)")>] abstract Create: ?blobParts: obj[] * ?options: BlobPropertyBag -> Blob
    
    // [<AbstractClass; Stub; Proxy(typeof<Browser.Types.FormData>)>]
    // type FormDataProxy =
    //     abstract append: name: string * value: string -> unit
    //     abstract append: name: string * value: Blob * ?filename: string -> unit
    //     abstract delete: name: string -> unit
    //     abstract entries: unit -> (string * obj) seq
    //     abstract get: name: string -> obj
    //     abstract getAll: name: string -> obj[]
    //     abstract has: name: string -> bool
    //     abstract keys: unit -> string seq
    //     abstract set: name: string * value: string -> unit
    //     abstract set: name: string * value: Blob * ?filename: string -> unit
    //     abstract values: unit -> obj seq

    // [<Proxy(typeof<Browser.Types.FormDataType>)>]
    // type FormDataType =
    //     [<Inline "new FormData()">]
    //     member _.Create() = Unchecked.defaultof<FormData>

    // [<Proxy("Browser.Types.BlobModule, Browser.Blob")>]
    // module BlobModuleProxy =
        
    //     let [<Inline>] FormData = Unchecked.defaultof<FormDataType>
    //     let [<Inline>] Blob = Unchecked.defaultof<BlobType>
