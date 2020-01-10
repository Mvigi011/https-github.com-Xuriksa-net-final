module SimpleClass

let mutable x = 5
x <- 15
let items = [1..5]
List.append items [6]

let prefix prefixStr baseStr =
    prefixStr + ", " + baseStr
    //prefix "Hello" "Michael"

let names = ["Michael";"John"; "Jackson"]

// this should call the list names and print Hello for each name
// here learned how the names list pipes the seqence of names and the map pretty much
// puts the work hello to each name, the map function is almost like the distributive property.
//names 
//|> Seq.map (prefix "Hello")
/////////////////////////
let prefixWithHello = prefix "Hello"
////////////////////////
let exclaim a = 
    a + "!"

let bigHello = prefixWithHello >> exclaim
// this next code from names to bigHello will add two hellos to each name, and an exclamation point after each name and "a" is the placeholder for names, the 
// map function again distributes the double hello.
    //names
    //|> Seq.map prefixWithHello
    //|> Seq.map bigHello
/////
// this is another version of the map function where "fun" will map over to each name to add a "hello" and "!" and sorts it
names
|> Seq.map(fun x -> printfn "Mapped over %s" x; bigHello x)
|> Seq.map exclaim
|> Seq.sort

let hellos
names
|> Seq.map prefixWithHello
    |> Seq.map bigHello
    |> Seq.map(fun x -> printfn "Mapped over %s" x; bigHello x)
    |> Seq.sort
//|> Seq.map exclaim
    |> Seq.iter(prinfn "%s")