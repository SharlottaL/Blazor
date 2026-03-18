using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        int number;
        List<BigInteger> results = new List<BigInteger>();
    
        void Calculate()
        {
            results = new List<BigInteger>();
            if (number <= 0) return;

            if (number >= 1) results.Add(0);
            if (number >= 2) results.Add(1);

            for (int i = 2; i <= number; i++)
            {
                results.Add(results[i - 1] + results[i - 2]);
            }
        }
    }
}
