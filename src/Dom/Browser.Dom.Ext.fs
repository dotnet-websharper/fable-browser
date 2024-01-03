[<AutoOpen>]
module Browser.DomExtensions
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
let [<Inline>] internal jsNative<'t> = Unchecked.defaultof<'t>
#endif 
open Browser.Types

type FormDataType with
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>]
    #else
    [<Inline "new FormData($form)">]
    #endif
    member __.Create(form: HTMLFormElement): FormData = jsNative
#endif