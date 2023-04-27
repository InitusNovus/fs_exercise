#nowarn "57"

module Person =
    type person = 
      { FirstName: string
        LastName: string
        Age: uint }

    let createPerson firstName lastName age = 
        { FirstName = firstName
          LastName = lastName
          Age = age }

    let fullName (person:person):string = 
        sprintf "%s %s" person.FirstName person.LastName
    
    let adultAge = 18u

    let isAdult person =
        person.Age >= adultAge

open System
open StringUtil
open Person

[<EntryPoint>]
let main argv = 
    printf "Enter the name of the person: "
    let inputName = Console.ReadLine()
    let nameWithMiddle =
        inputName 
        |> String.split ' '
        |> Array.toList
    let name = [ nameWithMiddle[0]; nameWithMiddle[^0] ]
    printf "Enter the age of %s %s: " name[0] name[1]
    let inputAge = Console.ReadLine()
    let age = 
        inputAge
        |> String.split ' '
        |> Array.map (uint)
        |> Array.head
    let thePerson = createPerson name[0] name[1] age
    let thePersonIsAdult = isAdult thePerson
    match thePersonIsAdult with
    | true -> 
        thePerson
        |> fullName 
        |> printfn "%s is an adult."
    | false ->
        thePerson
        |> fullName 
        |> printfn "%s is not an adult."
    0