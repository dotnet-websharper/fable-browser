namespace Browser.Types

open System

type [<AllowNullLiteral; WebSharper.Stub>] Storage =
    member this.length: int = jsNative
    
    member this.Item
        with [<WebSharper.Inline("$this[$key]")>] get(key: string): string = jsNative
        and [<WebSharper.Inline("$this[$key]=$v")>] set(key:string) (v:obj) : unit = jsNative
    member this.Item
        with [<WebSharper.Inline("$this[$idx]")>] get(idx: int): string = jsNative
        and [<WebSharper.Inline("$this[$idx]=$v")>] set (idx:int) (v:obj) : unit = jsNative
    [<WebSharper.Inline>] member this.clear() = jsNative
    [<WebSharper.Inline>] member this.getItem(key: string): string = jsNative
    [<WebSharper.Inline>] member this.key(index: float): string = jsNative
    [<WebSharper.Inline>] member this.removeItem(key: string): unit = jsNative
    [<WebSharper.Inline>] member this.setItem(key: string, data: string) : unit = jsNative

type [<AllowNullLiteral; WebSharper.Stub>] StorageEvent =
    inherit Event
    abstract url: string
    abstract key: string
    abstract oldValue: string
    abstract newValue: string
    abstract storageArea: Storage

namespace Browser

open Browser.Types

[<AutoOpen>]
module WebStorage =
    let [<WebSharper.Inline>] localStorage: Storage = jsNative
    let [<WebSharper.Inline>] sessionStorage: Storage = jsNative
