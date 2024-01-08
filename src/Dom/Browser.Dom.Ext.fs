[<AutoOpen>]
module Browser.DomExtensions
#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif 
open Browser.Types

type FormDataType with
    #if JAVASCRIPT
    [<Inline "new FormData($form)">]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    member __.Create(form: HTMLFormElement): FormData = jsNative