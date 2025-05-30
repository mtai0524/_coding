namespace Business.FindPairWithSum;

public interface IFindPairWithSum
{
    public string FindPairWithSum_On();

    public List<(int Index, int Value)>  FindPairWithSum_On2(int[] arr, int target);
}

public class FindPairWithSum : IFindPairWithSum
{
    /// <inheritdoc/>
    public string FindPairWithSum_On()
    {
        var res = "Hello world123";
        return res;
    }

    /// <inheritdoc/>
    public List<(int Index, int Value)> FindPairWithSum_On2(int[] arr, int target)
    {
        var result = new List<(int, int)>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    result.Add((arr[i], arr[j]));
                }
            }
        }

        return result;
    }
}