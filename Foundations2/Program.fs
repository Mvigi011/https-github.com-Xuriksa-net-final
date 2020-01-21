// Learn more about F# at http://fsharp.org

open System
// this condition function utilizes the basic version of if else statements, which can be interpreted as switch cases
// the "grade2" function is called a match and guard statement where it works like the if/else or switch cases like java
(* let conditions() = 
    let year = 10
    if year < 7 then
        printfn "elementary"
    elif year = 7 then
        printfn "3rd grade"
    elif (year > 7) && (year <= 18) then
        let grade = year-5
        printfn " Go to grade %i" grade
    else 
        printfn "time for college"

    let gpa = 3.5
    let income = 30000

    printfn "College financial aid : %b" ((gpa >= 3.0 ) || (income <=25000))
    printfn "Not true : %b" (not true)

    let grade2: string = 
        match year with
        | year when year < 5 -> "Preschool"
        | 5 -> "Kindergarten"
        | year when ((year > 5) && (year <= 18 )) -> (year - 5).ToString()
        | _ -> "College"

    printfn "grrade2 : %s" grade2

conditions()

Console.ReadKey() |> ignore *)
