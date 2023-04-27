let isPalindrome (str:string) =
    let strInverse =
        str
        |> seq
        |> Seq.rev
        |> System.String.Concat //Why this is used?
    str = strInverse

[<EntryPoint>]
let main argv = 
    match argv with
    | [| arg |] ->
        arg
        |> isPalindrome
        |> fun x ->
            match x with
            | true -> printfn "\"%s\" is a palindrome." arg
            | false -> printfn "\"%s\" isn't a palindrom." arg
    | _ ->
        printfn "Please provide one word as argument."
    0