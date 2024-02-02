
#r "nuget: Fli"
open Fli

let [<Literal>] workFolder = @"/home/gergo/Werk/IntelliFactory"

System.IO.Directory.GetDirectories(".")
|> Array.map (fun dirName -> if dirName.StartsWith("./") then dirName.Substring(2) else dirName)
|> Array.iter (fun dirName -> 
    
    // let cmd =  $"cd {dirName} && dotnet add package GensAndHooks && cd .."
    // printfn $"{cmd}"
    cli {
        Shell BASH
        Command $"cd {dirName} && dotnet remove package GensAndHooks && dotnet add package GensAndHooks && dotnet build"
    }
    |> Command.execute
    |> (fun x -> x.Text)
    |> Option.map (printfn "%s")
    |> Option.defaultValue (printfn "Nothing lmao")
    )

// System.Diagnostics.Process.Start()