open System
let hello() = 
       printf "What is your name? "
       
       let name = Console.ReadLine()

       printfn "Hello %s" name
hello()
Console.ReadKey() |> ignore
