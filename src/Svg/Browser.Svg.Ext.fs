[<AutoOpen>]
module Browser.SvgExtensions
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
[<AutoOpen>]
module internal FableUtil =
    let [<Inline>] jsNative<'t> = Unchecked.defaultof<'t>
#endif
open Browser.Types

type Document with
    /// Gets the root svg element in the document hierarchy.
    #if FABLE_COMPILER
    [<Emit("$0.rootElement{{=$1}}")>]
    #else
    // TODO
    #endif
    member __.rootElement with get(): SVGSVGElement = jsNative and set(v: SVGSVGElement) = jsNative

#endif