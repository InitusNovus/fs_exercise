module OptionUtil

let ( >>= ) f opt =
    f |> Option.bind opt

let ( >== ) f opt =
    f |> Option.map opt
let tee f = 
    fun x -> 
        f x
        x

module Option =
    let tryCatch f x =
        try 
            f x |> Some
        with
        | ex ->
            eprintfn "%s" ex.Message
            None
    
