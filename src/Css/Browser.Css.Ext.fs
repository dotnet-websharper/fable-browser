[<AutoOpen>]
module Browser.CssExtensions
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper

[<AutoOpen>]
module FableUtil =
    let [<Inline>] jsNative<'t> = Unchecked.defaultof<'t>
#endif
open Browser.Types

type Window with
    #if FABLE_COMPILER
    [<Emit("$0.getComputedStyle($1...)")>]
    #else
    [<Inline("$this.getComputedStyle($elt,$pseudoElt)")>]
    #endif
    member this.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative

type Element with 
    /// returns this DocumentOrShadow adopted stylesheets or sets them.
    /// https://wicg.github.io/construct-stylesheets/#using-constructed-stylesheets
    #if FABLE_COMPILER
    [<Emit("$0.adoptedStyleSheets{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.adoptedStyleSheets with get(): CSSStyleSheet array = jsNative and set(v: CSSStyleSheet array) = jsNative

type ShadowRoot with
    /// Returns a StyleSheetList of CSSStyleSheet objects for stylesheets explicitly linked into, or embedded in a shadow tree.
    #if FABLE_COMPILER
    [<Emit("$0.styleSheets")>]
    #else
    [<Inline("$this.styleSheets")>]
    #endif
    member this.styleSheets: StyleSheetList = jsNative

type Document with
    /// returns this DocumentOrShadowRoot adopted stylesheets or sets them.
    /// https://wicg.github.io/construct-stylesheets/#using-constructed-stylesheets
    #if FABLE_COMPILER
    [<Emit("$0.adoptedStyleSheets{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.adoptedStyleSheets with get(): CSSStyleSheet array = jsNative and set(v: CSSStyleSheet array) = jsNative
    /// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
    #if FABLE_COMPILER
    [<Emit("$0.styleSheets{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.styleSheets with get(): StyleSheetList = jsNative and set(v: StyleSheetList) = jsNative
    #if FABLE_COMPILER
    [<Emit("$0.styleMedia{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.styleMedia with get(): StyleMedia = jsNative and set(v: StyleMedia) = jsNative
    #if FABLE_COMPILER
    [<Emit("$0.getMatchedCSSRules($1...)")>]
    #else
    [<Inline("$this.getMatchedCSSRules($elt,$pseudoElt)")>]
    #endif
    member this.getMatchedCSSRules(elt: Element, ?pseudoElt: string): CSSRuleList = jsNative

type HTMLElement with
    #if FABLE_COMPILER
    [<Emit("$0.style{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type HTMLLinkElement with
    #if FABLE_COMPILER
    [<Emit("$0.sheet{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type HTMLStyleElement with
    #if FABLE_COMPILER
    [<Emit("$0.sheet{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type SVGStylable with
    #if FABLE_COMPILER
    [<Emit("$0.style{{=$1}}")>]
    #else
    [<Inline("")>] // TODO
    #endif
    member this.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type SVGSVGElement with
    #if FABLE_COMPILER
    [<Emit("$0.getComputedStyle($1...)")>]
    #else
    [<Inline("$this.getComputedStyle($elt,$pseudoElt)")>]
    #endif
    member this.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative

#endif