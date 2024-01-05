namespace Browser

#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types

module MediaQueryList =
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let MediaQueryList : MediaQueryListType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif
#endif