[<AutoOpen>]
module Browser.MediaQueryListExtensions

#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types

type Document with
    #if FABLE_COMPILER
    [<Emit("$0.matchMedia($1...)")>]
    #else
    [<Inline("new $this.matchMedia($mediaQuery)")>]
    #endif
    member __.matchMedia(mediaQuery : string) : MediaQueryList = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif

type Window with
    #if FABLE_COMPILER
    [<Emit("$0.matchMedia($1...)")>]
    #else
    [<Inline("new $this.matchMedia($mediaQuery)")>]
    #endif
    member __.matchMedia(mediaQuery : string) : MediaQueryList = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif
#endif