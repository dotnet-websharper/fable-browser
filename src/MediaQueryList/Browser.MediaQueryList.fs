namespace rec Browser.Types

open Fable.Core

open Browser.Types

type [<Global;AllowNullLiteral>] MediaQueryList =
    inherit EventTarget
    abstract matches: bool with get, set
    abstract media: string with get, set
    abstract onchange: (Event -> unit) with get, set

type [<AllowNullLiteral>] MediaQueryListType =
    abstract prototype: MediaQueryList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new MediaQueryList()")>]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create: unit -> MediaQueryList