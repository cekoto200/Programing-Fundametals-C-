



double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double basearea = width * length;
double volume = (1.0/3) * basearea * height;

Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
