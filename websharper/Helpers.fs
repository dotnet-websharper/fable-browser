[<AutoOpen>]
module Helpers
    open WebSharper
    open WebSharper.JavaScript

    let [<Inline "null">] jsNative<'t> = X<'t>