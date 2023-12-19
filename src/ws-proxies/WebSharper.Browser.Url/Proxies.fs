module private Proxies
open WebSharper
open WebSharper.JavaScript

[<InternalProxy("Fable.Core.Util, Fable.Core"); AutoOpen>]
module private UtilProxy =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>

[<Proxy(typeof<Browser.Types.URLSearchParams>); Stub>]
type URLSearchParamsProxy =
    [<Inline>] abstract append: name: string * value: string -> unit
    [<Inline>] abstract delete: name: string -> unit
    [<Inline>] abstract get: name: string -> string option
    [<Inline>] abstract getAll: name: string -> array<string>
    [<Inline>] abstract has: name: string -> bool
    [<Inline>] abstract set: name: string * value: string -> unit

    [<Inline>]
    default this.append(name,value) =
        (this |> As<URLSearchParams>).Append(name,value)
    
    [<Inline>]
    default this.delete(name) =
        (this |> As<URLSearchParams>).Delete name
    
    [<Inline>]
    default this.get(name) =
        if (this |> As<URLSearchParams>).Has name 
        then Some ((this |> As<URLSearchParams>).Get name) 
        else None
    [<Inline>]
    default this.getAll(name) =
        (this |> As<URLSearchParams>).GetAll name
    
    [<Inline>]
    default this.has(name) =
        (this |> As<URLSearchParams>).Has name
    [<Inline>]
    default this.set(name,value) =
        (this |> As<URLSearchParams>).Set(name,value)

[<Proxy(typeof<Browser.Types.URLSearchParamsType>)>]
type [<AllowNullLiteral>] URLSearchParamsTypeProxy =
    [<Inline("new URLSearchParams($arg)")>] abstract Create: arg: obj -> Browser.Types.URLSearchParams


type [<Proxy(typeof<Browser.Types.URL>)>] URLProxy =
    [<Inline>] abstract hash: string with get, set
    [<Inline>] abstract host: string with get, set
    [<Inline>] abstract hostname: string with get, set
    [<Inline>] abstract href: string with get, set
    [<Inline>] abstract origin: string
    [<Inline>] abstract password: string with get, set
    [<Inline>] abstract pathname: string with get, set
    [<Inline>] abstract port: string with get, set
    [<Inline>] abstract protocol: string with get, set
    [<Inline>] abstract search: string with get, set
    [<Inline>] abstract username: string with get, set
    [<Inline>] abstract searchParams: Browser.Types.URLSearchParams
    [<Inline>] abstract toString: unit -> string
    [<Inline>] abstract toJSON: unit -> string

    default this.hash
        with [<Inline>] get () = (this |> As<URL>).Hash
        and [<Inline>] set (v) =  (this |> As<URL>).Hash <- v
    default this.host
        with [<Inline>] get () = (this |> As<URL>).Host
        and [<Inline>] set (v) =  (this |> As<URL>).Host <- v
    default this.hostname
        with [<Inline>] get () = (this |> As<URL>).Hostname
        and [<Inline>] set (v) =  (this |> As<URL>).Hostname <- v
    default this.href
        with [<Inline>] get () = (this |> As<URL>).Href
        and [<Inline>] set (v) =  (this |> As<URL>).Href <- v
    default this.origin
        with [<Inline>] get () = (this |> As<URL>).Origin
    default this.password
        with [<Inline>] get () = (this |> As<URL>).Password
        and [<Inline>] set (v) =  (this |> As<URL>).Password <- v
    default this.pathname
        with [<Inline>] get () = (this |> As<URL>).Pathname
        and [<Inline>] set (v) =  (this |> As<URL>).Pathname <- v
    default this.port
        with [<Inline>] get () = (this |> As<URL>).Port
        and [<Inline>] set (v) =  (this |> As<URL>).Port <- v
    default this.protocol
        with [<Inline>] get () = (this |> As<URL>).Protocol
        and [<Inline>] set (v) =  (this |> As<URL>).Protocol <- v
    default this.search
        with [<Inline>] get () = (this |> As<URL>).Search
        and [<Inline>] set (v) =  (this |> As<URL>).Search <- v
    default this.username
        with [<Inline>] get () = (this |> As<URL>).Username
        and [<Inline>] set (v) =  (this |> As<URL>).Username <- v
    default this.searchParams
        with [<Inline>] get () = (this |> As<URL>).SearchParams |> As

    [<Inline>]
    default this.toString () = (this |> As<URL>).ToString()

    [<Inline>]
    default this.toJSON () = Json.Stringify(this |> As<URL>)

[<Proxy("Browser.Url, Browser.Url")>]
module UrlModuleProxy =
    let [<Inline>] URL : Browser.Types.URLType = jsNative
    let [<Inline>] URLSearchParams: Browser.Types.URLSearchParamsType = jsNative