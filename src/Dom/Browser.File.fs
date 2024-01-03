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

type FileReaderState =
    | EMPTY = 0
    | LOADING = 1
    | DONE = 2

type [<AllowNullLiteral>] FilePropertyBag =
    abstract ``type``: string with get, set
    abstract lastModified: float with get, set

#if FABLE_COMPILER
[<Global>]
#else
[<Stub>]
#endif
type [<AllowNullLiteral>] File =
    inherit Blob
    abstract lastModified: float
    abstract name: string

type [<AllowNullLiteral>] FileType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #else
    [<Inline("new File($parts,$filename,$properties)")>]
    #endif
    abstract Create: parts: obj[] * filename: string * ?properties: FilePropertyBag -> File

#if FABLE_COMPILER
[<Global>]
#else
[<Stub>]
#endif
type [<AllowNullLiteral>] FileList =
    abstract length: int
    #if FABLE_COMPILER
    [<Emit("$0[$1]{{=$2}}")>] 
    #else
    // TODO
    #endif 
    abstract Item: index: int -> File
    abstract item: index: int -> File

#if FABLE_COMPILER
[<Global>]
#else
[<Stub>]
#endif
type [<AllowNullLiteral>] FileReader =
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
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>]
    #else
    [<Inline("new FileReader()")>]
    #endif 
    abstract Create: unit -> FileReader

#endif