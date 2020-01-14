// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    printfn "Hello World from F#!";
    let lists = [[0;1;1];[3;2];[];[5]]
    let revList list = list |> List.map List.rev  
  //  printfn "%A" revList
  //  printfn "%d" revList
    0 // return an integer exit code
