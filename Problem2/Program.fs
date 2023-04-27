let squresOfOdds numbers =
    numbers 
    |> List.filter(fun x -> x % 2 = 1)
    |> List.map(fun x -> x * x)
    
[<EntryPoint>]
let main argv =
    let testNumbers = [ 1 .. 9 ]
    testNumbers
    |>squresOfOdds
    |> printfn "%A"
    0