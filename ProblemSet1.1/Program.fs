// Learn more about F# at http://fsharp.org

open System

// problem 20 
// this next problem is shuffling to get back to the original number

let shuffleDeck xs =
 let deck = (List.length xs) / 2
 xs
 |> List.mapi (fun i x->(if i<deck then i * 2 else ((i-deck) * 2) + 1), x)
 |> List.sortBy fst
 |> List.map snd

let Count1 n =
 let xs = [1..n]
 let rec spin count ys =
   if xs=ys then count
   else ys |> shuffleDeck |> spin (count + 1)
 xs |> shuffleDeck |> spin 1

[ 8; 24; 52] |> List.iter (fun n->n |> Count1 |> printfn "input : %d ----> output %d" n)

// problem 21 uncurried function with cartesian product
//skip

//Problem 22
let rec powerSet =
   //Start the definition of the function.
   function
 //case 1 for empty list
   | [] -> [[]]
   // use the function recursively for each element of the list of lists
   | (h::t) ->
      let ht = powerSet t
      List.map (fun t' -> h::t') ht @ ht

let printPowSet = powerSet [1;2;3]
//Print the powerset.
printfn "%A" printPowSet;;

// Problem 23
//skip
// Problem 24 sorting

//let bubbleSortArr = bubbleSortArray[3;1;4;1;5;9;2;6;5]
//printfn "%A" bubbleSortArr *)
//

// pronblem 24
(* cant figure out*)
// problem 25
(* 
E -> E+T | E-T | T

// T -> T*P | T/P | P

P -> F^P | F

F -> i | (E) *)