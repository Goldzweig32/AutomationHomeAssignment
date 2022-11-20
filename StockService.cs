namespace AutomationHomeAssignment;

public class StockService
{
    public int MaxRevenue(int[] rates)
    {
        var n = rates.Length;
        var maxRate = rates[0] - rates[1];
        var rateIndex = 0;
        
        if (n == 1)
        {
            return rates[0];
        }
        else if (n < 1)
        {
            return 0;
        }
        
        for (var i = 2; i < n-1; i++)
        {
            if (maxRate - rates[i] > maxRate)
            {
                maxRate = maxRate - rates[i];
            }else if (rates[i] - rates[i+1] > maxRate)
            {
                maxRate = rates[i] - rates[i + 1];
            }
        }

        return maxRate;

    }
}