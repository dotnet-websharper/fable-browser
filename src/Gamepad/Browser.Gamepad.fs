namespace Browser.Types

#if FABLE_COMPILER
open Fable.Core
#elif JAVASCRIPT
open WebSharper
open WebSharper.JavaScript
#endif

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
[<WebSharper.Stub>]
#endif
type GamepadButton =
    abstract value: float
    abstract pressed: bool

#if FABLE_COMPILER
[<Global>]
#elif JAVASCRIPT
[<WebSharper.Stub>]
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

#if FABLE_COMPILER
open Fable.Core
#elif JAVASCRIPT
open WebSharper
#endif
open Browser.Types

[<AutoOpen>]
module Gamepad =
    #if FABLE_COMPILER
    [<Global>]
    #elif JAVASCRIPT
    [<WebSharper.Inline>]
    #endif
    let gamepad: Gamepad = 
        #if FABLE_COMPILER
        jsNative
        #else
        Unchecked.defaultof<Gamepad>
        #endif
