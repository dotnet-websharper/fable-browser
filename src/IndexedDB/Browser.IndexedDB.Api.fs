namespace Browser
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types

[<AutoOpen>]
module IndexedDB =
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let indexedDB: IDBFactory = jsNative

#endif