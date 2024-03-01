[<AutoOpen>]
module Browser.CssExtensions

open Fable.Core
open Browser.Types

type Window with
    [<Emit("$0.getComputedStyle($1...)")>]
    member this.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative

type Element with 
    /// returns this DocumentOrShadow adopted stylesheets or sets them.
    /// https://wicg.github.io/construct-stylesheets/#using-constructed-stylesheets
    [<Emit("$0.adoptedStyleSheets{{=$1}}")>]
    member this.adoptedStyleSheets with get(): CSSStyleSheet array = jsNative and set(v: CSSStyleSheet array) = jsNative
    

type ShadowRoot with
    /// Returns a StyleSheetList of CSSStyleSheet objects for stylesheets explicitly linked into, or embedded in a shadow tree.
    [<Emit("$0.styleSheets")>]
    member this.styleSheets: StyleSheetList = jsNative

type Document with
    /// returns this DocumentOrShadowRoot adopted stylesheets or sets them.
    /// https://wicg.github.io/construct-stylesheets/#using-constructed-stylesheets
    [<Emit("$0.adoptedStyleSheets{{=$1}}")>]
    member this.adoptedStyleSheets with get(): CSSStyleSheet array = jsNative and set(v: CSSStyleSheet array) = jsNative
    
    [<Emit("$0.styleSheets{{=$1}}")>]
    member this.styleSheets with get(): StyleSheetList = jsNative and set(v: StyleSheetList) = jsNative
    
    [<Emit("$0.styleMedia{{=$1}}")>]
    member this.styleMedia with get(): StyleMedia = jsNative and set(v: StyleMedia) = jsNative
    
    [<Emit("$0.getMatchedCSSRules($1...)")>]
    member this.getMatchedCSSRules(elt: Element, ?pseudoElt: string): CSSRuleList = jsNative

type HTMLElement with
    [<Emit("$0.style{{=$1}}")>]
    member this.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type HTMLLinkElement with
    [<Emit("$0.sheet{{=$1}}")>]
    member this.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type HTMLStyleElement with
    [<Emit("$0.sheet{{=$1}}")>]
    member this.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type SVGStylable with
    [<Emit("$0.style{{=$1}}")>]
    member this.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type SVGSVGElement with
    [<Emit("$0.getComputedStyle($1...)")>]
    member this.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative
