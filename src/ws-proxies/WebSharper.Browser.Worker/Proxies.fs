module private Proxies

open System
open WebSharper

[<AutoOpen;InternalProxy("Fable.Core.Util, Fable.Core")>]
module UtilProxies =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>

[<InternalProxy(typeof<Fable.Core.JS.Promise<_>>)>]
type PromiseProxy<'a> = JavaScript.Promise<'a>

[<Proxy(typeof<Browser.Types.AbstractWorker>)>]
type AbstractWorkerProxy =
    abstract onerror: (Browser.Types.ErrorEvent -> unit) with get, set

type [<Proxy(typeof<Browser.Types.Worker>)>] WorkerProxy =
    inherit Browser.Types.EventTarget
    inherit Browser.Types.AbstractWorker
    abstract onmessage: (Browser.Types.MessageEvent -> unit) with get, set
    abstract postMessage: message: obj * ?transfer: obj -> unit
    abstract terminate: unit -> unit

[<NamedUnionCases; Proxy(typeof<Browser.Types.WorkerType>)>]
type WorkerTypeProxy =
    | Classic
    | Module

[<NamedUnionCases; Proxy(typeof<Browser.Types.WorkerCredentials>)>]
type WorkerCredentialsProxy =
    | Omit
    | [<Constant("same-origin")>] SameOrigin
    | Include

[<Proxy(typeof<Browser.Types.WorkerOptions>)>]
type WorkerOptionsProxy =
    /// A DOMString specifying the type of worker to create. The value can be classic or module. If not specified, the default used is classic.
    abstract ``type``: Browser.Types.WorkerType with get, set
    /// A DOMString specifying the type of credentials to use for the worker. The value can be omit, same-origin, or include. If not specified, or if type is classic, the default used is omit (no credentials required).
    abstract credentials: Browser.Types.WorkerCredentials with get, set
    /// A DOMString specifying an identifying name for the DedicatedWorkerGlobalScope representing the scope of the worker, which is mainly useful for debugging purposes.
    abstract name: string with get, set

[<Proxy(typeof<Browser.Types.WorkerConstructor>)>]
type WorkerConstructorProxy =
    [<Inline("new Worker($url,$options)")>] abstract Create: url: string * ?options: Browser.Types.WorkerOptions -> Browser.Types.Worker

[<NamedUnionCases; Proxy(typeof<Browser.Types.ServiceWorkerState>)>]
type ServiceWorkerStateProxy =
    | Installing
    | Installed
    | Activating
    | Activated
    | Redundant

type [<Proxy(typeof<Browser.Types.ServiceWorker>)>] ServiceWorkerProxy =
    inherit Browser.Types.Worker
    abstract scriptURL: string
    abstract state: Browser.Types.ServiceWorkerState
    abstract onstatechange: (Browser.Types.Event -> unit) option with get, set

type [<Proxy(typeof<Browser.Types.ServiceWorkerRegistration>)>] ServiceWorkerRegistrationProxy =
    abstract scope: string
    abstract installing: Browser.Types.ServiceWorker option
    abstract waiting: Browser.Types.ServiceWorker option
    abstract active: Browser.Types.ServiceWorker option
    // TODO abstract navigationPreload
    // TODO: abstract pushManager: PushManager
    abstract onupdatefound: (Browser.Types.Event -> unit) option with get, set
    // TODO: abstract getNotifications: ?options: ServiceWorkerNotificationOptions -> JS.Promise<Notification[]>
    // TODO: abstract showNotifications()
    abstract update: unit -> Fable.Core.JS.Promise<Browser.Types.ServiceWorkerRegistration>
    abstract unregister: unit -> Fable.Core.JS.Promise<bool>

[<Proxy(typeof<Browser.Types.ServiceWorkerRegistrationOptions>)>]
type ServiceWorkerRegistrationOptionsProxy =
    /// A USVString representing a URL that defines a service worker's registration scope; that is, what range of URLs a service worker can control. This is usually a relative URL. It is relative to the base URL of the application. By default, the scope value for a service worker registration is set to the directory where the service worker script is located.
    abstract scope: string with get, set

type [<Proxy(typeof<Browser.Types.ServiceWorkerContainer>)>] ServiceWorkerContainerProxy =
    abstract controller: Browser.Types.ServiceWorker option
    abstract ready: Fable.Core.JS.Promise<Browser.Types.ServiceWorkerRegistration>
    abstract oncontrollerchange: (Browser.Types.Event -> unit) with get, set
    abstract onerror: (Browser.Types.Event -> unit) with get, set
    abstract onmessage: (Browser.Types.Event -> unit) with get, set
    abstract register: url: string * ?options: Browser.Types.ServiceWorkerRegistrationOptions -> Fable.Core.JS.Promise<Browser.Types.ServiceWorkerRegistration>
    abstract getRegistration: ?scope: string -> Fable.Core.JS.Promise<Browser.Types.ServiceWorkerRegistration>
    abstract getRegistrations: unit -> Fable.Core.JS.Promise<Browser.Types.ServiceWorkerRegistration[]>
    abstract startMessages: unit -> unit


[<Proxy("Browser.Worker, Browser.Worker")>]
module WorkerProxy =
    let [<Inline>] Worker: Browser.Types.WorkerConstructor = jsNative
