[<AutoOpen>]
module Browser.MediaQueryListExtensions

open Fable.Core
open Browser.Types

type Document with
    #if JAVASCRIPT
    [<WebSharper.Inline("$this.matchMedia($mediaQuery)")>]
    #else
    [<Emit("$0.matchMedia($1...)")>]
    #endif
    member this.matchMedia(mediaQuery : string) : MediaQueryList = 
        #if JAVASCRIPT
        // TODO: move to jsNative proxy
        Unchecked.defaultof<_>
        #else
        jsNative
        #endif

type Window with
    #if JAVASCRIPT
    [<WebSharper.Inline("$this.matchMedia($mediaQuery)")>]
    #else
    [<Emit("$0.matchMedia($1...)")>]
    #endif
    member this.matchMedia(mediaQuery : string) : MediaQueryList = 
        #if JAVASCRIPT
        // TODO: move to jsNative proxy
        Unchecked.defaultof<_>
        #else
        jsNative
        #endif