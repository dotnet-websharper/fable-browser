namespace Fable.Core

open WebSharper
open WebSharper.Core
open WebSharper.Core.AST
module M = Metadata
module I = AST.IgnoreSourcePos
[<JavaScript false>]
[<Sealed>]
type FableImportJSMacro() =
    inherit Macro()

    override __.TranslateCall(c) =
        match c.Method.Entity.Value.MethodName with
        | "import" ->
            match c.Arguments with
            | [I.Value (String export); I.Value (String from)] ->
                if JavaScript.Identifier.IsValid export || export = "*" then
                    c.Compilation.AddJSImport (Some export, from) |> MacroOk
                elif export = "default" then
                    c.Compilation.AddJSImport (None, from) |> MacroOk                
                else
                    MacroError "import export argument must be a valid identifier"
            | _ -> MacroError "import arguments must be constant string"
        | "importDefault" ->
            match c.Arguments with
            | [I.Value (String from)] ->
                c.Compilation.AddJSImport (None, from) |> MacroOk
            | _ -> MacroError "importDefault arguments must be constant string"
        | "importAll" ->
            match c.Arguments with
            | [I.Value (String from)] ->
                c.Compilation.AddJSImport (Some "*", from) |> MacroOk
            | _ -> MacroError "importAll argument must be constant string"
        | _ ->
            failwith "Unrecognized method using ImportJS"
  
[<JavaScript false>]          
[<Macro(typeof<FableImportJSMacro>)>]
type FableImportJsAttribute() =
    inherit System.Attribute()

type GlobalMacro() =
    inherit Core.Macro()

    override this.TranslateCall(c) =
        Core.AST.Expression.GlobalAccess
            {
                Module = Core.AST.Module.StandardLibrary
                Address = [c.Method.Entity.Value.MethodName]
            } |> Core.MacroOk

[<Macro(typeof<GlobalMacro>)>]
type GlobalAttribute() = inherit System.Attribute()


[<JavaScript(false)>]
type NoneGenerator() =
    inherit Generator()

    override this.Generate(gen: Generated): GeneratorResult =
        GeneratedAST gen.Expression

[<JavaScript(false)>]
[<Generated(typeof<NoneGenerator>)>]
type EraseAttribute() =
    inherit System.Attribute()

[<JavaScript(false)>]
[<Generated(typeof<NoneGenerator>)>]
type StringEnumAttribute() =
    inherit System.Attribute()

[<JavaScript(false)>]
type EmitMacro() =
    inherit Core.Macro()

    override this.TranslateCall(c) =
        let arg =
            match c.Compilation.GetMethodAttributes(c.DefiningType.Entity, c.Method.Entity) with
            | Some (attr) ->
                attr
                |> List.tryFind (fun (attr, args) ->
                    attr.Value.FullName.Contains "EmitAttribute"
                )
                |> Option.bind (fun (attr, args) ->
                    if args.Length <> 1 then
                        c.Compilation.AddError(None, "EmitAttribute should be used with a single argument")
                        None
                    else
                        match args.[0] with
                        | Core.Metadata.ParameterObject.String s ->
                            Some s
                        | _ ->
                            None
                )
                |> Option.defaultValue ""
            | _ -> 
                c.Compilation.AddError(None, "EmitAttribute should be with a string literal")
                ""
        // branch if it's the setter/getter property
        if arg = "$0[$1]{{=$2}}" then
            if c.Method.Entity.Value.MethodName.StartsWith "get_" && c.This.IsSome && c.Arguments.Length = 1 then
                Core.AST.Expression.Verbatim([""; "["; "]"], [c.This.Value; yield! c.Arguments], false)
                |> Core.MacroOk
            elif c.Method.Entity.Value.MethodName.StartsWith "set_" && c.This.IsSome && c.Arguments.Length = 2 then
                Core.AST.Expression.Verbatim([""; "["; "]="; ""], [c.This.Value; yield! c.Arguments], false)
                |> Core.MacroOk
            else
                Core.AST.Expression.Verbatim([""; "["; "]"], [c.This.Value; yield! c.Arguments], false)
                |> Core.MacroOk
        else if arg.Contains "{{=$1}}" then
            let propName = arg.Replace("{{=$1}}", "").Replace("$0", "")
            if c.Method.Entity.Value.MethodName.StartsWith "get_" && c.This.IsSome && c.Arguments.Length = 0 then
                Core.AST.Expression.Verbatim([""; propName], [c.This.Value; yield! c.Arguments], false)
                |> Core.MacroOk
            elif c.Method.Entity.Value.MethodName.StartsWith "set_" && c.This.IsSome && c.Arguments.Length = 1 then
                Core.AST.Expression.Verbatim([""; propName + "="; ""], [c.This.Value; yield! c.Arguments], false)
                |> Core.MacroOk
            else
                Core.AST.Expression.Verbatim([""; propName], [c.This.Value; yield! c.Arguments], false)
                |> Core.MacroOk
        else
            // otherwise do the default behavior shit

            let parts,matches =
                let regex = System.Text.RegularExpressions.Regex("\$\d+(\.\.\.)?")
                regex.Split(arg),regex.Matches(arg)
            let mutable needsExtraArgs = 0
            let v =
                let enumerator = matches.GetEnumerator()
                [
                    while enumerator.MoveNext() do
                        let i = (enumerator.Current :?> System.Text.RegularExpressions.Match).Value.Trim([|'$'|])
                        if i.EndsWith "..." then
                            let i = int (i.TrimEnd([|'.'|]))
                            if c.This.IsSome then
                                yield! c.Arguments[i-1 ..]
                                needsExtraArgs <- c.Arguments[i-1 ..].Length
                            else
                                yield! c.Arguments[i ..]
                                needsExtraArgs <- c.Arguments[i ..].Length
                        else
                            let i = int i
                            if i = 0 && c.This.IsSome then
                                yield c.This.Value
                            elif c.This.IsSome then
                                yield c.Arguments[i-1]
                            else
                                yield c.Arguments[i]
                ]
            Core.AST.Expression.Verbatim(parts |> List.ofArray |> List.collect (fun x -> if x = "..." && needsExtraArgs >= 1 then List.replicate (needsExtraArgs - 1) "," else [x]), v, false)
            |> Core.MacroOk

[<Macro(typeof<EmitMacro>)>]
type EmitAttribute(i: string) =
    inherit System.Attribute()