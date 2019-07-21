// Learn more about F# at http://fsharp.org

open System

let expandedForm (num: int64) : string = 
  let seq = string num |> List.ofSeq 
  let length = Seq.length seq
  seq
    |> Seq.mapi(fun i x ->
        if x <> '0' then string x + String.replicate (length-i-1) "0" + " + " else "")
    |> String.Concat
    |> function result -> result.[0..result.Length-4]
  
//let filterList =
//    let limit = Console.ReadLine() |> int
//    let read _ = Console.ReadLine()
//    let isValid = function null -> false | _ -> true
//    Seq.initInfinite read 
//    |> Seq.takeWhile isValid
//    |> Seq.filter (fun x -> x |> int < limit)
//    |> Seq.iter (fun x -> Console.WriteLine(x))
//100

let getNumberFromString (s: String) : int =
  s
    |> List.ofSeq
    |> Seq.filter (fun (x : char) ->  fst (Double.TryParse(string x)))
    |> String.Concat
    |> function x -> int x
    

let rotate (strng: String) =
    strng
        |> Seq.toList
        |> fun x -> x.[x.Length-1] :: x.[0..x.Length-2]
        |> List.toArray
        |> fun x -> String x

let containAllRots strng a =
    seq { 1 .. String.length strng }
        |> Seq.iter (fun -> rotate 

[<EntryPoint>]
let main argv =
    //let res = expandedForm(505700L)
    //let res = getNumberFromString("aaa3")
    //let res = containAllRots "tibi" ["tibi"; "itib"; "biti"; "ibit"]
    let res = rotate("tibi") |> fun x -> rotate(x)
    Console.WriteLine(res)
    0
