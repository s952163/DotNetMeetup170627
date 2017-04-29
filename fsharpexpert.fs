open System  
open System.Windows.Forms


type RandomTicker(approxInterval) =    
    let timer = new Timer()    
    let rnd = new System.Random(99)    
    let tickEvent = new Event<int> ()

    let chooseInterval() : int = 
        approxInterval + approxInterval / 4 - rnd.Next(approxInterval / 2) 
    
    do timer.Interval <- chooseInterval() 

    do timer.Tick.Add(fun args ->  
        let interval = chooseInterval() 
        tickEvent.Trigger interval; 
        timer.Interval <- interval) 

    member x.RandomTick = tickEvent.Publish 
    member x.Start() = timer.Start() 
    member x.Stop() = timer.Stop() 
    interface IDisposable with member x.Dispose() = timer.Dispose()

let rt = new RandomTicker(1000);;
rt.RandomTick.Add(fun nextInterval -> printfn "Tick, next = %A" nextInterval);;
rt.Start() 
rt.Stop()

let xs = [1..10]
xs
|> List.filter (fun x -> x % 2 = 0)
|> List.map (fun x -> x * 2)

let filterMap f m = (List.filter f >> List.map m)
xs 
|> filterMap (fun x -> x % 2 = 0) (fun x -> x * 2)

xs
|> List.choose (fun x -> 
                match x with 
                | x when x % 2 = 0 -> Some (x * 2)
                | _ -> None )


xs
|> List.choose (function  
                | x when x % 2 = 0 -> Some (x * 2)
                | _ -> None )