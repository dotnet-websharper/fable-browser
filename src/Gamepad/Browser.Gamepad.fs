namespace Browser.Types

open Fable.Core

type [<Global>] GamepadButton =
    abstract value: float
    abstract pressed: bool

type [<Global>] Gamepad =
    abstract axes: ResizeArray<float>
    abstract buttons: ResizeArray<GamepadButton>
    abstract connected: bool
    abstract id: string
    abstract index: int
    abstract mapping: string
    abstract timestamp: float

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Gamepad =
    [<Global>]
    let gamepad: Gamepad = 
        #if JAVASCRIPT
        Unchecked.defaultof<Gamepad>
        #else
        jsNative
        #endif
