namespace rec Browser.Types

open System

type [<AllowNullLiteral;WebSharper.Stub>] Event =
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

type [<AllowNullLiteral;WebSharper.Stub>] EventInit =
    abstract bubbles: bool with get, set
    abstract cancelable: bool with get, set
    abstract composed: bool with get, set

type [<AllowNullLiteral;WebSharper.Stub>] EventType =
    [<WebSharper.Inline("new EventType($typ, $eventInitDict)")>] member this.Create(typ: string, ?eventInitDict: EventInit): Event = jsNative
    member this.AT_TARGET: float = 2
    member this.BUBBLING_PHASE: float = 3
    member this.CAPTURING_PHASE: float = 1

type [<AllowNullLiteral;WebSharper.Stub>] AddEventListenerOptions =
    abstract capture: bool with get, set
    abstract once: bool with get, set
    abstract passive: bool with get, set

type [<AllowNullLiteral;WebSharper.Stub>] RemoveEventListenerOptions =
    abstract capture: bool with get, set

type [<AllowNullLiteral;WebSharper.Stub>] EventTarget =
    abstract addEventListener: ``type``: string * listener: (Event->unit) -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * options: AddEventListenerOptions -> unit
    abstract dispatchEvent: evt: Event -> bool
    abstract removeEventListener: ``type``: string * listener: (Event->unit) -> unit
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * options: RemoveEventListenerOptions -> unit

type [<AllowNullLiteral;WebSharper.Stub>] EventTargetType =
    [<WebSharper.Inline("new EventTarget()")>] member this.Create (): EventTarget = jsNative

type [<AllowNullLiteral;WebSharper.Stub>] CustomEvent =
    inherit Event
    abstract detail: obj

type [<AllowNullLiteral;WebSharper.Stub>] CustomEventInit =
    inherit EventInit
    abstract detail: obj with get, set

type [<AllowNullLiteral;WebSharper.Stub>] CustomEvent<'T> =
    inherit Event
    abstract detail: 'T option

type [<AllowNullLiteral;WebSharper.Stub>] CustomEventInit<'T> =
    inherit EventInit
    abstract detail: 'T option with get, set

type [<AllowNullLiteral;WebSharper.Stub>] CustomEventType =
    [<WebSharper.Inline("new CustomEventType($typeArg, $eventInitDict)")>] member this.Create(typeArg: string, ?eventInitDict: CustomEventInit): CustomEvent = jsNative
    [<WebSharper.Inline("new CustomEventType($typeArg, $eventInitDict)")>] member this.Create(typeArg: string, ?eventInitDict: CustomEventInit<'T>): CustomEvent<'T> = jsNative

type [<AllowNullLiteral;WebSharper.Stub>] ErrorEvent =
    inherit Event
    abstract colno: int
    abstract error: obj
    abstract filename: string
    abstract lineno: int
    abstract message: string

// MessageEvent is used by several packages (WebSockets, Dom)
type [<AllowNullLiteral;WebSharper.Stub>] MessageEvent =
    inherit Event
    abstract data: obj
    abstract origin: string
    // TODO: Add it as extension in Channel Messaging API
    // abstract ports: MessagePort[]
    abstract source: obj

type GamepadEventType =
    | [<WebSharper.Constant("gamepadconnected")>] GamepadConnected
    | [<WebSharper.Constant("gamepaddisconnected")>] GamepadDisconnected

type [<AllowNullLiteral;WebSharper.Stub>] GamepadEvent =
    inherit Event
    [<WebSharper.Inline("new GamepadEvent($typeArg, $options)")>] abstract Create: typeArg: GamepadEventType * ?options: Gamepad
    abstract gamepad: Gamepad

namespace Browser

open Browser.Types

[<AutoOpen>]
module Event =
    let [<WebSharper.Inline>] Event: EventType = jsNative
    let [<WebSharper.Inline>] EventTarget: EventTargetType = jsNative
    let [<WebSharper.Inline>] CustomEvent : CustomEventType = jsNative
