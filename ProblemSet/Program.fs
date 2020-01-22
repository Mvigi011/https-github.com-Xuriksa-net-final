// Learn more about F# at http://fsharp.org

open System
//problem set practice  # 16

// this is my first approach but obiviously didnt work so had to think of
// a more long but only way to do it simple. 
 (* let (.+) (a,b) (c,d) = ((a*c)/(a*d))+((b*c)/(b*d))

let (.+) (1,2)(1,3) *)


//let (.+) (a,b)(c,d)
//let a,b,c,d = 1.0,2.0,2.0,3.0
// this is the second attempt but just keep ending up with 7 so 

let (.+) (a,b)(c,d) = 
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
    printfn "the answer is %f" (temp1/temp3),(temp2/temp3);;
//let answer = (1,2) (.+) (2,3)
let answer = (.+)(1.0,2.0)(2.0,3.0);;
