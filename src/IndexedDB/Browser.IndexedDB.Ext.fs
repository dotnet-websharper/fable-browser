
[<AutoOpen>]
module Browser.IndexedDBExtensions

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

type Window with
    #if JAVASCRIPT
    [<Inline("$this.indexedDB")>]
    #else
    [<Emit("$0.indexedDB")>]
    #endif
    member this.indexedDB: IDBFactory = jsNative
