namespace Browser

open Fable.Core
open Browser.Types

module MediaQueryList =
    let [<Global>] MediaQueryList : MediaQueryListType = 
        #if JAVASCRIPT
        // TODO: move to jsNative proxy
        Unchecked.defaultof<_>
        #else
        jsNative
        #endif