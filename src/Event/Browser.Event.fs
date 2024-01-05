namespace rec Browser.Types

open System
#if FABLE_COMPILER
open Fable.Core
#elif JAVASCRIPT
open WebSharper
open WebSharper.JavaScript
#endif

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
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
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #elif JAVASCRIPT
    [<Inline "new Event($type, $eventInitDict)">]
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

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] EventTarget =
    abstract addEventListener: ``type``: string * listener: (Event->unit) -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * options: AddEventListenerOptions -> unit
    abstract dispatchEvent: evt: Event -> bool
    abstract removeEventListener: ``type``: string * listener: (Event->unit) -> unit
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * options: RemoveEventListenerOptions -> unit

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] EventTargetType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #elif JAVASCRIPT
    [<Inline("new EventTarget()")>]
    #endif
    abstract Create: unit -> EventTarget

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] CustomEvent =
    inherit Event
    abstract detail: obj

type [<AllowNullLiteral>] CustomEventInit =
    inherit EventInit
    abstract detail: obj with get, set

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] CustomEvent<'T> =
    inherit Event
    abstract detail: 'T option

type [<AllowNullLiteral>] CustomEventInit<'T> =
    inherit EventInit
    abstract detail: 'T option with get, set

type [<AllowNullLiteral>] CustomEventType =
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #elif JAVASCRIPT
    [<Inline "new CustomEvent($typeArg, $eventInitDict)">]
    #endif
    abstract Create : typeArg: string * ?eventInitDict: CustomEventInit -> CustomEvent
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #elif JAVASCRIPT
    [<Inline "new CustomEvent($typeArg, $eventInitDict)">]
    #endif
    abstract Create : typeArg: string * ?eventInitDict: CustomEventInit<'T> -> CustomEvent<'T>

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] ErrorEvent =
    inherit Event
    abstract colno: int
    abstract error: obj
    abstract filename: string
    abstract lineno: int
    abstract message: string

// MessageEvent is used by several packages (WebSockets, Dom)
#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] MessageEvent =
    inherit Event
    abstract data: obj
    abstract origin: string
    // TODO: Add it as extension in Channel Messaging API
    // abstract ports: MessagePort[]
    abstract source: obj

#if FABLE_COMPILER
[<StringEnum>]
#endif
type GamepadEventType =
    | [<CompiledName("gamepadconnected")>] GamepadConnected
    | [<CompiledName("gamepaddisconnected")>] GamepadDisconnected

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
//[<Stub>]
#endif
type [<AllowNullLiteral>] GamepadEvent =
    inherit Event
    #if FABLE_COMPILER
    [<Emit("new $0($1...)")>] 
    #elif JAVASCRIPT
    [<Inline "new GamepadEvent($typeArg, $options)">]
    #endif
    abstract Create: typeArg: GamepadEventType * ?options: Gamepad
    
    abstract gamepad: Gamepad

namespace Browser

#if FABLE_COMPILER
open Fable.Core
#elif JAVASCRIPT
open WebSharper
#endif
open Browser.Types



[<AutoOpen>]
module Event =


    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<Inline>]
    #endif
    let Event: EventType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif

    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<Inline>]
    #endif
    let EventTarget: EventTargetType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif

    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<Inline>]
    #endif
    let CustomEvent : CustomEventType = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<_>
        #endif
