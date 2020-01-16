// Learn more about F# at http://fsharp.org

//
[<EntryPoint>]
let main argv =

   // printfn "Hello World from F#!";
    let lists = [[0;1;1];[3;2];[];[5]]

    let revList list = list |> List.map List.rev 
   // revList |> List.iter (printfn "%i")
    printfn "%A" revList 


  // printfn "%d" revList

  // f# tutorial on List
   (* let list_items() =
      let list1 = [1;2;3;4]
      list1 |> List.iter (printfn "Num : %i")
      printfn "%A" list1

      let list2 = 5::6::7::[]
      printfn "%A" list2 

      let list3 = [1..5]
      let list4 =['a'..'g']
      printfn "%A" list4

      let list5 = List.init 5 (fun i -> i * 2)
      printfn "%A" list5
    list_items()
    Console.ReadKey() |> ignore *)

0// return an integer exit code
