module App

open Fable.Core
open Fable.Import
open Fable.Import
open Fable.Core

[<Emit("('serviceWorker' in navigator)")>]
let hasSWSupport () = jsNative

if hasSWSupport() then
    Browser.window.addEventListener_load(fun ev -> 
        Browser.navigator.serviceWorker.register("/sw.js")
        |> Promise.map (fun registration ->
            printfn "registration successful %A" registration
            Browser.navigator.serviceWorker.controller
            |> Option.iter(fun ctr ->
                JS.setTimeout (fun () -> 
                    ctr.postMessage("hello from page")
                ) 2000
                |> ignore
            )
        )
        |> Promise.catchEnd (fun err ->
            printfn "Failed to register service worker, %A" err
        )
    )

printfn "App started"
