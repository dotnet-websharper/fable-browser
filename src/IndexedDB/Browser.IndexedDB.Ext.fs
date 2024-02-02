
[<AutoOpen>]
module Browser.IndexedDBExtensions

open Fable.Core
open Browser.Types

type Window with
    #if JAVASCRIPT
    [<WebSharper.Inline("$this.indexedDB")>]
    #else
    [<Emit("$0.indexedDB")>]
    #endif
    member this.indexedDB: IDBFactory = jsNative
