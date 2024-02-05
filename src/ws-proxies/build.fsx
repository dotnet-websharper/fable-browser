
#r "nuget: Fli"
open Fli


System.IO.Directory.GetDirectories(".")
|> Array.map (fun dirName -> if dirName.StartsWith("./") then dirName.Substring(2) else dirName)
|> Array.filter (fun x -> x.StartsWith "WebSharper")
|> Array.iter (fun dirName -> 
    
    // let cmd =  $"cd {dirName} && dotnet add package GensAndHooks && cd .."
    // printfn $"{cmd}"
    cli {
        Shell BASH
        Command $"cd {dirName} && dotnet remove package GensAndHooks && dotnet add package GensAndHooks && dotnet add package FablePartialProxy"
    }
    |> Command.execute
    |> ignore
    )

// System.Diagnostics.Process.Start()