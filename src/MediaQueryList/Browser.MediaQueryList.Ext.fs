[<AutoOpen>]
module Browser.MediaQueryListExtensions


#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

type Document with
    #if JAVASCRIPT
    [<Inline("$this.matchMedia($mediaQuery)")>]
    #else
    [<Emit("$0.matchMedia($1...)")>]
    #endif
    member this.matchMedia(mediaQuery : string) : MediaQueryList = 
        #if JAVASCRIPT
        Unchecked.defaultof<_>
        #else
        jsNative
        #endif

type Window with
    #if JAVASCRIPT
    [<Inline("$this.matchMedia($mediaQuery)")>]
    #else
    [<Emit("$0.matchMedia($1...)")>]
    #endif
    member this.matchMedia(mediaQuery : string) : MediaQueryList = 
        #if JAVASCRIPT
        Unchecked.defaultof<_>
        #else
        jsNative
        #endif