- title : How I learned to love Functional Programming
- description : Introduction to F#
- author : Peter Veres
- theme : night
- transition : default

***

### ![image](images/iHearFsharp1.png)

*** 

### FP envy

* Generics
* LINQ
* Async
* Tuples
* Pattern Matching

"I want what they have!"

***

> Functional Programming is great

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
    check // val check : bool = true

***

### Libraries

***

### Resources

* Docs

* Books

* Slack

* Videos

*** 

### Show me the code
![whatever](images/fsharp256.png)

***