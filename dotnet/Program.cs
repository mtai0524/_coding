using Business;
using Business.FindPairWithSum;
using dotnet.Configs;
using dotnet.Runners;
using dotnet.Runners.FindPairWithSumRunner;
using Microsoft.Extensions.DependencyInjection;

namespace dotnet;

class Program
{
    public static void Main(string[] args)
    {
        // init service provider
        var provider = ServiceProviderFactory.Create();
        
        // init runner
        RunnerFactory.Init(provider);

        // goi findpariwithsum voi runner
        var runner = RunnerFactory.Get<FindPairWithSumRunner>();
        runner.RunFindPairWithSum_On2();
        
        Console.ReadLine();
    }
}