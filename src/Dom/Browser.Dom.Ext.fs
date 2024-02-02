[<AutoOpen>]
module Browser.DomExtensions

open Fable.Core
open Browser.Types

type FormDataType with
    #if JAVASCRIPT
    [<WebSharper.Inline "new FormData($form)">]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    member __.Create(form: HTMLFormElement): FormData = jsNative