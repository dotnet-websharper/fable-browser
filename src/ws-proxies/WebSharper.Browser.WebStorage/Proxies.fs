module private Proxies

open WebSharper
open WebSharper.JavaScript

[<AbstractClass;Stub>]
type StorageProxy =
    interface Browser.Types.Storage with
        member this.Item
            with get (index: int): string = 
                let th = (this |> As<JavaScript.Storage>)
                th.GetItem(th.Key(index))
                // JS.Inline("$0[$1]",this,index)
            and set (index: int) (v: string): unit = 
                let th = (this |> As<JavaScript.Storage>)
                th.SetItem(th.Key(index), v)
                // JS.Inline("$0[$1]=$2",this,index,v)
        member this.Item
            with get (key: string): string = 
                (this |> As<JavaScript.Storage>).GetItem(key)
                // JS.Inline("$0[$1]",this,key)
            and set (key: string) (v: string): unit = 
                (this |> As<JavaScript.Storage>).SetItem(key,v)
                // JS.Inline("$0[$1]=$2",this,key,v)
        member this.clear(): unit = 
            (this |> As<JavaScript.Storage>).Clear()
        member this.getItem(key: string): string = 
            (this |> As<JavaScript.Storage>).GetItem(key)
        member this.key(index: float): string = 
            (this |> As<JavaScript.Storage>).Key(int(index))
        member this.length: int = 
            (this |> As<JavaScript.Storage>).Length
        member this.removeItem(key: string): unit = 
            failwith "Not Implemented"
        member this.setItem(key: string, data: string): unit = 
            failwith "Not Implemented"