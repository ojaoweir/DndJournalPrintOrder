Console.Write("Antal sidor: ");
int numPages = int.Parse(Console.ReadLine());
if(numPages % 4 != 0)
{
    Console.WriteLine("Måste vara delbart med 4, lägg in blanka sidor");
    return;
}

List<int> finalOrder = new();

for(int i = 0; i < numPages/2; i++)
{
    if(i % 2 == 0)
    {
        finalOrder.Add(numPages - i);
        finalOrder.Add(i + 1);
    } else
    {
        finalOrder.Add(i + 1);
        finalOrder.Add(numPages - i);
    }
}

Console.Write("Ordning: ");
foreach(var i in finalOrder)
{
    Console.Write(i + ",");
}
Console.WriteLine();

Console.WriteLine("För att få till korrekt i word ange följande inställningar när du gått in till print:");
Console.WriteLine("- Välj anpassad utskriftsformat (default här är 'skriv ut alla sidor')");
Console.WriteLine("- Mata in ordningen ovan i 'sidor'-fältet");
Console.WriteLine("- Längst ned välj 2 sidor per ark");
Console.WriteLine("- På samma ställe, gå till alternativet 'Anpassa till pappersstorlek' och välj 'A4'");