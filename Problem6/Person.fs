module Person 
    
open StringUtil

type person = 
    { FirstName: string
      LastName: string
      Age: uint }

type personInput = 
    | InputList of string list
    | InputTuple of string * string * uint

let createPerson (input:personInput) = 
    match input with
    | InputList [ firstName; lastName; age] ->
        Some(
            { FirstName = firstName
              LastName = lastName
              Age = uint age }
        )
    | InputTuple ( firstName, lastName, age ) ->
        Some(
            { FirstName = firstName
              LastName = lastName
              Age = age }
        )
    | _ -> 
        eprintfn "Person.createPerson: Wrong Input Type"
        None

let fullName (person:person) = 
    sprintf "%s %s" person.FirstName person.LastName

let adultAge = 18u

let isAdult person =
    person.Age >= adultAge

let toString person = 
    sprintf "%s,%s,%u" person.FirstName person.LastName person.Age

let fromString str = 
    str 
    |> String.split ','
    |> Seq.toList
    |> InputList
    |> createPerson