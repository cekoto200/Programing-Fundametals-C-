﻿int n = int.Parse(Console.ReadLine());


    for (int a = 1; a < 9; a++)
    {
        for (int b = 9; b >= a; b--)
        {
            for (int c = 0; c < 9; c++)
            {
                for (int d = 9; d >= c; d--)
                {
                    int sum = a + b + c + d;
                    int po = a * b * c * d;
                     if (sum != 0 && po / sum == 3 && n % 3 == 0)
                    {
                        Console.WriteLine($"{d}{c}{b}{a}");
                        return;
                    }
                    
                if (sum == po && n % 10 == 5)
                    {
                        Console.WriteLine($"{a}{b}{c}{d}");
                        return;
                    }
                   
                    
                        
                    
                }
            }
        }
    }
   

Console.WriteLine("Nothing found");