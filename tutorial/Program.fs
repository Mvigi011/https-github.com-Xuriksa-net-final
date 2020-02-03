// Learn more about F# at http://fsharp.org

open System
//short and simple tips and tricks with list
let list_items()=

    let list1 = [1;2;3;4;5]

    list1 |> List.iter (printfn "Num : %i")
    printfn "%A" list1

    let list2 = 6::7::8::[]
    printfn "%A" list2
    
    let list3 = [1..5]
    let list4 = ['a'..'g']
    printfn "%A" list4

    let list5 = List.init 5 (fun i -> i * 2)
    printfn "%A" list5

    let list6 = [ for a in 1..5 do yield (a * a)]
    printfn "%A" list6

    let list7 = [for a in 1..20 do if a % 2 = 0 then yield a]
    printfn "%A" list7
    // a yield bang creates multiple list for each item and merges to one list
    let list8 = [for a in 1..3 do yield! [a..a+2]]
    printfn "%A" list8

    printfn " Length : %i" list8.Length
    printfn "Empty : %b" list8.IsEmpty
    printfn "index 2 %c" (list4.Item(2))
    printfn "head : %c" (list4.Head)
    printfn "tail : %A" (list4.Tail)

    let list9 = list3 |> List.filter (fun x -> x % 2 = 0)
    
    let list10 = list9 |> List.map (fun x -> (x * x))

    printfn "sorted : %A" (List.sort [5;4;3])

    printfn "Sum : %i" (List.fold (fun sum elem -> sum + elem) 0 [1;2;3]) 

list_items()

Console.ReadKey() |> ignore
