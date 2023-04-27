open System
open System.IO


let ( >>= ) f opt =
    f |> Option.bind opt

let ( >== ) f opt =
    f |> Option.map opt

module Option =
    let bindException inputFun param =
        try 
            Some(inputFun(param))
        with
        | ex ->
            eprintfn "%s" ex.Message 
            None


module FileRecord =

    let readRecords parseFun fileName= 
        Option.bindException(File.ReadLines) fileName
        >== Seq.map parseFun
        >== Seq.toList

    let writeString fileName (str:string list) = 
            try 
                File.WriteAllLines(fileName, str)
                Some fileName
            with 
            |ex ->
                eprintfn "%s" ex.Message
                None
        

open FileRecord

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

    let printValue input = 
        input |> printfn "%A"
        input

    let getInput msg = 
        printf "%s" msg
        Option.bindException Console.ReadLine ()


open ReadTextFile

[<EntryPoint>]
let main argv =
    argv |> parseArg |> ignore  //Just for test

    getInput "Enter the file to be open: " 
    >>= readRecords Person.fromString
    >== List.choose id      //Pick valuse of options in the list
    >== List.map printValue //Print each value in the list
    >== List.map Person.toString
    >== List.map printValue
    >>= writeString "PeopleWrite.csv"
    |> function
    | Some name ->
        printfn "\"%s\" has writen successfully." name
        0
    | None -> 
        eprintfn "File writing failed."
        1