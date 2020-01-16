// Learn more about F# at http://fsharp.org

open System
//example 1
(*let hello() = 
       printf "What is your name? "
       
       let name = Console.ReadLine()

       printfn "Hello %s" name
hello()
Console.ReadKey() |> ignore*)

//example 2
(*let binding() =
        let mutable weight = 165
        weight <- 160

        printfn "weight: %i" weight

        let changeWeight = ref 10
        changeWeight := 5

        printfn "Change: %i" ! changeWeight

binding()

Console.ReadKey() |> ignore *)

//example 3
(*let functionFind() =

    let retrieveSum (x : int, y : int) : int = x + y
    printfn "4 + 6 = %i" (retrieveSum(4,6))

functionFind()
Console.ReadKey() |> ignore *)

//recursion

(*let funcRecursion() =
    let rec factorial x =
        if x < 1 then 1
        else x * factorial (x-1)
    printfn "Factorial 4 : %i" (factorial 4)

funcRecursion()
Console.ReadKey() |> ignore *)

//example 4
let listFunction()=
    let rList = [10;8;4]
    let rlist2 = List.map(fun x -> x / 2) rList

    printfn "doulbe the list elements: %A" rlist2

listFunction()
Console.ReadKey() |> ignore