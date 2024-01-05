namespace Browser.Types
#if FABLE_COMPILER || JAVASCRIPT
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif

type ResizeObserverSize =
    abstract inlineSize: float
    abstract blockSize: float

type ResizeObserverEntry =
    /// An array containing the new border box sizes of the observed element when the callback is run
    abstract borderBoxSize: ResizeObserverSize array

    /// An array containing the new content box sizes of the observed element when the callback is run
    abstract contentBoxSize: ResizeObserverSize array

    /// An array containing the new content box sizes in device pixels of the observed element when the callback is run
    abstract devicePixelContentBoxSize: ResizeObserverSize array

    /// The new size of the observed element when the callback is run
    abstract contentRect: ClientRect

    /// A reference to the Element or SVGElement being observed
    abstract target: Node

#if FABLE_COMPILER
[<StringEnum(CaseRules.KebabCase ||| CaseRules.LowerFirst)>]
type ResizeObserverBox =
    /// Size of the content area as defined in CSS
    | ContentBox

    /// Size of the box border area as defined in CSS
    | BorderBox

    /// The size of the content area as defined in CSS, in device pixels, before applying any CSS transforms on the element or its ancestors
    | DevicePixelContentBox
#else // TODO: testing
type ResizeObserverBox =
    | [<Constant "content-box">] ContentBox
    | [<Constant "border-box">] BorderBox
    | [<Constant "device-pixel-content-box">] DevicePixelContentBox
#endif

type ResizeObserverOptions =
    /// Sets which box model the observer will observe changes to
    abstract box: ResizeObserverBox with get, set


#if FABLE_COMPILER
[<Global>]
#else
//[<Stub>]
#endif
type [<AllowNullLiteral>] ResizeObserverType =
    /// Unobserve all observed Element or SVGElement targets
    abstract disconnect: unit -> unit

    /// Starts observing the specified Element or SVGElement
    abstract observe: Node -> unit

    /// Starts observing the specified Element or SVGElement with the specified options
    abstract observe: Node * ResizeObserverOptions -> unit

    /// Ends the observing of a specified Element or SVGElement
    abstract unobserve: Node -> unit

type ResizeObserverCallback = ResizeObserverEntry array -> ResizeObserverType -> unit

#if FABLE_COMPILER
[<Global>]
#else
//[<Stub>]
#endif
type ResizeObserverCtor =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #else
    [<Inline("new ResizeObserverType($callback)")>]
    #endif
    abstract Create: callback: ResizeObserverCallback -> ResizeObserverType

namespace Browser
#if FABLE_COMPILER
open Fable.Core
#else
open WebSharper
#endif

open Browser.Types

[<AutoOpen>]
module ResizeObserver =
    #if FABLE_COMPILER
    [<Global>]
    #else
    [<Inline>]
    #endif
    let ResizeObserver: ResizeObserverCtor = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif
#endif