namespace Browser
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif
open Browser.Types

[<AutoOpen>]
module Css =
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSConditionRule: CSSConditionRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSFontFaceRule: CSSFontFaceRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSGroupingRule: CSSGroupingRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSImportRule: CSSImportRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSKeyframeRule: CSSKeyframeRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSKeyframesRule: CSSKeyframesRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSMediaRule: CSSMediaRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSNamespaceRule: CSSNamespaceRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSPageRule: CSSPageRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSRule: CSSRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSRuleList: CSSRuleListType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSStyleDeclaration: CSSStyleDeclarationType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSStyleRule: CSSStyleRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSStyleSheet: CSSStyleSheetType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let CSSSupportsRule: CSSSupportsRuleType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let StyleMedia: StyleMediaType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let StyleSheet: StyleSheetType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let StyleSheetList: StyleSheetListType = jsNative
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let StyleSheetPageList: StyleSheetPageListType = jsNative

#endif