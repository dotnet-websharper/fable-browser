
#r "nuget: FAKE.Core"
#r "nuget: Fake.Core.Target"
#r "nuget: Fake.IO.FileSystem"
#r "nuget: Fake.Tools.Git"
#r "nuget: Fake.DotNet.Cli"
#r "nuget: Fake.DotNet.AssemblyInfoFile"
#r "nuget: Fake.DotNet.Paket"

open Fake.Core
System.Environment.GetCommandLineArgs()
|> Array.skip 2 // skip fsi.exe; build.fsx
|> Array.toList
|> Fake.Core.Context.FakeExecutionContext.Create false __SOURCE_FILE__
|> Fake.Core.Context.RuntimeContext.Fake
|> Fake.Core.Context.setExecutionContext

#load "paket-files/wsbuild/github.com/dotnet-websharper/build-script/WebSharper.Fake.fsx"
open WebSharper.Fake
open Fake.DotNet
open Fake.Core
open Fake.Core.TargetOperators

let WithProjects projects args =
    { args with BuildAction = Projects projects }

Target.create "PrePackaging" <| fun _ ->
    let files =
        [
            "Blob"
            "Gamepad"
            "Event"
            "Performance"
            "Url"
            "WebSocket"
            "WebStorage"
            "Dom"
            "XMLHttpRequest"
            "Svg"
            "Css"
            "Worker"
            "Geolocation"
            "Navigator"
            "MediaStream"
            "MediaRecorder"
            "MediaQueryList"
            "WebRTC"
            "WebGL"
            "IndexedDB"
            "IntersectionObserver"
            "ResizeObserver"
        ]

    let fableTemplate = """type file
id WebSharper.Fable.Core
authors IntelliFactory
projectUrl https://websharper.com/
repositoryType git
repositoryUrl https://github.com/dotnet-websharper/fable-browser/
licenseUrl https://github.com/dotnet-websharper/fable-browser/blob/master/LICENSE.md
iconUrl https://github.com/dotnet-websharper/core/raw/websharper50/tools/WebSharper.png
description
    WebSharper Proxy for Fable.Core
tags
    WebSharper Fable FSharp CSharp JavaScript WebAPI
dependencies
    framework: netstandard2.0
        WebSharper ~> LOCKEDVERSION:[3]
        Fable.Core >= 4.0
files
    ../websharper/WebSharper.Fable.Core/bin/Release/netstandard2.0/WebSharper.Fable.Core.dll ==> lib/netstandard2.0
    ../websharper/WebSharper.Fable.Attributes/bin/Release/netstandard2.0/WebSharper.Fable.Attributes.dll ==> lib/netstandard2.0

references
    WebSharper.Fable.Core.dll
    WebSharper.Fable.Attributes.dll

"""

    let template = """type file
id WebSharper.Browser.%TEMP%
authors IntelliFactory
projectUrl https://websharper.com/
repositoryType git
repositoryUrl https://github.com/dotnet-websharper/fable-browser/
licenseUrl https://github.com/dotnet-websharper/fable-browser/blob/master/LICENSE.md
iconUrl https://github.com/dotnet-websharper/core/raw/websharper50/tools/WebSharper.png
description
    WebSharper Proxy for Fable's Browser.%TEMP%
tags
    WebSharper Fable FSharp CSharp JavaScript WebAPI %TEMP%
dependencies
    framework: netstandard2.0
        WebSharper ~> LOCKEDVERSION:[3]
        Fable.Browser.%TEMP% == %VERSION%
files
    ../websharper/WebSharper.Browser.%TEMP%/bin/Release/netstandard2.0/WebSharper.Browser.%TEMP%.dll ==> lib/netstandard2.0

references
    WebSharper.Browser.%TEMP%.dll

"""

    let content x v = template.Replace("%TEMP%", x).Replace("%VERSION%", v)

    let getVersionNumber x =
        let lines = System.IO.File.ReadAllLines(sprintf "src/%s/Browser.%s.fsproj" x x)
        lines
        |> Array.pick (fun x ->
            let line = x.Trim()
            if line.StartsWith "<PackageVersion>" then
                line.Replace("<PackageVersion>","").Replace("</PackageVersion>", "") |> Some
            else
                None
        )

    files
    |> List.iter (fun x ->
        let versionNumber = getVersionNumber x
        System.IO.Directory.CreateDirectory "nuget" |> ignore
        System.IO.File.WriteAllText(sprintf "nuget/WebSharper.Browser.%s.paket.template" x, content x versionNumber)
    )

    System.IO.File.WriteAllText(sprintf "nuget/WebSharper.Fable.Core.paket.template", fableTemplate)

let targets =
    LazyVersionFrom "WebSharper" |> WSTargets.Default
    |> fun args ->
        { args with
            Attributes = [
                AssemblyInfo.Company "IntelliFactory"
                AssemblyInfo.Copyright "(c) IntelliFactory 2023"
                AssemblyInfo.Title "https://github.com/dotnet-websharper/fable-browser"
                AssemblyInfo.Product "WebSharper Browser"
            ]
        }
    |> WithProjects [
        "websharper/WebSharper.sln"
    ]
    |> MakeTargets

"PrePackaging" ==> "WS-Package"

"WS-Package" ==> "CI-Release"

targets
|> RunTargets
