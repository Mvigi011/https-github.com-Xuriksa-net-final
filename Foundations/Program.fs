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
(* let listFunction()=
    let rList = [10;8;4]
    let rlist2 = List.map(fun x -> x / 2) rList

    printfn "doulbe the list elements: %A" rlist2

    [11;12;13;14]
    |> List.filter(fun a -> (a % 2)= 0)
    |> List.map (fun a -> a * 3)
    |> printfn "Even triples : %A"

    let multiFunc x = x * 5
    let addFunc y = y + 5

    let multiAdd = multiFunc >> addFunc 
    let addMulti = multiFunc << addFunc

    printfn " multil and add : %i" (multiAdd 5)
    printfn " multil and add : %i" (addMulti 5) 

listFunction()
Console.ReadKey() |> ignore *)

// example 5 


(* let mathOperation() =
    let number = 2
    printfn "Type : %A" (number.GetType())
    printfn "A float : %.2f" (float number)
    printfn "A Int : %i" (int 3.14)
mathOperation()

Console.ReadKey() |>  *)

// example 6

(* let stringManipulation()=
    let str = "Hello world" 
    let str2 = @"I ignore back slash"
    let str3 = """ " doesnt affect quotes" """
    let str4 = str + " " + str2

    printfn "Length of the phrase : %i" (String.length str4)

    printfn "%c" str.[1]

    printfn "1st element : %s" (str.[0..5])

    let upperStr = String.collect(fun c -> sprintf"%c,"  c) "Commas"
    printfn "Commas : %s " upperStr 

    printfn "Any upper : %b" (String.exists (fun c -> Char.IsUpper(c))str)

    printfn "Number : %b" (String.forall (fun c -> Char.IsDigit(c)) "1234")

    let string1 = String.init 10(fun i -> i.ToString())
    printfn "numbers : %s" string1
    String.iter(fun c-> printfn"%c" c) "print me"

stringManipulation()
Console.ReadKey() |> ignore *)

//example 7 
(* let loopPrac() =
    let magicNumber = "7"
    let mutable guess = ""
    
    while not (magicNumber.Equals(guess)) do
        printf "guess number "
        guess <- Console.ReadLine()
    printfn "you guessed it"
loopPrac()
Console.ReadKey() |> ignore *)

let loopPrac() =
   for i = 1 to 10 do
        printfn "%i" i

   for i =10 downto 1 do
        printfn "%i" i

   for i in [1..10] do
        printfn "%i" i

   [1..10] |> List.iter(printfn "Num: %i")

   let addSum = List.reduce (+) [1..3]
   printfn "product : %i" addSum

loopPrac()
Console.ReadKey() |> ignore