// Learn more about F# at http://fsharp.org

open System

let map_prac() =
    //
    let cust =
        Map.empty.
            Add("mike", 300.57).
            Add("matt", 45.67)
    printfn " # of customers %i " cust.Count

    let customer = cust.TryFind "mike"
    match customer with
    | Some x -> printfn "bank account : %.2f" x
    | None -> printfn "account not found"

    printfn "customers : %A" cust

    if cust.ContainsKey "mike" then 
        printfn "mike is in database"
    printfn "mikes account : %.2f" cust.["mike"]
    let cust2 = Map.remove "matt" cust
    printfn "# of customers %i " cust2.Count


map_prac()
Console.ReadKey() |> ignore



(*let seq_prac() =

    let seq1 = seq {1..110}
    let seq2 = seq {0.. 2 .. 60}
    let seq3 = seq {60 .. 1}
    printfn "%A" seq2

    Seq.toList seq2 |> List.iter (printfn "Num : %i")

    let is_prime n =
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2
            // yield is gonna put it into the sequence
    let prime_seq = seq { for n in 1..500 do if is_prime n then yield n}
    
    printfn "%A" prime_seq

    Seq.toList prime_seq |> List.iter (printfn "Prime : %i")

seq_prac() 
Console.ReadKey() |> ignore*)






(*type player = 
    {Name : string;
    PPG : float}

let database() =
    let wade = {Name = "Dwayne Wade"; PPG = 27.85}
    printfn "%s got injured so points reduction: %.2f  " wade.Name wade.PPG
database()
Console.ReadKey() |> ignore *)

(*let tuple_prac() =

    let mean (a,b,c,d) : float = 
        let sum = a + b + c + d
        sum / 4.0

    printfn "Mean : %f" (mean (10.0, 11.0, 12.0, 13.0))

    let data = ("Mike", 22 , 12.5)

    let (name, age, ppg) = data

    printfn "Name : %s" name

tuple_prac()
Console.ReadKey() |> ignore*)

(*let suggestionsItems() =
    
    let division x y = 
        match y with
        | 0 -> None
        | _ -> Some(x,y)
    if (division 6 0).IsSome then
        printfn "6 / 0 = %A" ((division 6 0).Value)
    elif (division 6 0).IsNone then
        printfn "Can't Divide by Zero"
    else
        printfn "actions made"
suggestionsItems()
Console.ReadKey() |> ignore*)

(*type emotion =
    |happy = 0
    |afraid = 1
    |sorrow = 2

let enum_items()=
    let myFeeling = emotion.happy

    match myFeeling with
    | happy -> printfn "I am happy"
    | afraid -> printfn "I am afraid"
    | sorrow -> printfn "I am feeling sorrow"

enum_items() 
Console.ReadKey() |> ignore*)
