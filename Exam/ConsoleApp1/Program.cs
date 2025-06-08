using System;


    
        int n = int.Parse(Console.ReadLine());  // Четем входа

        // Пробваме всички възможни комбинации на цифрите a, b, c, d
        for (int a = 1; a <= 9; a++)  // a от 1 до 9
        {
            for (int b = 9; b >= a; b--)  // b от 9 до a
            {
                for (int c = 0; c <= 9; c++)  // c от 0 до 9
                {
                    for (int d = 9; d >= c; d--)  // d от 9 до c
                    {
                        int sum = a + b + c + d;
                        int product = a * b * c * d;

                        // Първо условие: сума == произведение и n завършва на 5
                        if (sum == product && n % 10 == 5)
                        {
                            Console.WriteLine($"{a}{b}{c}{d}");
                            return;  // Спираме изпълнението след първата валидна комбинация
                        }

                        // Второ условие: произведение / сума == 3 и n е делимо на 3
                        if (sum != 0 && product / sum == 3 && n % 3 == 0)
                        {
                            Console.WriteLine($"{d}{c}{b}{a}");
                            return;  // Спираме изпълнението след първата валидна комбинация
                        }
                    }
                }
            }
        }

        // Ако не намерим валидна комбинация
        Console.WriteLine("Nothing found");

