using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        string startInput = Console.ReadLine();

        
        string endInput = Console.ReadLine();

        if (!DateTime.TryParseExact(startInput, "dd.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate) ||
            !DateTime.TryParseExact(endInput, "dd.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate))
        {
            
            return;
        }

        if (startDate > endDate)
        {
           
            return;
        }

        int weekendCount = 0;

        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                weekendCount++;
            }
        }

        Console.WriteLine(weekendCount);
    }
}





