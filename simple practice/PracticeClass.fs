module PracticeClass

module Problem1 =
    let pred c = c-1

    let test () =
        // the %d means that it takes an integer value
        printfn "%d" (5 + 3)

        printfn "pred f 15 is %d" (pred 15)
        ()

module Problem2 =
        let head = function
        | [] -> failwith "empty list does not have a head"
        | x::xs -> x

        let test () =
            // %A = takes in any objects
            //printfn "the head of the [] is %d" (head [])
            printfn "the head of the [1;2;3] is %d" (head [1;2;3])
            printfn "the head of the [1] is %d" (head [1])
            ()