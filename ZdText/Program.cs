//1 Zadanie
/*int liczbaLiterek;
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
else if (rodzajLiterek == "C" && slowo.Length > 0)
{
    Console.WriteLine("Wybrałeś - pierwsza duża.");
    slowo = char.ToUpper(slowo[0]) + slowo.Substring(1).ToLower();
}

liczbaLiterek = slowo.Length;
Console.WriteLine($"Twoje słowo to: {slowo}");
Console.WriteLine($"Liczba literek w Twoim słowie to: {liczbaLiterek}");*/
//2 Zadanie
Console.WriteLine("Podaj Text:");
string text = Console.ReadLine();
text = text.Trim();
int dlugoscTextu = text.Length;
Console.WriteLine($"Podany text to:{text}");
Console.WriteLine($"Długość tekstu bez spacji na początku i na końcu: {dlugoscTextu}");
string pierwszaLiterka = text.Substring(0,1);
string ostatniaLiterka = text.Substring(dlugoscTextu - 1, 1);
Console.WriteLine($"Pierwsza literka to: {pierwszaLiterka}");
Console.WriteLine($"Ostatnia literka to: {ostatniaLiterka}");


