//Implementation
let reverseList lst =
    let rec innerLoop lst res = 
        match lst with 
        | [] -> res
        | head::tail -> 
            head::res |> innerLoop tail
    innerLoop lst []

//Test
let testList =  [1; 2; 3; 4; 5]
testList |> reverseList |> (printfn "%A")

//In practice, use "List.rev."
testList |> List.rev |> (printfn "%A")