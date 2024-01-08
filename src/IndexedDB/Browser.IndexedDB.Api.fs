namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

[<AutoOpen>]
module IndexedDB =
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let indexedDB: IDBFactory = jsNative
