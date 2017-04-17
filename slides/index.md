- title : Makr today an easy day or How I learned to love Functional Programming
- description : Introduction to F#
- author : Peter Veres
- theme : night
- transition : default

***
## Make today an easy day! 
## ![image](images/iHearFsharp1.png)

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
* Great Visual Studio (2015/2017) and VSCode (ionide-fsharp) integration


***

### Libraries/Tools

* All the .NET BCL and 
* Some personal picks
    - [Paket](https://fsprojects.github.io/Paket/index.html): dependency management
    - [Fake](http://fsharp.github.io/FAKE/): build tool
    - [Expecto](https://github.com/haf/expecto): testing
    - [FSharp.Data](http://fsharp.github.io/FSharp.Data/) and [SQLProvider](http://fsprojects.github.io/SQLProvider/): typed data access
    - [MathNet.Numerics](https://numerics.mathdotnet.com/): numerical/statistical computations
    - [Gjallarhorn](http://reedcopsey.github.io/Gjallarhorn/): managing mutable state and signals
    - [Oxyplot](http://www.oxyplot.org/): plotting library
    - [Argu](http://fsprojects.github.io/Argu/) and [CommandLine](https://github.com/gsscoder/commandline): command line parsers
    - [BenchmarkDotNet](http://benchmarkdotnet.org/): easy micro benchmarking
    - [FileHelpers](http://www.filehelpers.net/): processing delimited files

---

### ![fake](images/fake.png)
* **Fake:** F# Make, a build tool for .NET  
* Integrated DSL in F#  
* Run tests, add assembly info, release to nuget via Paket  

### ![paket](images/paket-logo.png)  
* **Paket:** dependency manager for .NET 
* Integrated with nuget but much more reliable
* Can reference source files, github

---

## Typed representation of an arbitrary csv file in 3 lines

    [<Literal>]
    let csvFile = @"c:\tmp\testDeedle.csv"
    type CsvTest = CsvProvider<csvFile>
    let sample = CsvTest.GetSample()
    sample.Headers // val it : string [] option = Some [|"Date"; "Portfolio"; "BarraID"; "Ret"|]
    
    //val dtAndNum : seq<System.DateTime * decimal>
    let dtAndNum = 
        sample.Rows 
        |> Seq.map (fun x -> (x.Date,x.Ret))
        |> Seq.take 2

    printfn "%A" dtAndNum
    seq [(2016/10/11 00:00:00, 0.0059880M);
         (2016/10/12 00:00:00, -0.003293M)]

* SqlProvider works as a mini-ORM providing the same functionality for databases

--- 
### Argu sample
> A declarative CLI/XML parser, using Discriminated Unions to describe the parameters.  


    type Arguments =
    | [<Mandatory>] Path of path:string
    | [<Mandatory>] File of file:string
    | DryRun
                   
                   (*...*)
    
    let results = parser.ParseCommandLine argv
    
    let path = results.GetResult <@ Path @>
    let file = results.GetResult <@ File @>
    let dryrun = results.Contains <@ DryRun @>

    match dryrun with 
    | true -> Library.printDebug (path,file)
    | false -> Library.readCsvFile <| Path.Combine(path,file)


---

### SQLProvider

> Typed access to the database schema

![sqlprovider](images/sqlprovider.png)

***

### Resources
* Web:
    * [.NET Docs](https://docs.microsoft.com/en-us/dotnet/articles/fsharp/)
    * [F# for Fun & Profit](https://fsharpforfunandprofit.com/)
    * [F# Guide for C# devs](http://connelhooley.uk/blog/2017/04/10/f-sharp-guide)
* Books:
    * [Expert F# 4.0](http://www.apress.com/us/book/9781484207413)
    * [Learn F#](https://www.manning.com/books/learn-fsharp)
    * [Functional Concurrency in .NET](https://www.manning.com/books/functional-concurrency-in-dotnet)
* Slack:
    * [FSharp Slack](http://foundation.fsharp.org/join)
    * [F# channel on FP Slack](https://functionalprogramming.slack.com)
* Videos:
    * [Channel 9: Intro to F#](https://channel9.msdn.com/blogs/pdc2008/tl11)
    * [Channel 9: F# in VS2017](https://channel9.msdn.com/blogs/pdc2008/tl11)
    * [Functional Design Patterns](https://youtu.be/E8I19uA-wGY)


*** 

### Coding in F#

![whatever](images/favicon-160x160.png)    

<iframe src="//giphy.com/embed/aq6Thivv9V9lu?html5=true" width="480" height="272.23880597014925" frameBorder="0" class="giphy-embed" allowFullScreen></iframe><p><a href="https://giphy.com/gifs/aq6Thivv9V9lu"></a></p>

<! ### ![Yes!](https://media.giphy.com/media/aq6Thivv9V9lu/giphy.gif)>

***