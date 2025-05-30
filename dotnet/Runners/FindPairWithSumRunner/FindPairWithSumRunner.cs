using Business.FindPairWithSum;

namespace dotnet.Runners.FindPairWithSumRunner;

public class FindPairWithSumRunner(IFindPairWithSum finder)
{
    private readonly int[] arr = new[] { 2, 5, 10, 1, 2, 19, 4, 13 };
    private int Target { get; set; }

    public void RunFindPairWithSum_On2()
    {
        var input = Console.ReadLine();

        if (!int.TryParse(input, out int target))
        {
            Console.WriteLine("Invalid input. Must be a number.");
            return;
        }

        var result = finder.FindPairWithSum_On2(this.arr, target);

        foreach (var (index, value) in result)
        {
            Console.WriteLine($"Index: {index}, Value: {value}");
        }
    }

    public void RunFindPairWithSum_On()
    {
        var result = finder.FindPairWithSum_On();
        Console.WriteLine(result);
    }
}