[<AutoOpen>]
module Browser.CssExtensions

open Fable.Core
open Browser.Types

type Window with
    #if JAVASCRIPT
    [<WebSharper.Inline("$this.getComputedStyle($elt,$pseudoElt)")>]
    #else
    [<Emit("$0.getComputedStyle($1...)")>]
    #endif
    member this.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative

type Element with 
    /// returns this DocumentOrShadow adopted stylesheets or sets them.
    /// https://wicg.github.io/construct-stylesheets/#using-constructed-stylesheets
    #if JAVASCRIPT
    
    member this.adoptedStyleSheets 
        with [<WebSharper.Inline("$this.adoptedStyleSheets")>] get(): CSSStyleSheet array = jsNative 
        and [<WebSharper.Inline("$this.adoptedStyleSheets=$v")>] set(v: CSSStyleSheet array) = jsNative
    #else
    [<Emit("$0.adoptedStyleSheets{{=$1}}")>]
    member this.adoptedStyleSheets with get(): CSSStyleSheet array = jsNative and set(v: CSSStyleSheet array) = jsNative
    #endif
    

type ShadowRoot with
    /// Returns a StyleSheetList of CSSStyleSheet objects for stylesheets explicitly linked into, or embedded in a shadow tree.
    #if JAVASCRIPT
    [<WebSharper.Inline("$this.styleSheets")>]
    #else
    [<Emit("$0.styleSheets")>]
    #endif
    member this.styleSheets: StyleSheetList = jsNative

type Document with
    /// returns this DocumentOrShadowRoot adopted stylesheets or sets them.
    /// https://wicg.github.io/construct-stylesheets/#using-constructed-stylesheets
    #if JAVASCRIPT
    
    member this.adoptedStyleSheets 
        with [<WebSharper.Inline("$this.adoptedStyleSheets")>] get(): CSSStyleSheet array = jsNative 
        and [<WebSharper.Inline("$this.adoptedStyleSheets=$v")>] set(v: CSSStyleSheet array) = jsNative
    #else
    [<Emit("$0.adoptedStyleSheets{{=$1}}")>]
    member this.adoptedStyleSheets with get(): CSSStyleSheet array = jsNative and set(v: CSSStyleSheet array) = jsNative
    #endif/// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
    #if JAVASCRIPT
    member this.styleSheets 
        with [<WebSharper.Inline "$this.styleSheets">] get(): StyleSheetList = jsNative 
        and [<WebSharper.Inline "$this.styleSheets=$v">] set(v: StyleSheetList) = jsNative
    #else
    [<Emit("$0.styleSheets{{=$1}}")>]
    member this.styleSheets with get(): StyleSheetList = jsNative and set(v: StyleSheetList) = jsNative
    #endif
    #if JAVASCRIPT
    member this.styleMedia 
        with [<WebSharper.Inline "$this.styleMedia">] get(): StyleMedia = jsNative 
        and [<WebSharper.Inline "$this.styleMedia=$v">] set(v: StyleMedia) = jsNative
    #else
    [<Emit("$0.styleMedia{{=$1}}")>]
    member this.styleMedia with get(): StyleMedia = jsNative and set(v: StyleMedia) = jsNative
    #endif
    #if JAVASCRIPT
    [<WebSharper.Inline("$this.getMatchedCSSRules($elt,$pseudoElt)")>]
    #else
    [<Emit("$0.getMatchedCSSRules($1...)")>]
    #endif
    member this.getMatchedCSSRules(elt: Element, ?pseudoElt: string): CSSRuleList = jsNative

type HTMLElement with
    #if JAVASCRIPT
    member this.style 
        with [<WebSharper.Inline "$this.style">] get(): CSSStyleDeclaration = jsNative 
        and [<WebSharper.Inline "$this.style=$v">] set(v: CSSStyleDeclaration) = jsNative
    #else
    [<Emit("$0.style{{=$1}}")>]
    member this.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative
    #endif

type HTMLLinkElement with
    #if JAVASCRIPT
    member this.sheet 
        with [<WebSharper.Inline "$this.sheet">] get(): StyleSheet = jsNative 
        and [<WebSharper.Inline "$this.sheet=$v">] set(v: StyleSheet) = jsNative
    #else
    [<Emit("$0.sheet{{=$1}}")>]
    member this.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative
    #endif

type HTMLStyleElement with
    #if JAVASCRIPT
    member this.sheet 
        with [<WebSharper.Inline "$this.sheet">] get(): StyleSheet = jsNative 
        and [<WebSharper.Inline "$this.sheet=$v">] set(v: StyleSheet) = jsNative
    #else
    [<Emit("$0.sheet{{=$1}}")>]
    member this.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative
    #endif

type SVGStylable with
    #if JAVASCRIPT
    member this.style 
        with [<WebSharper.Inline "$this.style">] get(): CSSStyleDeclaration = jsNative 
        and [<WebSharper.Inline "$this.style=$v">] set(v: CSSStyleDeclaration) = jsNative
    #else
    [<Emit("$0.style{{=$1}}")>]
    member this.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative
    #endif

type SVGSVGElement with
    #if JAVASCRIPT
    [<WebSharper.Inline("$this.getComputedStyle($elt,$pseudoElt)")>]
    #else
    [<Emit("$0.getComputedStyle($1...)")>]
    #endif
    member this.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative
