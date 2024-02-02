namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS

type FileReaderState =
    | EMPTY = 0
    | LOADING = 1
    | DONE = 2

type [<AllowNullLiteral>] FilePropertyBag =
    abstract ``type``: string with get, set
    abstract lastModified: float with get, set

type [<Global;AllowNullLiteral>] File =
    inherit Browser.Types.Blob
    abstract lastModified: float
    abstract name: string

type [<AllowNullLiteral>] FileType =
    #if !JAVASCRIPT
    [<Emit("new $0($1...)")>] 
    #else
    [<WebSharper.Inline("new File($parts,$filename,$properties)")>]
    #endif
    abstract Create: parts: obj[] * filename: string * ?properties: FilePropertyBag -> File

type [<Global;AllowNullLiteral>] FileList =
    abstract length: int
    #if !JAVASCRIPT
    [<Emit("$0[$1]{{=$2}}")>] 
    abstract Item: index: int -> File
    #else
    [<WebSharper.Inline "$this[$index]">]
    abstract Item: index: int -> File
    #endif 
    abstract item: index: int -> File

type [<Global;AllowNullLiteral>] FileReader =
    inherit EventTarget
    // abstract error: DOMException with get, set
    abstract readyState: FileReaderState
    abstract result: obj
    abstract onabort: (Event->unit) with get, set
    abstract onerror: (Event->unit) with get, set
    abstract onload: (Event->unit) with get, set
    abstract abort: unit -> unit
    abstract readAsArrayBuffer: blob: Blob -> unit
    abstract readAsBinaryString: blob: Blob -> unit
    abstract readAsDataURL: blob: Blob -> unit
    abstract readAsText: blob: Blob * ?encoding: string -> unit

type [<AllowNullLiteral>] FileReaderType =
    abstract prototype: FileReader with get, set
    #if !JAVASCRIPT
    [<Emit("new $0($1...)")>]
    #else
    [<WebSharper.Inline("new FileReader()")>]
    #endif 
    abstract Create: unit -> FileReader
