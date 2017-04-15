let nums = [1 .. 10]  
let sumx2 xs =  
    xs |> List.map (fun x -> x * x)  
       |> List.sum
let xs' = sumx2 nums

type MyRec = {
    name : string
    id : int
}

let employee1 = {name="John Doe"; id=99}
let employee2 = {name="John Doe"; id=99}
let check = employee1 = employee2