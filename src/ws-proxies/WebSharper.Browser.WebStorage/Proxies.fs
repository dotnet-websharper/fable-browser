namespace Browser.Types

open WebSharper
open WebSharper.JavaScript

[<AutoOpen;InternalProxy("Fable.Core.Util, Fable.Core")>]
module internal UtilProxy =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>
// [<Proxy(typeof<Browser.Types.Storage>)>]
// type StorageProxy =
//     [<Inline>] abstract length: int
//     [<Inline>] abstract Item: key: string -> string with get, set
//     [<Inline>] abstract Item: index: int -> string with get, set
//     [<Inline>] abstract clear: unit -> unit
//     [<Inline>] abstract getItem: key: string -> string
//     [<Inline>] abstract key: index: float -> string
//     [<Inline>] abstract removeItem: key: string -> unit
//     [<Inline>] abstract setItem: key: string * data: string -> unit
//     default this.Item
//         with [<Inline>] get (index: int): string = 
//             let th = (this |> As<JavaScript.Storage>)
//             th.GetItem(th.Key index)
//             // JS.Inline("$0[$1]",this,index)
//         and [<Inline>] set (index: int) (v: string): unit = 
//             let th = (this |> As<JavaScript.Storage>)
//             th.SetItem(th.Key index, v)
//             // JS.Inline("$0[$1]=$2",this,index,v)
//     default this.Item
//         with [<Inline>] get (key: string): string = 
//             (this |> As<JavaScript.Storage>).GetItem(key)
//             // JS.Inline("$0[$1]",this,key)
//         and [<Inline>] set (key: string) (v: string): unit = 
//             (this |> As<JavaScript.Storage>).SetItem(key,v)
//             // JS.Inline("$0[$1]=$2",this,key,v)
//     [<Inline>]
//     default this.clear(): unit = 
//         (this |> As<JavaScript.Storage>).Clear()
//     [<Inline>]
//     default this.getItem(key: string): string = 
//         (this |> As<JavaScript.Storage>).GetItem(key)
//     [<Inline>]
//     default this.key(index: float): string = 
//         (this |> As<JavaScript.Storage>).Key(int(index))
//     [<Inline>]
//     default this.length: int = 
//         (this |> As<JavaScript.Storage>).Length
//     [<Inline>]
//     default this.removeItem(key: string): unit = 
//         (this |> As<JavaScript.Storage>).RemoveItem(key)
//     [<Inline>]
//     default this.setItem(key: string, data: string): unit = 
//         (this |> As<JavaScript.Storage>).SetItem(key,data)

// [<Proxy(typeof<Browser.Types.StorageEvent>)>]
// type StorageEventProxy =
//     inherit Browser.Types.Event
//     [<Inline>] abstract url: string with get
//     [<Inline>] abstract key: string with get
//     [<Inline>] abstract oldValue: string with get
//     [<Inline>] abstract newValue: string with get
//     [<Inline>] abstract storageArea: Browser.Types.Storage with get

//     // default this.url = (this |> As<StorageEvent>).Url
//     // default this.key = (this |> As<StorageEvent>).Key
//     // default this.oldValue = (this |> As<StorageEvent>).OldValue
//     // default this.newValue = (this |> As<StorageEvent>).NewValue
//     // default this.storageArea = (this |> As<StorageEvent>).StorageArea |> As

// [<Proxy("Browser.WebStorage, Browser.WebStorage")>]
// module WebStorageProxy =
//     let [<Inline>] localStorage : Browser.Types.Storage = jsNative
//     let [<Inline>] sessionStorage : Browser.Types.Storage = jsNative