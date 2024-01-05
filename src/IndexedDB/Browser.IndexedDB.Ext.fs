
[<AutoOpen>]
module Browser.IndexedDBExtensions
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types

type Window with
    #if FABLE_COMPILER
    [<Emit("$0.indexedDB")>]
    #else
    [<Inline("$this.indexedDB")>]
    #endif
    member this.indexedDB: IDBFactory = jsNative

#endif