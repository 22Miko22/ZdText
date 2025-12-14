
int liczbaLiterek; 
Console.WriteLine("Wybierz rodzaj literek.");
Console.WriteLine($"A - to male  B - to duże C - to pierwsza duża");
string rodzajLiterek = Console.ReadLine();
string slowo;
Console.WriteLine("Podaj słowo");
slowo = Console.ReadLine();
if (rodzajLiterek == "A")
{
   Console.WriteLine("Wybrałeś - małe literki.");
    slowo = slowo.ToLower();
}
else if (rodzajLiterek == "B")
{
    Console.WriteLine("Wybrałeś - duże literki.");
    slowo = slowo.ToUpper();
}
else if(rodzajLiterek == "C" && slowo.Length > 0)
{
    Console.WriteLine("Wybrałeś - pierwsza duża.");
    slowo = char.ToUpper(slowo[0])+slowo.Substring(1).ToLower();
}

liczbaLiterek = slowo.Length;
Console.WriteLine($"Twoje słowo to: {slowo}");
//Console.WriteLine(slowo);
Console.WriteLine($"Liczba literek w Twoim słowie to: {liczbaLiterek}");
//Console.WriteLine(liczbaLiterek);


