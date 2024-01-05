namespace rec Browser.Types
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif

open Browser.Types

#if FABLE_COMPILER
[<Global>]
#else
//[<Stub>]
#endif
type [<AllowNullLiteral>] MediaQueryList =
    inherit EventTarget
    abstract matches: bool with get, set
    abstract media: string with get, set
    abstract onchange: (Event -> unit) with get, set

type [<AllowNullLiteral>] MediaQueryListType =
    abstract prototype: MediaQueryList with get, set
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #else
    [<Inline("new MediaQueryList()")>]
    #endif
    abstract Create: unit -> MediaQueryList
#endif