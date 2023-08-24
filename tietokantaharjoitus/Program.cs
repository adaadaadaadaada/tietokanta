using Azure.Core;
using tietokantaharjoitus;
// valikko, toiminnallisuus ja muut tänne

while (true) //valikko
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

    if (userinput != null)
    {
        Console.WriteLine("Syötä uusi numero");
    }

    if (userinput == "1")
    {
        LisääTuote();
    }
    if (userinput == "2")
    {
        Poistatuote();
    }
    if (userinput == "3")
    {
        QueringTuoteMäärä();
    }
    if (userinput == "4")
    {
        QueringTuotteet();
    } 
    if (userinput == "5") 
    {
        Console.WriteLine("Minkä tuotteen nimen haluat vaihtaa? (Syötä tuotteen ID)");
        int tuoteID = Console.Read();
        Console.WriteLine("Syötä uusi nimi tuotteelle: ");
        string uusiNimi = Console.ReadLine();
        VaihdaTuotenimi(uusiNimi, tuoteID);
    }
    if (userinput == "0")
    {
    }
}

static bool LisääTuote(string newTuotenimi, string newID)
{
    using Varastonhallinta varastonhallinta = new();
    Tuote tuote = new()
    {
        ID = newID,
        Tuotenimi = newTuotenimi,
        Tuotehinta = newTuotehinta,
        Varastosaldo = newVarastosaldo
    };
    Varastonhallinta.Tuotteet?.Add(tuote)
    int affect = varastonhallinta.SaveChanges();
    return affect == 1;
} //1

static int Poistatuote(string ID)
{
    using Varastonhallinta varastonhallinta = new();

    Tuote Poistatuote = varastohallinta.Tuotenimi.Find(ID);
    if (Poistatuote is null)
    {
        return 0;
    }
    else
    {
        varastonhallinta.Remove(Poistatuote);
        int affect = varastonhallinta.SaveChanges();
        return affect == 1;
    }
} //2 

static void QueringTuoteMäärä()
{
    using Varastonhallinta varastonhallinta = new();
    Console.WriteLine("Tuotemäärä: ");
    IQueryable<Tuote>? tuoteAmount = varastonhallinta.Tuotteet;

    if (tuoteAmount is null)
    {
        Console.WriteLine("Ei ole yhtään tuotteita");
        return;
    }
    foreach (Tuote tuote in tuoteAmount)
    {
        Console.WriteLine(tuote.VarastoSaldo);
    }
} //3
static void QueringTuotteet()
{
    using Varastonhallinta varastonhallinta = new();
    Console.WriteLine("Tuotteet: ");
    IQueryable<Tuote>? allTuotteet = varastonhallinta.Tuotteet;

    if (allTuotteet is null)
    {
        Console.WriteLine("Ei ole yhtään tuotteita");
        return;
    }
    foreach (Tuote tuote in allTuotteet)
    {
        Console.WriteLine(tuote.Tuotenimi + ": " + tuote.ID);
    }
} //4
static bool VaihdaTuotenimi(string newTuotenimi, int id)
{
    using Varastonhallinta varastonhallinta = new();
    Tuote tuoteUpdate = varastonhallinta.Tuotteet.FirstOrDefault(tuote => tuote.ID == id);

    if (tuoteUpdate is null)
    {
        return false;
    }
    else
    {
        tuoteUpdate.Tuotenimi = newTuotenimi;
        int affected = varastonhallinta.SaveChanges();
        return affected == 1;
    }
} //5