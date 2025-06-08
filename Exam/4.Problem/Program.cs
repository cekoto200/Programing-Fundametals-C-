int days = int.Parse(Console.ReadLine());

double litres = 0;
double degrees = 0.0;

for (int day = 1;  day <= days; day++)
{
   double litres1 = double.Parse(Console.ReadLine());
    litres += litres1;
    degrees += double.Parse(Console.ReadLine()) * litres1;

}
double actualDegree = degrees / litres;
Console.WriteLine($"Liter: {litres:f2}");
Console.WriteLine($"Degrees: {actualDegree:f2}");
if (actualDegree < 38)
{
    Console.WriteLine("Not good, you should baking!");
}
else if (actualDegree >= 38 && actualDegree < 42)
{
    Console.WriteLine("Super!");
}
else
{
    Console.WriteLine("Dilution with distilled water!");
}