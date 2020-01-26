// Learn more about F# at http://fsharp.org

open System

// problem 20 
// this next problem is shuffling to get back to the original number

let perfectShuffle xs =
 let h = (List.length xs) / 2
 xs
 |> List.mapi (fun i x->(if i<h then i * 2 else ((i-h) * 2) + 1), x)
 |> List.sortBy fst
 |> List.map snd

let orderCount n =
 let xs = [1..n]
 let rec spin count ys =
   if xs=ys then count
   else ys |> perfectShuffle |> spin (count + 1)
 xs |> perfectShuffle |> spin 1

[ 8; 24; 52] |> List.iter (fun n->n |> orderCount |> printfn "input : %d ----> output %d" n)

// problem 21 uncurried function with cartesian product
let rec cartesian = function
    | (xs, []) -> []
    | (xs, y::ys) -> List.map (fun x -> (x, y)) xs @ cartesian (xs, ys) ;;
printfn " the cartesian product is %A" cartesian(["a"; "b"; "c"] [1; 2])