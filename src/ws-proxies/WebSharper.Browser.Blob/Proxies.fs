module private Proxies
    open WebSharper
    open WebSharper.JavaScript

    [<Proxy("Fable.Core.Util, Fable.Core")>]
    module private UtilProxy =
        let [<Inline>] inline jsNative<'a> = Unchecked.defaultof<'a>

    [<Proxy(typeof<Browser.Types.BlobEndings>)>]
    type BlobEndings =
        /// Endings are stored in the blob without change
        | [<Constant("transparent")>] Transparent
        /// Line ending characters are changed to match host OS filesystem convention
        | [<Constant("native")>] Native

    [<AbstractClass; Proxy(typeof<Browser.Types.BlobPropertyBag>)>]
    type BlobPropertyBag =
        [<Inline>] 
        abstract ``type``: string with get, set
        [<Inline>] 
        abstract endings: Browser.Types.BlobEndings with get, set

    [<AbstractClass; Stub; Proxy(typeof<Browser.Types.Blob>)>]
    type Blob =
        [<Inline>] 
        abstract arrayBuffer: unit -> Promise<ArrayBuffer>
        [<Inline>] 
        abstract size: int
        [<Inline>] 
        abstract ``type``: string
        [<Inline>] 
        abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob
        [<Inline>] 
        abstract text: unit -> Promise<string>

    [<Proxy(typeof<Browser.Types.BlobType>)>]
    type BlobType =
        [<Inline("new Blob($blobParts, $options)")>] abstract Create: ?blobParts: obj[] * ?options: BlobPropertyBag -> Blob
    
    [<AbstractClass; Stub; Proxy(typeof<Browser.Types.FormData>)>]
    type FormDataProxy =
        [<Inline>] 
        abstract append: name: string * value: string -> unit
        [<Inline>] 
        abstract append: name: string * value: Blob * ?filename: string -> unit
        [<Inline>] 
        abstract delete: name: string -> unit
        [<Inline>] 
        abstract entries: unit -> (string * obj) seq
        [<Inline>] 
        abstract get: name: string -> obj
        [<Inline>] 
        abstract getAll: name: string -> obj[]
        [<Inline>] 
        abstract has: name: string -> bool
        [<Inline>] 
        abstract keys: unit -> string seq
        [<Inline>] 
        abstract set: name: string * value: string -> unit
        [<Inline>] 
        abstract set: name: string * value: Blob * ?filename: string -> unit
        [<Inline>] 
        abstract values: unit -> obj seq

    [<Proxy(typeof<Browser.Types.FormDataType>)>]
    type FormDataType =
        [<Inline "new FormData()">]
        member _.Create() = Unchecked.defaultof<FormData>

    [<Proxy("Browser.Types.BlobModule, Browser.Blob")>]
    module BlobModuleProxy =
        
        let [<Inline>] FormData = Unchecked.defaultof<FormDataType>
        let [<Inline>] Blob = Unchecked.defaultof<BlobType>
