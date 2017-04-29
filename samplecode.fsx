#r @"packages\FSharp.Data\lib\net40\FSharp.Data.dll"

open FSharp.Data
open System.IO

let nums = [1 .. 10]  
let sumx2 xs =  
    xs |> List.map (fun x -> x * x)  
       |> List.sum
let xs' = sumx2 nums

type MyRec = {
    name : string
    id : int
}

let employee1 = {MyRec.name="John Doe"; id=99}
let employee2 = {name="John Doe"; id=99}
let check = employee1 = employee2

[<Literal>]
let csvFile = @"c:\tmp\testDeedle.csv"
File.Exists csvFile

type CsvTest = CsvProvider<csvFile>
let sample = CsvTest.GetSample()
sample.Headers // val it : string [] option = Some [|"Date"; "Portfolio"; "BarraID"; "Ret"|]

let dtAndNum = 
    sample.Rows 
    |> Seq.map (fun x -> x.Date,x.Ret)
    |> Seq.take 2

printfn "%A" dtAndNum

module TestModule =
    let newfunc x =
        x + "a"

let f x (g : unit -> unit) : unit =
   printf x

