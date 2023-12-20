namespace Browser.Types

open WebSharper
    
    [<AutoOpen;InternalProxy("Fable.Core.Util, Fable.Core")>]
    module internal UtilProxy =
        let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>

    
    // [<Stub; Proxy(typeof<Browser.Types.GamepadButton>)>]
    // type private GamepadButton =
    //     abstract value: float
    //     abstract pressed: bool

    // [<Stub; Proxy(typeof<Browser.Types.Gamepad>)>]
    // type private Gamepad =
    //     abstract axes: ResizeArray<float>
    //     abstract buttons: ResizeArray<GamepadButton>
    //     abstract connected: bool
    //     abstract id: string
    //     abstract index: int
    //     abstract mapping: string
    //     abstract timestamp: float
    
    // [<Proxy("Browser.Gamepad, Browser.Gamepad")>]
    // module private Gamepad =
    //     let [<Inline>] gamepad : Browser.Types.Gamepad = jsNative
        