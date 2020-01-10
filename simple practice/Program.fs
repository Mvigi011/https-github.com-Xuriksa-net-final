// Learn more about F# at http://fsharp.org

//open System

module Program




[<EntryPoint>]
let main argv =
   // printfn "Hello World from F#!"
    printfn "Arguments: %A" argv

   // PracticeClass.Problem1.test()
    PracticeClass.Problem2.test()


    //let input = System.Console.ReadLine()
    // or you can use the PIPE operator and use IGNORE as a void operation where it takes in a parameter
    //and it will not return anything.
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code
