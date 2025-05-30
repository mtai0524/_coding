namespace Business.FindPairWithSum;

public interface IFindPairWithSum
{
    public string FindPairWithSum_On();
    public List<(int index, int value)>  FindPairWithSum_On2(int[] arr, int target);
}

public class FindPairWithSum : IFindPairWithSum
{
    public string FindPairWithSum_On()
    {
        var res = "Hello world123";
        return res;
    }

    public List<(int index, int value)> FindPairWithSum_On2(int[] arr, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    if (!map.ContainsKey(i)) map[i] = arr[i];
                    if (!map.ContainsKey(j)) map[j] = arr[j];
                }
            }
        }

        return map
            .Select(kvp => (kvp.Key, kvp.Value))
            .ToList();
    }
}