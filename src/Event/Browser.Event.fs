namespace rec Browser.Types

open System
#if JAVASCRIPT
open WebSharper
open WebSharper.JavaScript
#else
open Fable.Core
#endif

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] Event =
    abstract bubbles: bool with get, set
    abstract cancelBubble: bool with get, set
    abstract cancelable: bool with get, set
    abstract currentTarget: EventTarget with get, set
    abstract defaultPrevented: bool with get, set
    abstract eventPhase: float with get, set
    abstract isTrusted: bool with get, set
    abstract returnValue: bool with get, set
    abstract target: EventTarget with get, set
    abstract timeStamp: float with get, set
    abstract ``type``: string with get, set
    abstract AT_TARGET: float with get, set
    abstract BUBBLING_PHASE: float with get, set
    abstract CAPTURING_PHASE: float with get, set
    abstract initEvent: eventTypeArg: string * canBubbleArg: bool * cancelableArg: bool -> unit
    abstract preventDefault: unit -> unit
    abstract stopImmediatePropagation: unit -> unit
    abstract stopPropagation: unit -> unit

type [<AllowNullLiteral>] EventInit =
    abstract bubbles: bool with get, set
    abstract cancelable: bool with get, set
    abstract composed: bool with get, set

type [<AllowNullLiteral>] EventType =
    #if JAVASCRIPT
    [<Inline "new Event($type, $eventInitDict)">]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create: ``type``: string * ?eventInitDict: EventInit -> Event
    abstract AT_TARGET: float with get, set
    abstract BUBBLING_PHASE: float with get, set
    abstract CAPTURING_PHASE: float with get, set

type [<AllowNullLiteral>] AddEventListenerOptions =
    abstract capture: bool with get, set
    abstract once: bool with get, set
    abstract passive: bool with get, set

type [<AllowNullLiteral>] RemoveEventListenerOptions =
    abstract capture: bool with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] EventTarget =
    abstract addEventListener: ``type``: string * listener: (Event->unit) -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * options: AddEventListenerOptions -> unit
    abstract dispatchEvent: evt: Event -> bool
    abstract removeEventListener: ``type``: string * listener: (Event->unit) -> unit
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * options: RemoveEventListenerOptions -> unit

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] EventTargetType =
    #if JAVASCRIPT
    [<Inline("new EventTarget()")>]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create: unit -> EventTarget

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] CustomEvent =
    inherit Event
    abstract detail: obj

type [<AllowNullLiteral>] CustomEventInit =
    inherit EventInit
    abstract detail: obj with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] CustomEvent<'T> =
    inherit Event
    abstract detail: 'T option

type [<AllowNullLiteral>] CustomEventInit<'T> =
    inherit EventInit
    abstract detail: 'T option with get, set

type [<AllowNullLiteral>] CustomEventType =
    #if JAVASCRIPT
    [<Inline "new CustomEvent($typeArg, $eventInitDict)">]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create : typeArg: string * ?eventInitDict: CustomEventInit -> CustomEvent
    #if JAVASCRIPT
    [<Inline "new CustomEvent($typeArg, $eventInitDict)">]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create : typeArg: string * ?eventInitDict: CustomEventInit<'T> -> CustomEvent<'T>

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] ErrorEvent =
    inherit Event
    abstract colno: int
    abstract error: obj
    abstract filename: string
    abstract lineno: int
    abstract message: string

// MessageEvent is used by several packages (WebSockets, Dom)
#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] MessageEvent =
    inherit Event
    abstract data: obj
    abstract origin: string
    // TODO: Add it as extension in Channel Messaging API
    // abstract ports: MessagePort[]
    abstract source: obj

#if !JAVASCRIPT
[<StringEnum>]
#endif
type GamepadEventType =
    | [<CompiledName("gamepadconnected")>] GamepadConnected
    | [<CompiledName("gamepaddisconnected")>] GamepadDisconnected

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] GamepadEvent =
    inherit Event
    #if JAVASCRIPT
    [<Inline "new GamepadEvent($typeArg, $options)">]
    #else
    [<Emit("new $0($1...)")>] 
    #endif
    abstract Create: typeArg: GamepadEventType * ?options: Gamepad
    
    abstract gamepad: Gamepad

namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types



[<AutoOpen>]
module Event =


    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let Event: EventType = jsNative

    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let EventTarget: EventTargetType = jsNative

    #if JAVASCRIPT
    [<Inline>]
    #else
    [<Global>]
    #endif
    let CustomEvent : CustomEventType = jsNative
