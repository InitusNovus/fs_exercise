open System
open System.IO


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


module FileRecord =
    let readRecords parseFun fileName= 
        Option.tryCatch File.ReadLines fileName
        >== Seq.map parseFun
        >== Seq.toList

    let writeString fileName (str:string list) = 
        Option.tryCatch(fun _ -> File.WriteAllLines(fileName, str)) ()
        |> function
        | Some _ -> Some fileName
        | None -> None
            
        
module ReadTextFile =
    let parseArg =
        function
        | [| input: string |] ->
            Some input
        | [| |] ->
            // eprintfn "Error: No Argument"
            None
        | _ ->
            eprintfn "Error: Wrong Argument"
            None

    let getInput msg = 
        printf "%s" msg
        Option.tryCatch Console.ReadLine ()

open FileRecord
open ReadTextFile

[<EntryPoint>]
let main argv =
    argv |> parseArg |> ignore          //Just for test

    getInput "Enter the file to be open: " 
    >>= readRecords Person.fromString
    >== List.choose id                  //Pick valuse of options in the list
    >== List.map (tee (printfn "%A"))   //Print each value in the list for logging
    >== List.map Person.toString
    >== List.map (tee (printfn "%A"))   //Print each value in the list for logging
    >>= writeString "PeopleWrite.csv"
    |> function
        | Some name ->
            printfn "\"%s\" has writen successfully." name
            0
        | None -> 
            eprintfn "File writing failed."
            1