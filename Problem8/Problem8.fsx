let flatten lst = 
    let rec innerLoop lst res = 
        match lst with
        | [] -> res 
        | head :: tail ->
            res @ head |> innerLoop tail    //@ is an operator for List.append
    innerLoop lst []

let testNestedList = [[1; 2]; [3; 4; 5]; [6]; []; [7; 8; 9]]

let stopWatch1 = System.Diagnostics.Stopwatch.StartNew()
printfn "%A" (flatten testNestedList)
stopWatch1.Stop()
printfn "%f" stopWatch1.Elapsed.TotalMilliseconds

let flattenBetter lst = 
    let rec innerLoop lst resRev = 
        match lst with
        | [] -> resRev |> List.rev
        | head :: tail ->
            head |> List.fold (fun acc x -> x :: acc) resRev
            |> innerLoop tail
    innerLoop lst []

let stopWatch2 = System.Diagnostics.Stopwatch.StartNew()
printfn "%A" (flattenBetter testNestedList)
stopWatch2.Stop()
printfn "%f" stopWatch2.Elapsed.TotalMilliseconds