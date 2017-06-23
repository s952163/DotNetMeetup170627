# Serverless meets F# and Bitcoin

1. Azure Functions  

    - Great for short, non-memory intensive tasks that need to be triggered by:
    - timer, queue, http
    - easy to hook  up to webapps, and leverage storage on Azure, will auto-scale
    - No need to set up a VM or maintain a server
    - Out of the box support for F#, fsx and compiled code (upload your dll, reference nuget packages)
    - **F#** syntax is a natural fit but Azure Functions are language agnostic:
        - pipeline of small stateless functions  

2. An example is the FSI Bot running on Twitter and Slack  
    
    - It's cheap. You pay only for what you use

3. It's not great for Bitcoin mining but can help us do some analysis

    - Function 1: Connect to a Bitcoin API via HTTP  
    - Poll every minute and parse the resulting JSON into a type
    - Store the result in queue (this can be skipped)
    - Function 2: react to the queue and permenantly store the data into an Azure Table (Blob, Cosmos DB, Sql) 
    - Persistent, real-time storage on which you can build your own REST service for example   

4.  Two small functions and no need to maintain any infrastructure   
  
5.  Azure also supports Jupyter notebooks in Python and F#
    
     - So let's pull the results out of Table Storage

6.  Or explore how flight prices to Hawaii change

     - Google's QPX API allows to explore public air-fare prices
     - Compiled F# dll using the QPX API
     - Testing and deployment can be automated  
     - Result goes directly to Table Storage