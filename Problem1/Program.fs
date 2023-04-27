let rec fibonacciHelper (n:uint) (current:uint) (next:uint) = 
    match n with
    | 0u -> current
    | _ -> fibonacciHelper (n - 1u) next (current + next) 

let fibonacci n = 
    fibonacciHelper n 0u 1u

[<EntryPoint>]
let main argv =
    fibonacci 10u
    // |> string
    // |> printfn "The 10th Finonacci number is %s."
    |> printfn "The 10th Finonacci number is %i."
    0
    