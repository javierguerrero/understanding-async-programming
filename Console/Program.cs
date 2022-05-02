using System;
using System.IO;

//var lines = File.ReadAllLines("TextFile1.txt");
//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}

//File.ReadAllLinesAsync("TextFile1x.txt")
//    .ContinueWith(t => {

//        if (t.IsFaulted)
//        {
//            Console.Error.WriteLine(t.Exception);
//        }

//        var lines = t.Result;
//        foreach (var line in lines)
//        {
//            Console.WriteLine(line);
//        }
//    });

//Console.ReadKey();

// await ReadFile();

var networkResult = await GetDataFromNetworkAsync();


Func<Task<int>> getDataFromNetworkViaLambda = async () =>
{
    await Task.Delay(150);
    var result = 42;
    return result;
};


async Task ReadFile()
{
    var lines = await File.ReadAllLinesAsync("TextFile1.txt");
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}

async Task<int> GetDataFromNetworkAsync() 
{
    // Simulate a network call
    await Task.Delay(150);
    var result = 42;
    return result;
}