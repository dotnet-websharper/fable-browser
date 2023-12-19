module private Proxies
open WebSharper

[<AutoOpen;InternalProxy("Fable.Core.Util, Fable.Core")>]
module UtilProxies =
    let [<Inline>] jsNative<'a> = Unchecked.defaultof<'a>

type [<Proxy(typeof<Browser.Types.Performance>)>] PerformanceProxy =
    [<Inline>] abstract clearMarks: ?markName: string -> unit
    [<Inline>] abstract clearMeasures: ?measureName: string -> unit
    [<Inline>] abstract clearResourceTimings: unit -> unit
    [<Inline>] abstract getEntries: unit -> obj
    [<Inline>] abstract getEntriesByName: name: string * ?entryType: string -> obj
    [<Inline>] abstract getEntriesByType: entryType: string -> obj
    [<Inline>] abstract mark: markName: string -> unit
    [<Inline>] abstract ``measure``: measureName: string * ?startMarkName: string * ?endMarkName: string -> unit
    [<Inline>] abstract now: unit -> float
    [<Inline>] abstract setResourceTimingBufferSize: maxSize: float -> unit
    [<Inline>] abstract toJSON: unit -> obj


[<AutoOpen>]
module Performance =
    let [<Inline>] performance: Browser.Types.Performance = jsNative
