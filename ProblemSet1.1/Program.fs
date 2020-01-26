// Learn more about F# at http://fsharp.org

open System

// problem 20 
// this next problem is shuffling to get back to the original number

let shuffleCards xs =
 let h = (List.length xs) / 2
 xs
 |> List.mapi (fun i x->(if i<h then i * 2 else ((i-h) * 2) + 1), x)
 |> List.sortBy fst
 |> List.map snd

let Count1 n =
 let xs = [1..n]
 let rec spin count ys =
   if xs=ys then count
   else ys |> shuffleCards |> spin (count + 1)
 xs |> shuffleCards |> spin 1

[ 8; 24; 52] |> List.iter (fun n->n |> Count1 |> printfn "input : %d ----> output %d" n)

// problem 21 uncurried function with cartesian product
//skip

//Problem 22
let rec powerSet =
   //Start the definition of the function.
   function
 //If the list is empty then return a list containing an empty list..
   | [] -> [[]]
   //Otherwise, Break the list into the subsets and call
   //the function recursively to find all the possible subsets.
   | (h::t) ->
      let ht = powerSet t
      List.map (fun t' -> h::t') ht @ ht
//Call the function powerset to obtain the powerset of a list and
//store the resultant powerset in a variable.
let printPowSet = powerSet [1;2;3]
//Print the powerset.
printfn "%A" printPowSet;;

// Problem 23
//skip
// Problem 24 sorting
(*let swap x y (arr : 'a []) =

    let temp1 = arr.[x]

    arr.[x] <- arr.[y]

    arr.[y] <- temp1

let bubbleSortArray arr =

    let rec loop (arr : 'a []) =

        let mutable swaps = 0

        for i = 0 to arr.Length - 2 do

         if arr.[i] > arr.[i+1] then

            swap i (i+1) arr

        swaps <- swaps + 1

        if swaps > 0 then loop arr else arr

    loop arr
    
let bubbleSortArr = bubbleSortArray[3;1;4;1;5;9;2;6;5]
printfn "%A" bubbleSortArr *)

// pronblem 24
(* cant figure out*)
// problem 25
(* 
E -> E+T | E-T | T

// T -> T*P | T/P | P

P -> F^P | F

F -> i | (E) *)