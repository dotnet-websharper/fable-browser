namespace rec Browser.Types
    
open WebSharper
open WebSharper.JavaScript
open WebSharper.JavaScript.Interop
type GlobalAttributeProxy = InlineAttribute

[<AutoOpen;WebSharper.InternalProxy("Fable.Core.Util, Fable.Core")>]
module internal UtilProxy =
    let [<Inline>] jsNative<'T> = Unchecked.defaultof<'T>

// // [<Stub>]
// type GamepadEventType = 
// | [<Constant("gamepadconnected")>] GamepadConnected
// | [<Constant("gamepaddisconnected")>] GamepadDisconnected

// [<Stub>]
// type GamepadEvent =
//     inherit Browser.Types.Event
//     [<Inline("new GamepadEvent($typeArg, $options)")>] abstract Create: typeArg: Browser.Types.GamepadEventType * ?options: Browser.Types.Gamepad
//     [<Inline>] abstract gamepad: Browser.Types.Gamepad with get

// [<Stub>]
// type AddEventListenerOptions =
//     [<Inline>] abstract capture: bool with get, set
//     [<Inline>] abstract once: bool with get, set
//     [<Inline>] abstract passive: bool with get, set


// [<Stub>]
// type RemoveEventListenerOptions =
//     [<Inline>] abstract capture: bool with get, set


// [<Stub>]
// type EventTarget =
//     abstract addEventListener: ``type``: string * listener: (Event->unit) -> unit
//     abstract addEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
//     abstract addEventListener: ``type``: string * listener: (Event->unit) * options: Browser.Types.AddEventListenerOptions -> unit
//     abstract dispatchEvent: evt: Event -> bool
//     abstract removeEventListener: ``type``: string * listener: (Event->unit) -> unit
//     abstract removeEventListener: ``type``: string * listener: (Event->unit) * useCapture: bool -> unit
//     abstract removeEventListener: ``type``: string * listener: (Event->unit) * options: Browser.Types.RemoveEventListenerOptions -> unit

// [<Stub>]
// type Event =
//     abstract bubbles: bool with get, set
//     abstract cancelBubble: bool with get, set
//     abstract cancelable: bool with get, set
//     abstract currentTarget: EventTarget with get, set
//     abstract defaultPrevented: bool with get, set
//     abstract eventPhase: float with get, set
//     abstract isTrusted: bool with get, set
//     abstract returnValue: bool with get, set
//     abstract target: EventTarget with get, set
//     abstract timeStamp: float with get, set
//     abstract ``type``: string with get, set
//     abstract AT_TARGET: float with get, set
//     abstract BUBBLING_PHASE: float with get, set
//     abstract CAPTURING_PHASE: float with get, set
//     abstract initEvent: eventTypeArg: string * canBubbleArg: bool * cancelableArg: bool -> unit
//     abstract preventDefault: unit -> unit
//     abstract stopImmediatePropagation: unit -> unit
//     abstract stopPropagation: unit -> unit

// [<Stub>]
// type EventInit =
//     abstract bubbles: bool with get, set
//     abstract cancelable: bool with get, set
//     abstract composed: bool with get, set

// type EventType =
//     [<Inline("new Event($type,$eventInitDict)")>] member this.Create(``type``: string, ?eventInitDict: EventInit): Event = jsNative
//     [<Inline("Event.AT_TARGET")>] member this.AT_TARGET  with get () : float = jsNative
//     [<Inline("Event.BUBBLING_PHASE")>] member this.BUBBLING_PHASE with get () : float = jsNative
//     [<Inline("Event.CAPTURING_PHASE")>] member this.CAPTURING_PHASE with get () : float = jsNative
    
// [<Stub>]
// type CustomEvent =
//     inherit Event
//     [<Inline>] abstract detail: obj

// [<Stub>]
// type CustomEvent<'T> =
//     inherit Event
//     [<Inline>] abstract detail: 'T option

// [<Stub>]
// type ErrorEvent =
//     inherit Event
//     abstract colno: int
//     abstract error: obj
//     abstract filename: string
//     abstract lineno: int
//     abstract message: string

// [<Stub>]
// type MessageEvent =
//     [<Inline>] abstract data: obj
//     [<Inline>] abstract origin: string
//     [<Inline>] abstract source: obj

// [<AutoOpen>]
// module Event =
//     let [<Inline>] Event: EventType = jsNative
//     let [<Inline>] EventTarget: EventTargetType = jsNative
//     let [<Inline>] CustomEvent : CustomEventType = jsNative
