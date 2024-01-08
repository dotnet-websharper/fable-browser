﻿namespace rec Browser.Types

#if JAVASCRIPT
open WebSharper
[<AutoOpen;WebSharper.JavaScript>]
module internal JS =
    type Promise<'t> = WebSharper.JavaScript.Promise<'t>
#else
open Fable.Core
#endif

#if !JAVASCRIPT
[<Erase>]
#endif
type IDBRequestSource =
    | Index of IDBIndex
    | ObjectStore of IDBObjectStore
    | Cursor of IDBCursor

#if !JAVASCRIPT
[<StringEnum>]
#endif
type IDBRequestReadyState =
    | Pending
    | Done

#if !JAVASCRIPT
[<StringEnum>]
#endif
type IDBTransactionMode =
    | Readonly
    | Readwrite
    | Versionchange

#if !JAVASCRIPT
[<StringEnum>]
#endif
type IDBTransactionDuarability =
    | Strict
    | Relaxed
    | Default

#if !JAVASCRIPT
[<StringEnum>]
#endif
type IDBCursorDirection =
    | Next
    | Nextunique
    | Prev
    | Prevunique

type [<AllowNullLiteral>] DatabasesType =
    abstract name: string
    abstract version: int64
#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBIndex =
    abstract isAutoLocale: bool with get
    abstract locale: string with get
    abstract name: string with get
    abstract objectStore: IDBObjectStore with get
    abstract keyPath: obj with get
    abstract multiEntry: bool with get
    abstract unique: bool with get

    abstract count: ?key: obj -> IDBRequest
    abstract get: ?key: obj -> IDBRequest
    abstract getKey: ?key: obj -> IDBRequest
    abstract getAll: ?query: obj * ?count: int -> IDBRequest
    abstract getAllKeys: ?query: obj * ?count: int -> IDBRequest
    abstract openCursor: ?range: obj * ?direction: IDBCursorDirection -> IDBRequest
    abstract openKeyCursor: ?range: obj * ?direction: IDBCursorDirection -> IDBRequest

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBVersionChangeEvent =
    inherit Event

    abstract oldVersion: int64 with get
    abstract newVersion: int64 with get

#if !JAVASCRIPT
[<Global>]
#endif
type [<AbstractClass; AllowNullLiteral>] IDBKeyRange =
    abstract lower: obj with get
    abstract upper: obj with get
    abstract lowerOpen: bool with get
    abstract upperOpen: bool with get
    abstract includes: obj -> bool

    #if JAVASCRIPT
    [<Inline("IDBKeyRange.bound($lower,$upper,$lowerOpen,$upperOpen)")>]
    #else
    [<Emit("IDBKeyRange.bound($0, $1, $2, $3)")>]
    #endif
    static member bound(lower: obj, upper: obj, ?lowerOpen: bool, ?upperOpen: bool) = jsNative<IDBKeyRange>

    #if JAVASCRIPT
    [<Inline("IDBKeyRange.only($only)")>]
    #else
    [<Emit("IDBKeyRange.only($0)")>]
    #endif
    static member only(only: obj) = jsNative<IDBKeyRange>

    #if JAVASCRIPT
    [<Inline("IDBKeyRange.lowerBound($lower,$1)")>]
    #else
    [<Emit("IDBKeyRange.lowerBound($0, $1)")>]
    #endif
    static member lowerBound(lower: obj, ?``open``: bool) = jsNative<IDBKeyRange>

    #if JAVASCRIPT
    [<Inline("IDBKeyRange.upperBound($upper,$1)")>]
    #else
    [<Emit("IDBKeyRange.upperBound($0, $1)")>]
    #endif
    static member upperBound(upper: obj, ?``open``: bool) = jsNative<IDBKeyRange>

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBCursor =
    abstract source: IDBObjectStore with get
    abstract direction: IDBCursorDirection with get
    abstract key: obj option with get
    abstract primaryKey: obj option with get
    abstract request: IDBRequest with get

    abstract advance: count: int -> unit
    abstract ``continue``: ?key: obj -> unit
    abstract continuePrimaryKey: key: obj * primaryKey: obj -> unit
    abstract delete: unit -> IDBRequest
    abstract update: value: obj -> IDBRequest

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBCursorWithValue =
    inherit IDBCursor

    abstract value: obj option with get

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBTransaction =
    inherit EventTarget

    abstract db: IDBDatabase with get
    abstract durability: IDBTransactionDuarability with get
    abstract error: DOMException with get
    abstract mode: IDBTransactionMode with get
    abstract objectStoreNames: DOMStringList with get

    abstract abort: unit -> unit
    abstract objectStore: name: string -> IDBObjectStore
    abstract commit: unit -> unit

    abstract oncomplete: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set
    abstract onabort: (Event -> unit) with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBRequest =
    inherit EventTarget

    abstract error: DOMException with get
    abstract result: obj option with get
    abstract source: IDBRequestSource option with get
    abstract readyState: IDBRequestReadyState with get
    abstract transaction: IDBTransaction with get

    abstract onerror: (Event -> unit) with get, set
    abstract onsuccess: (Event -> unit) with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBCreateIndexOptions =
    abstract unique: bool with get, set
    abstract multiEntry: bool with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBObjectStore =
    abstract indexNames: DOMStringList with get
    abstract keyPath: obj with get
    abstract name: string with get
    abstract transaction: IDBTransaction with get
    abstract autoIncrement: bool with get

    abstract add: value: obj * ?key: obj -> IDBRequest
    abstract clear: unit -> IDBRequest
    abstract count: ?query: IDBKeyRange -> IDBRequest
    abstract createIndex: indexName: string * keyPath: string * ?options: IDBCreateIndexOptions -> IDBRequest
    abstract delete: key: obj -> IDBRequest
    abstract deleteIndex: string -> IDBRequest
    abstract get: key: obj -> IDBRequest
    abstract getKey: key: obj -> IDBRequest
    abstract getAll: ?query: IDBKeyRange * ?count: int -> IDBRequest
    abstract getAllKeys: ?query: IDBKeyRange * ?count: int -> IDBRequest
    abstract index: string -> IDBIndex
    abstract openCursor: ?range: IDBKeyRange * ?direction: IDBCursorDirection -> IDBRequest
    abstract openKeyCursor: ?range: IDBKeyRange * ?direction: IDBCursorDirection -> IDBRequest
    abstract put: item: obj * ?key: obj -> IDBRequest

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBCreateStoreOptions =
    abstract keyPath: obj with get, set
    abstract autoIncrement: bool with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBTransactionOptions =
    abstract durability: IDBTransactionDuarability with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBDatabase =
    inherit EventTarget

    abstract name: string with get
    abstract version: int64 with get
    abstract objectStoreNames: DOMStringList with get

    abstract close: unit -> unit
    abstract createObjectStore: name: string * ?options: IDBCreateStoreOptions -> IDBObjectStore
    abstract deleteObjectStore: name: string -> unit
    abstract transaction: storeNames: #seq<string> * ?mode: IDBTransactionMode * ?options: IDBTransactionOptions -> IDBTransaction
    abstract transaction: storeNames: string * ?mode: IDBTransactionMode * ?options: IDBTransactionOptions -> IDBTransaction

    abstract onclose: (Event -> unit) with get, set
    abstract onversionchange: (Event -> unit) with get, set
    abstract onabort: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBOpenDBRequest =
    inherit IDBRequest

    abstract blocked: (Event -> unit) with get, set
    abstract onupgradeneeded: (IDBVersionChangeEvent -> unit) with get, set

#if !JAVASCRIPT
[<Global>]
#endif
type [<AllowNullLiteral>] IDBFactory =
    abstract ``open``: name: string * ?version: int -> IDBOpenDBRequest
    abstract cmp: first: 'T * second: 'T -> int
    abstract deleteDatabase: name: string -> IDBOpenDBRequest
    abstract databases: unit -> JS.Promise<DatabasesType array>
