﻿int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int cakePieces = width * lenght;

string input = "";
while ((input = Console.ReadLine()) != "STOP")
{
    int currentPieces = int.Parse(input);
    cakePieces -= currentPieces;

    if (cakePieces < 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
        break;
    }
}
if (cakePieces >= 0)
{
    Console.WriteLine($"{cakePieces} pieces are left.");
}
