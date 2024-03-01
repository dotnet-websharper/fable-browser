
[<AutoOpen>]
module Browser.IndexedDBExtensions

open Fable.Core
open Browser.Types

type Window with
    [<Emit("$0.indexedDB")>]
    member this.indexedDB: IDBFactory = jsNative
