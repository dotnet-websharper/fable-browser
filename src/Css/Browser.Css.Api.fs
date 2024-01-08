namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

[<AutoOpen>]
module Css =
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSConditionRule: CSSConditionRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSFontFaceRule: CSSFontFaceRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSGroupingRule: CSSGroupingRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSImportRule: CSSImportRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSKeyframeRule: CSSKeyframeRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSKeyframesRule: CSSKeyframesRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSMediaRule: CSSMediaRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSNamespaceRule: CSSNamespaceRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSPageRule: CSSPageRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSRule: CSSRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSRuleList: CSSRuleListType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSStyleDeclaration: CSSStyleDeclarationType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSStyleRule: CSSStyleRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSStyleSheet: CSSStyleSheetType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CSSSupportsRule: CSSSupportsRuleType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let StyleMedia: StyleMediaType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let StyleSheet: StyleSheetType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let StyleSheetList: StyleSheetListType = jsNative
    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let StyleSheetPageList: StyleSheetPageListType = jsNative
