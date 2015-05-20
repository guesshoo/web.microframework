open System

open System.IO
 
Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

#r @"../packages/Suave.0.27.0/lib/net40/Suave.dll"


open Suave                 // always open suave
open Suave.Http.Successful // for OK-result
open Suave.Web             // for config

startWebServer defaultConfig (OK "Hello World!")