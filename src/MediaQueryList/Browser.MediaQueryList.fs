namespace rec Browser.Types

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif

open Browser.Types

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] MediaQueryList =
    inherit EventTarget
    abstract matches: bool with get, set
    abstract media: string with get, set
    abstract onchange: (Event -> unit) with get, set

type [<AllowNullLiteral>] MediaQueryListType =
    abstract prototype: MediaQueryList with get, set
    #if JAVASCRIPT
    [<Inline("new MediaQueryList()")>]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create: unit -> MediaQueryList