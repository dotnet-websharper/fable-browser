module private Proxies

open WebSharper
open WebSharper.JavaScript
    
[<Proxy("Fable.Core.Util, Fable.Core")>]
module private UtilProxy =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>

[<Proxy(typeof<Fable.Core.U2<_,_>>)>]
type private U2Proxy<'a,'b> = JavaScript.Union<'a,'b>
[<Proxy(typeof<Fable.Core.U3<_,_,_>>)>]
type private U3Proxy<'a,'b,'c> = JavaScript.Union<'a,'b,'c>

[<Proxy(typeof<Fable.Core.U4<_,_,_,_>>)>]
type private U4Proxy<'a,'b,'c,'d> = JavaScript.Union<'a,'b,'c,'d>

[<Proxy(typeof<Fable.Core.JS.Console>)>]
type ConsoleProxy = JavaScript.Console