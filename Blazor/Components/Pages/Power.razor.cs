using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Power
    {
        long a;
        long n;
        long result;
        List<long> results = new List<long>();
        void Calculate()
        {
            result = 1;
            results = new List<long>();
            for (int i = 1; i <= n; i++)
            {
                result *= a;
                results.Add(result);
            }
        }
    }
}
