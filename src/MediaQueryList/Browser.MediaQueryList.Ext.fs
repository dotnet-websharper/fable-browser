[<AutoOpen>]
module Browser.MediaQueryListExtensions

open Fable.Core
open Browser.Types

type Document with
    [<Emit("$0.matchMedia($1...)")>]
    member this.matchMedia(mediaQuery : string) : MediaQueryList = 
        jsNative

type Window with
    [<Emit("$0.matchMedia($1...)")>]
    member this.matchMedia(mediaQuery : string) : MediaQueryList = 
        jsNative