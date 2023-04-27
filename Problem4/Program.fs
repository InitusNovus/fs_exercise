open StringUtil

let rec groupElementsHelper (n:int) (a:List<_>) (b:List<List<_>>) =
    let isLongerThanN = List.length a > n
    match isLongerThanN with
    | false -> 
        List.concat [ b; [a] ]
    | true ->
        List.concat [ b; [a[0 .. (n - 1)]]]
        |> groupElementsHelper n a[n .. (a.Length - 1)]

let groupElements n a =
    groupElementsHelper n a []


[<EntryPoint>]
let main argv =
    printf "Enter the array of the array of int: "
    let input = System.Console.ReadLine()
    let testList = 
        input
        |> String.split ' '
        |> Array.map (int)
        |> Array.toList
    groupElements 6 testList
    |> printfn "%A"
    0

