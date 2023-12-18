module private rec Proxies
    open WebSharper
    open WebSharper.JavaScript
    open WebSharper.JavaScript.Interop
    type GlobalAttributeProxy = InlineAttribute

    module private UtilProxy =
        let [<Inline>] jsNative<'T> = Unchecked.defaultof<'T>

    [<Proxy(typeof<Browser.Types.GamepadEventType>)>]
    type GamepadEventTypeProxy = 
    | [<Constant("gamepadconnected")>] GamepadConnected
    | [<Constant("gamepaddisconnected")>] GamepadDisconnected

    [<Proxy(typeof<Browser.Types.GamepadEvent>)>]
    type GamepadEventProxy =
        inherit Browser.Types.Event
        [<Inline("new GamepadEvent($typeArg, $options)")>] abstract Create: typeArg: Browser.Types.GamepadEventType * ?options: Browser.Types.Gamepad
        [<Inline>] abstract gamepad: Browser.Types.Gamepad with get
    
    [<Proxy(typeof<Browser.Types.AddEventListenerOptions>)>]
    type AddEventListenerOptionsProxy =
        [<Inline>] abstract capture: bool with get, set
        default this.capture
            with [<Inline>] get () = (this |> As<Dom.AddEventListenerOptions>).Capture
            and [<Inline>] set (v) = (this |> As<Dom.AddEventListenerOptions>).Capture <- v
        [<Inline>] abstract once: bool with get, set
        default this.once
            with [<Inline>] get () = (this |> As<Dom.AddEventListenerOptions>).Once
            and [<Inline>] set (v) = (this |> As<Dom.AddEventListenerOptions>).Once <- v
        [<Inline>] abstract passive: bool with get, set
        default this.passive
            with [<Inline>] get () = (this |> As<Dom.AddEventListenerOptions>).Passive
            and [<Inline>] set (v) = (this |> As<Dom.AddEventListenerOptions>).Passive <- v
    

    [<Proxy(typeof<Browser.Types.RemoveEventListenerOptions>)>]
    type internal RemoveEventListenerOptionsProxy =
        [<Inline>] abstract capture: bool with get, set
        default this.capture
            with [<Inline>] get () = (this |> As<Dom.EventListenerOptions>).Capture
            and [<Inline>] set (v) = (this |> As<Dom.EventListenerOptions>).Capture <- v


    [<Proxy(typeof<Browser.Types.EventTarget>)>]
    type EventTargetProxy =
        [<Inline>] 
        member this.addEventListener(``type``: string, listener: Browser.Types.Event -> unit, options: Browser.Types.AddEventListenerOptions): unit = 
                    (this |> As<Dom.EventTarget>).AddEventListener(``type``,new System.Action<Dom.Event>(fun l -> listener(l |> As)),options |> As<Dom.AddEventListenerOptions>)
        [<Inline>] 
        member this.addEventListener(``type``: string, listener: Browser.Types.Event -> unit, useCapture: bool): unit = 
                    (this |> As<Dom.EventTarget>).AddEventListener(``type``,new System.Action<Dom.Event>(fun l -> listener(l |> As)),useCapture)
        [<Inline>] 
        member this.addEventListener(``type``: string, listener: Browser.Types.Event -> unit): unit = 
                    (this |> As<Dom.EventTarget>).AddEventListener(``type``,new System.Action<Dom.Event>(fun l -> listener(l |> As)))
        [<Inline>] 
        member this.dispatchEvent(evt: EventProxy): bool = 
                    (this |> As<Dom.EventTarget>).DispatchEvent(evt |> As)
        [<Inline>] 
        member this.removeEventListener(``type``: string, listener: Browser.Types.Event -> unit, options: Browser.Types.RemoveEventListenerOptions): unit = 
                    (this |> As<Dom.EventTarget>).RemoveEventListener(``type``,new System.Action<Dom.Event>(fun l -> listener(l |> As)),options |> As<Dom.EventListenerOptions>)
        [<Inline>] 
        member this.removeEventListener(``type``: string, listener: Browser.Types.Event -> unit, useCapture: bool): unit = 
                    (this |> As<Dom.EventTarget>).RemoveEventListener(``type``,new System.Action<Dom.Event>(fun l -> listener(l |> As)),useCapture)
        [<Inline>] 
        member this.removeEventListener(``type``: string, listener: Browser.Types.Event -> unit): unit = 
                    (this |> As<Dom.EventTarget>).RemoveEventListener(``type``, new System.Action<Dom.Event>(fun l -> listener(l |> As)))

    [<Proxy(typeof<Browser.Types.Event>);AbstractClass>]
    type EventProxy =

        member this.AT_TARGET
            with [<Inline>] get (): float = 
                2
            and [<Inline>] set (v: float): unit = 
                ()
        member this.BUBBLING_PHASE
            with [<Inline>] get (): float = 
                3
            and [<Inline>] set (v: float): unit = 
                ()
        member this.CAPTURING_PHASE
            with [<Inline>] get (): float = 
                1
            and [<Inline>] set (v: float): unit = 
                ()
        member this.``type``
            with [<Inline>] get (): string = 
                (this |> As<Dom.Event>).Type
            and [<Inline>] set (v: string): unit = 
                ()
        member this.bubbles
            with [<Inline>] get (): bool = 
                (this |> As<Dom.Event>).Bubbles
            and [<Inline>] set (v: bool): unit = 
                ()
        member this.cancelBubble
            with [<Inline>] get (): bool = 
                this?cancelBubble
            and [<Inline>] set (v: bool): unit = 
                this?cancelBubble <- v
        member this.cancelable
            with [<Inline>] get (): bool = 
                (this |> As<Dom.Event>).Cancelable
            and [<Inline>] set (v: bool): unit = 
                ()
        member this.currentTarget
            with [<Inline>] get (): Browser.Types.EventTarget = 
                (this |> As<Dom.Event>).CurrentTarget |> As
            and [<Inline>] set (v: Browser.Types.EventTarget): unit = 
                ()
        member this.defaultPrevented
            with [<Inline>] get (): bool = 
                (this |> As<Dom.Event>).DefaultPrevented
            and [<Inline>] set (v: bool): unit = 
                ()
        member this.eventPhase
            with [<Inline>] get (): float = 
                (this |> As<Dom.Event>).EventPhase |> As
            and [<Inline>] set (v: float): unit = 
                ()
        [<Inline>] 
        member this.initEvent(eventTypeArg: string, canBubbleArg: bool, cancelableArg: bool): unit = 
            let evt : System.Action<string,bool,bool> = (this?initEvent)
            evt.Invoke(eventTypeArg, canBubbleArg,cancelableArg)
        member this.isTrusted
            with [<Inline>] get (): bool = 
                (this |> As<Dom.Event>).IsTrusted
            and [<Inline>] set (v: bool): unit = 
                ()
        [<Inline>] 
        member this.preventDefault(): unit = 
            (this |> As<Dom.Event>).PreventDefault()
        member this.returnValue
            with [<Inline>] get (): bool = 
                this?returnValue
            and [<Inline>] set (v: bool): unit = 
                this?returnValue <- v
        [<Inline>] 
        member this.stopImmediatePropagation(): unit = 
            (this |> As<Dom.Event>).StopImmediatePropagation()
        [<Inline>] 
        member this.stopPropagation(): unit = 
            (this |> As<Dom.Event>).StopPropagation()
        member this.target
            with [<Inline>] get (): EventTargetProxy = 
                (this |> As<Dom.Event>).Target |> As
            and [<Inline>] set (v: EventTargetProxy): unit = 
                ()
        member this.timeStamp
            with [<Inline>] get (): float = 
                (this |> As<Dom.Event>).TimeStamp |> As
            and [<Inline>] set (v: float): unit = 
                ()
    
    [<Proxy(typeof<Browser.Types.EventInit>)>]
    type EventInitProxy =
        [<Inline>] abstract bubbles: bool with get, set
        default this.bubbles
            with [<Inline>] get () = (this |> As<Dom.EventInit>).Bubbles
            and [<Inline>] set (v) = (this |> As<Dom.EventInit>).Bubbles <- v
        
        [<Inline>] abstract cancelable: bool with get, set
        default this.cancelable
            with [<Inline>] get () = (this |> As<Dom.EventInit>).Cancelable
            and [<Inline>] set (v) = (this |> As<Dom.EventInit>).Cancelable <- v
        
        [<Inline>] abstract composed: bool with get, set
        default this.composed
            with [<Inline>] get () = (this |> As<Dom.EventInit>).Composed
            and [<Inline>] set (v) = (this |> As<Dom.EventInit>).Composed <- v

    [<Proxy(typeof<Browser.Types.EventType>)>]
    type EventTypeProxy =
        [<Inline("new Event($type,$eventInitDict)")>] abstract Create: ``type``: string * ?eventInitDict: Browser.Types.EventInit -> Browser.Types.Event
        [<Inline>] abstract AT_TARGET: float with get, set
        [<Inline>] abstract BUBBLING_PHASE: float with get, set
        [<Inline>] abstract CAPTURING_PHASE: float with get, set
    [<Proxy(typeof<Browser.Types.CustomEvent>);AbstractClass>]
    type CustomEventProxy =
        inherit EventProxy
        [<Inline>] abstract detail: obj

    [<Proxy(typeof<Browser.Types.CustomEvent<_>>);AbstractClass>]
    type CustomEventProxy<'T> =
        inherit EventProxy
        [<Inline>] abstract detail: 'T option
    
    [<Proxy(typeof<Browser.Types.ErrorEvent>);AbstractClass>]
    type ErrorEventProxy =
        inherit EventProxy
        [<Inline>] 
        member this.colno = (this |> As<JavaScript.ErrorEvent>).Colno
        [<Inline>] 
        member this.error : obj = (this |> As<JavaScript.ErrorEvent>).Error
        [<Inline>] 
        member this.filename = (this |> As<JavaScript.ErrorEvent>).Filename
        [<Inline>] 
        member this.lineno = (this |> As<JavaScript.ErrorEvent>).Lineno
        [<Inline>] 
        member this.message = (this |> As<JavaScript.ErrorEvent>).Message

    [<Proxy(typeof<Browser.Types.MessageEvent>);AbstractClass>]
    type MessageEventProxy =
        [<Inline>] abstract data: obj
        [<Inline>] abstract origin: string
        [<Inline>] abstract source: obj