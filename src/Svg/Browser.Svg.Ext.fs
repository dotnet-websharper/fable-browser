[<AutoOpen>]
module Browser.SvgExtensions

#if JAVASCRIPT
open WebSharper
[<AutoOpen>]
module internal FableUtil =
    let [<Inline>] jsNative<'t> = Unchecked.defaultof<'t>
#else
open Fable.Core
#endif
open Browser.Types

type Document with
    /// Gets the root svg element in the document hierarchy.
    #if JAVASCRIPT
   // TODO
    #else
    [<Emit("$0.rootElement{{=$1}}")>]
    #endif
    member __.rootElement with get(): SVGSVGElement = jsNative and set(v: SVGSVGElement) = jsNative
