[<AutoOpen>]
module Browser.SvgExtensions

open Fable.Core
open Browser.Types

type Document with
    /// Gets the root svg element in the document hierarchy.
    #if JAVASCRIPT
    member this.rootElement 
        with [<WebSharper.Inline "$this.rootElement">] get(): SVGSVGElement = jsNative 
        and [<WebSharper.Inline "$this.rootElement = $v">] set(v: SVGSVGElement) = jsNative
    #else
    [<Emit("$0.rootElement{{=$1}}")>]
    member __.rootElement with get(): SVGSVGElement = jsNative and set(v: SVGSVGElement) = jsNative
    #endif
