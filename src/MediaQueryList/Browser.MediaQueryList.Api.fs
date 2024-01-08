namespace Browser


#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

module MediaQueryList =
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let MediaQueryList : MediaQueryListType = jsNative