module internal FableProxies

open System
open WebSharper
open WebSharper.JavaScript

[<JavaScript false>] 
type JSOptionsMacro() =
    inherit Core.Macro()

    // override this.
    override this.TranslateCall(c: Core.MacroCall) =
        let rec gatherSetters (st: Core.AST.Statement list) =
            match st with
            | [Core.AST.Statement.Block statements] ->
                statements |> gatherSetters
            | Core.AST.Statement.ExprStatement(Core.AST.Expression.ExprSourcePos(_, Core.AST.Expression.FieldSet(Some this, td, f, v)))::xs
            | Core.AST.Statement.ExprStatement(Core.AST.Expression.FieldSet(Some this, td, f, v))::xs ->
                (this, f, v) :: gatherSetters xs
            | Core.AST.Statement.ExprStatement(Core.AST.Expression.ExprSourcePos(_, Core.AST.Expression.Call(Some this, td, f, v)))::xs
            | Core.AST.Statement.ExprStatement(Core.AST.Expression.Call(Some this, td, f, v))::xs ->
                (this, f.Entity.Value.MethodName.Replace("set_", ""), v.Head) :: gatherSetters xs
            | [] -> []
            | x::xs ->
                gatherSetters xs
        
        match c.Arguments with
        | [Core.AST.Expression.ExprSourcePos (_, Core.AST.Expression.Function ([arg], None, _, body))]
        | [Core.AST.Expression.Function ([arg], None, _, body)] ->
            gatherSetters [body]
            |> List.choose (fun (this, f, v) ->
                match this with
                | Core.AST.Expression.ExprSourcePos(_, Core.AST.Expression.Var t)
                | Core.AST.Expression.Var t ->
                    if t = arg then  
                        Some (f, Core.AST.MemberKind.Simple ,v)
                    else
                        None
                | _ -> None
            )
            |> Core.AST.Expression.Object
            |> Core.MacroOk
        | _ ->
            Core.MacroError <| sprintf "Incorrect usage of JSOptions %A" c.Arguments

[<Proxy("Fable.Core.Util, Fable.Core")>]
module internal UtilProxy =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>


[<Proxy("Fable.Core.JsInterop, Fable.Core")>]
module internal JsInteropProxies =
    let (==>) (a:string,o:obj) : (string*obj) =
        a => o // TODO: check
    
    //! TODO: jsOptions
    //! Create a literal JS object from a mutator lambda. Normally used when
    //! the options interface has too many fields to be represented with a Pojo record.
    //! E.g. `jsOptions<MyOpt> (fun o -> o.foo <- 5)` in JS becomes `{ foo: 5 }`


    let op_Dynamic<'T>(a:obj, b:obj) : 'T =
        Pervasives.(?) a (string b)
    let op_DynamicAssignment(a:obj,b:obj,c:obj) : unit =
        a?b <- c
    let toPlainJsObj (o: 'T):obj = JS.New o
    [<Inline>] 
    let (!!) x = unbox x

    [<Inline>]
    let createObj<'b when 'b :> seq<string*obj>> (fields: 'b) = New fields

    [<Fable.Core.FableImportJs;Inline>]
    let importDefault<'T0> (path:string) : 'T0 = Fable.Core.Util.jsNative

    [<Fable.Core.FableImportJs;Inline>]
    let import<'T> (selector:string) (path:string) : 'T = Fable.Core.Util.jsNative

    [<Inline>]
    let importSideEffects (path:string) = WebSharper.JavaScript.JS.ImportFile path

    [<Inline "$target == null">]
    let isNullOrUndefined (target:obj) : bool = target = null

    [<Macro(typeof<JSOptionsMacro>)>]
    let jsOptions<'T> (f: 'T -> unit) : 'T = X<'T>

[<Proxy("Fable.Core.JS, Fable.Core")>]
module internal JSProxy =
    let [<Inline "undefined">] undefined<'T> = X<'T>

    let setTimeout (fn:unit->unit, timeout:int):int =
        WebSharper.JavaScript.JS.SetTimeout fn timeout
        |> As<int>

    let [<Fable.Core.Global>] console : Fable.Core.JS.Console = Fable.Core.Util.jsNative

    [<Inline>]
    let inline  (!!) x = unbox x
    let (==>) (key: string) v = key,v :> obj

    [<Inline>]
    let inline createObj<'b when 'b :> seq<string*obj>> (fields: 'b) = New fields

[<Proxy(typeof<Fable.Core.U2<_,_>>)>]
type internal U2Proxy<'a,'b> = JavaScript.Union<'a,'b>
[<Proxy(typeof<Fable.Core.U3<_,_,_>>)>]
type internal U3Proxy<'a,'b,'c> = JavaScript.Union<'a,'b,'c>

[<Proxy(typeof<Fable.Core.U4<_,_,_,_>>)>]
type internal U4Proxy<'a,'b,'c,'d> = JavaScript.Union<'a,'b,'c,'d>

[<Proxy(typeof<Fable.Core.JS.Console>)>]
type internal ConsoleProxy =
    // member this.``assert``(?test: bool * ?message: string * [<ParamArray>] optionalParams: obj[]) =
    //     WebSharper.JavaScript.Console.
    // member this.clear() =
    //     WebSharper.JavaScript.Console.
    // member this.count(countTitle: string) = WebSharper.JavaScript.Console.Count(countTitle)
    // member this.debug(?message: string * [<ParamArray>] optionalParams: obj[]) = 
    //     WebSharper.JavaScript.Console
    // member this.dir: ?value: obj * [<ParamArray>] optionalParams: obj[] -> unit
    // member this.dirxml: value: obj -> unit
    member this.error(message: obj option, [<ParamArray>] optionalParams: obj[]) =
        WebSharper.JavaScript.Console.Error(message, optionalParams)
    // member this.group: ?groupTitle: string -> unit
    // member this.groupCollapsed: ?groupTitle: string -> unit
    // member this.groupEnd: unit -> unit
    // member this.info: ?message: obj * [<ParamArray>] optionalParams: obj[] -> unit
    member this.log (message: obj option, [<ParamArray>] optionalParams: obj[]) =
        WebSharper.JavaScript.Console.Log(message, optionalParams)
    // member this.profile: ?reportName: string -> unit
    // member this.profileEnd: unit -> unit
    // member this.time: ?timerName: string -> unit
    // member this.timeEnd: ?timerName: string -> unit
    // member this.trace: ?message: obj * [<ParamArray>] optionalParams: obj[] -> unit
    // member this.warn: ?message: obj * [<ParamArray>] optionalParams: obj[] -> unit
    // member this.table: ?data: obj -> unit