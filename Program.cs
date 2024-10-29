// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program liczący samogłoski.");
Console.Write("Podaj ciąg znaków:");
string ciag = Console.ReadLine();
Console.WriteLine($"Podany przez Ciebie ciąg znaków ma {Narzedzia.Samogloski(ciag)} samogłosek.");