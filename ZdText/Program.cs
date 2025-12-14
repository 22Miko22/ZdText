
int liczbaLiterek; 
//Console.WriteLine("Wybierz rodzaj literek.");
Console.WriteLine("Podaj słowo");
string slowo = Console.ReadLine();
slowo = slowo.ToUpper();
liczbaLiterek = slowo.Length;
Console.Write("Twoje słowo to: ");
Console.WriteLine(slowo);
Console.Write("Liczba literek w Twoim słowie to: ");
Console.WriteLine(liczbaLiterek);


