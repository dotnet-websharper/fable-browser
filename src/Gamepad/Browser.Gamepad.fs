namespace Browser.Types

#if JAVASCRIPT
open WebSharper
open WebSharper.JavaScript
#else
open Fable.Core
#endif

#if !JAVASCRIPT
[<Global>]
#endif
type GamepadButton =
    abstract value: float
    abstract pressed: bool

#if !JAVASCRIPT
[<Global>]
#endif
type Gamepad =
    abstract axes: ResizeArray<float>
    abstract buttons: ResizeArray<GamepadButton>
    abstract connected: bool
    abstract id: string
    abstract index: int
    abstract mapping: string
    abstract timestamp: float

namespace Browser

#if JAVASCRIPT
open WebSharper
#else
open Fable.Core
#endif
open Browser.Types

[<AutoOpen>]
module Gamepad =
    #if JAVASCRIPT
    [<WebSharper.Inline>]
    #else
    [<Global>]
    #endif
    let gamepad: Gamepad = jsNative
