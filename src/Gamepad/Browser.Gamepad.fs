namespace Browser.Types


type [<WebSharper.Stub>] GamepadButton =
    abstract value: float
    abstract pressed: bool

type [<WebSharper.Stub>] Gamepad =
    abstract axes: ResizeArray<float>
    abstract buttons: ResizeArray<GamepadButton>
    abstract connected: bool
    abstract id: string
    abstract index: int
    abstract mapping: string
    abstract timestamp: float

namespace Browser

// open Fable.Core
open Browser.Types

[<AutoOpen>]
module Gamepad =
    let [<WebSharper.Inline>] gamepad: Gamepad = jsNative
