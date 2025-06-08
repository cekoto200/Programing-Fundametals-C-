string book = Console.ReadLine();
int numberOfCheckedBooks = 0;
bool isFound = false;
string input = "";

while ((input = Console.ReadLine()) != "No More Books")
{
    if (input == book)
    {
       isFound = true;
        break;
    }
    
    numberOfCheckedBooks++;
}

if (isFound)
{
    Console.WriteLine($"You checked {numberOfCheckedBooks} books and found it.");

}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {numberOfCheckedBooks} books.");
}




