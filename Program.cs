// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversor de Milhas para Km, insira as milhas...");
double milhas, km;

milhas = Convert.ToDouble(Console.ReadLine());

km= milhas * 1.609;

Console.WriteLine($"{km} quilômetros");