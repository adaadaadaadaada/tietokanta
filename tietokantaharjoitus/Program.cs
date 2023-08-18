using tietokantaharjoitus;
// valikko, toiminnallisuus ja muut tänne

static void Valikko()
{
    Console.WriteLine("VARASTONHALLINTA");
    Console.WriteLine("1 - Lisää uusi tuote");
    Console.WriteLine("2 - Poista tuote");
    Console.WriteLine("3 - Tulosta eri tuotteiden määrät");
    Console.WriteLine("4 - Tulosta kaikki tuotteet");
    Console.WriteLine("5 - Muokkaa tuotenimeä");
    Console.WriteLine("0 - Lopeta sovellus");
    Console.WriteLine(" ");
    Console.WriteLine("Valintasi on: ");
    string userinput = Console.ReadLine();
}