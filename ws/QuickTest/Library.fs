namespace QuickTest

open WebSharper
open WebSharper.JavaScript
open Browser.Types

[<JavaScript>]
module Client = 
    type Class1() = 
        member this.X = "F#"

    [<SPAEntryPoint>]
    let Main () =
        Dom.console.log(5)