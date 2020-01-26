// Learn more about F# at http://fsharp.org

open System
//problem set practice  # 16

// this is my first approach but obiviously didnt work so had to think of
// a more long but only way to do it simple. 
(*let (.+) (a,b) (c,d) = ((a*c)/(a*d))+((b*c)/(b*d))

let (.+) (1,2)(1,3)  *)


//let (.+) (a,b)(c,d)
//let a,b,c,d = 1.0,2.0,2.0,3.0
// this is the second attempt but just keep ending up with 7 so 

(*let (.+) (a,b)(c,d) = 
    //multiply numerators
    let temp1 = (a*d) + (b*c)
    //multiply denominators
    let temp2 = (b*d)

    let rec GCD  (i,j) = 
        if i = j then i
        else if i > j then GCD(i-j, j)
        else GCD(i,j-i)
    // finction call to find the greates common divisor
    let temp3 = GCD(temp1,temp2)
    printfn "the answer is %i" (temp1/temp3),(temp2/temp3);;
//let answer = (1,2) (.+) (2,3)
let answer = (.+)(1,2)(2,3);;
printfn "this is the newest list %A" answer *)

// problem 17

// function to reverse a list of lists remember you cant .rev an empty list
let revList xs = List.map (fun x -> List.rev x) xs;;

  let reverseList() =

    let myList = [[0;1;1];[3;2];[];[5]]
    printfn "Original list is %A" myList;;

    let reverseOrder = revList [[0;1;1];[3;2];[];[5]]
    printfn "Reverse of that list is %A" reverseOrder;;

  reverseList();; 

// problem 18

// interleaving sub list
let rec interleave = function   
    |([], ys) -> ys
    |(xs, []) -> xs
    |(x::xs, y::ys) -> x :: y :: interleave (xs,ys)
    
//printfn "this is the interleave %A" 
let interList = interleave ([1;2;3],[4;5;6]) 
printfn "interleave list %A" interList 

// problem 19

// cutting even list in half
// Function to cut a list where the first list is size n.
let gencut (n, list) = 
    let rec aux = function
        | 0, xs, ys -> (List.rev xs,ys) //must return xs reversed since you are adding the head of ys to the beginning of the list each time.
        | n, xs, [] -> (xs, [])
        | n, xs, ys -> aux(n-1, List.head ys :: xs, List.tail ys)
    aux (n, [], list)
let cut list = 
    let n = (List.length list)/2
    ///gencut(n,list)
    let newList = gencut(n,list)
    printfn "the new list is %A" newList;; 

    //////////////////////////////////
    // second attempt
    //let reverseOrder = revList [[0;1;1];[3;2];[];[5]]
   // let gencutdata = ([1;2;3],[4;5;6])
    