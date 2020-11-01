# MruV API C# package

This repository contains code generated from https://github.com/MruV-RP/mruv-protos protobuf files

## How to use this repository?
This repository will generate an NuGet package for every new version of code. If you want to use MruV API package in your C# project, you should add MruV.Protos package from https://www.nuget.org/packages/MruV.Protos/ 

## Example code
This example will connect to MruV API on address 127.0.0.1:50051 and run [IsAccountExist](https://github.com/MruV-RP/mruv-pb-docs/blob/master/docs.md#mruvaccountsservice)
```csharp
public static void Main(string[] args)
{
    // Init connection
    Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
    var accountsClient = new MruVAccountsService.MruVAccountsServiceClient(channel);

    // Send gRPC request
    var login = "Account Login";
    var reply = accountsClient.IsAccountExist(new IsAccountExistRequest() { Login = login });
    if (reply.Exists)
    {
        Console.WriteLine("Account exists :)");
    }
    else
    {
        Console.WriteLine("There is no such account :(");
    }

    // Close channel & exit
    channel.ShutdownAsync().Wait();
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

```
