// Learn more about F# at http://fsharp.org

open System
let x = 4.0 + 5.6
printfn "%f" x


// problem 2
let add1Param x y = (+) 5 3

printfn "this is the number %A" add1Param

//problem 6
let  listX = [1;2;3;4]
let  listY =  5::6::7::[]
let listXY = List.map(List.head(listX @ listY))
//printfn "this is the concatination %A" List.map(List.head(listX @ listY))

//problem 7

//problem 8 
let rec foo = function
| (xs, [])    -> xs
| (xs, y::ys) -> foo (xs@[y], ys) //compiles

// problem 9
let y = [fun x -> x+1] // no 
let z = fun x -> x::[5]// int -> int list

// problem 10
let a1 = fun x y -> x+y+"." // string > string > string

// problem 11
let a2 = fun xs -> List.map (+) xs //xs:int list -> (int -> int) list


