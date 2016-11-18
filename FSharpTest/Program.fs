module MathsModule

open System

let square x = x * x        // ALT + ENTER for F# Interactive   (use ';;')
let isOdd x = x % 2 <> 0   

[<EntryPoint>]
let main argv = 
    printfn "%d squared is: %d!" 12 (square 12)     //  sprintf
    let read = Console.ReadLine()
    0 // return an integer exit code

(*
open System

let main() =
    Console.Write("What's your name? ")
    let name = Console.ReadLine()
    Console.Write("Hello, {0}", name)
    
main()
*)