// Learn more about F# at http://fsharp.org

// C# の using に相当
open System

[<EntryPoint>]
let main argv =

    // printf は F# ネイティブの関数なので、何も open することなく使用できる
    printfn "Hello World from F#!"

    // let は C# の var に相当
    let hoge = "HOGE"
    // 型を指定したい場合、ただ関数型では基本的に型推論推奨
    let piyo:int = 100

    printfn "hoge=%s, piyo=%d" hoge piyo

    // .NETのメソッドを使用する場合は C# と同じように書く
    Console.WriteLine("hoge={0}, piyo={1}", hoge, piyo);
    
    0 // return an integer exit code
