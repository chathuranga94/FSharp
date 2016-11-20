module MathsModule

open System

let square x = x * x        // ALT + ENTER for F# Interactive   (use ';;')
let negative x = x * -1
let print x = printfn "The number is: %d" x

let chainFunction1 x =
    print (negative (square 12))
let chainFunction2 x =
    x |> square |> negative |> print
let compositeFunction =
    square >> negative >> print


let rec fact x =
    if x < 1 then 1
    else x * fact (x - 1)

let rec even x =
   if x = 0 then true 
   else odd (x - 1)

and odd x =
   if x = 1 then true 
   else even (x - 1)

let isOdd x = x % 2 <> 0  
//let read = Console.ReadLine()

[<EntryPoint>]
let main argv = 
    printfn "%d squared is: %d!" 12 (square 12)     //  sprintf
    (print 10)

    chainFunction1 12
    chainFunction2 10

    printfn "Recursive Functions: Factorial %d IsEven %b" (fact 5) (even 10)

    let name = Console.ReadLine()
    Console.Write("Hello, {0}", name)
    0 // return an integer exit code


(*
        open System

        let main() =
            Console.Write("What's your name? ")
            let name = Console.ReadLine()
            Console.Write("Hello, {0}", name)
    
        main()
*)