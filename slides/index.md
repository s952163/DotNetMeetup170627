- title : How I learned to love Functional Programming
- description : Introduction to F#
- author : Peter Veres
- theme : night
- transition : default

***

### ![image](images/iHearFsharp1.png)

> Third most loved language in the SO 2016 Developer Survey. 

*** 

#### FP Envy
!["FP Envy"](https://media.giphy.com/media/OcsIqNQaWLCBa/giphy.gif)  

* Generics
* LINQ
* Async
* Tuples
* Pattern Matching

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

### What?
![Huh?](https://media3.giphy.com/media/5wWf7H89PisM6An8UAU/giphy.gif)

* No nulls
* Immutability by default
* Very good type inference with white-space based syntax
* Light-weight type-system suitable for domain/type driven design
* REPL
* Great Visual Studio and VSCode integrations


***

### Libraries/Tools

* All the .NET BCL and 
* Some personal picks
    - [Paket](https://fsprojects.github.io/Paket/index.html)
    - [Fake](http://fsharp.github.io/FAKE/)
    - [Expecto](https://github.com/haf/expecto)
    - [FSharp.Data](http://fsharp.github.io/FSharp.Data/) and [SQLProvider](http://fsprojects.github.io/SQLProvider/)
    - [MathNet.Numerics](https://numerics.mathdotnet.com/)
    - [Gjallarhorn](http://reedcopsey.github.io/Gjallarhorn/)
    - [Oxyplot](http://www.oxyplot.org/)
    - [Argu](http://fsprojects.github.io/Argu/) and [CommandLine](https://github.com/gsscoder/commandline)
    - [BenchmarkDotNet](http://benchmarkdotnet.org/)
    - [FileHelpers](http://www.filehelpers.net/)


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