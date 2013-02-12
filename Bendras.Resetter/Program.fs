open System
open System.Diagnostics
open System.Threading

[<EntryPoint>]
let main argv = 
    
    while true do
        printfn "%O Starting process..." DateTime.UtcNow
        let proc = Process.Start("mpcs-0.8k-rc13f-i386-pc-cygwin.exe");
        //let proc = Process.Start("cmd");
        printfn "%O Started." DateTime.UtcNow
        Thread.Sleep(3600000) 
        printfn "%O Closing process..." DateTime.UtcNow
        proc.Refresh()
        proc.CloseMainWindow() |> ignore
        proc.WaitForExit()
        proc.Close()
        printfn "%O Closed." DateTime.UtcNow
        proc.Dispose()
    
    0 // return an integer exit code
