// ================================================================
//  Cvičenie 1: Priemer známok                              (ľahké)
// ================================================================
//  Program má pre zadané známky žiaka vypísať:
//    - všetky známky a ich počet,
//    - súčet známok a priemer (na 2 desatinné miesta),
//    - najlepšiu a najhoršiu známku,
//    - počet pätiek,
//    - hodnotenie podľa priemeru:
//        priemer najviac 1,50  -> "výborný"
//        priemer najviac 4,50  -> "prospel"
//        inak                  -> "neprospel"
//
//  V programe sú 4 syntaktické chyby (program sa nedá preložiť)
//  a 4 logické chyby (program beží, ale počíta zle alebo spadne).
//  Nájdi a oprav všetky chyby. Zadané známky nemeň.
//
//  Spustenie:  F5 vo Visual Studiu alebo „dotnet run“ v priečinku 01-PriemerZnamok
//
//  Očakávaný výstup po oprave:
//    Známky: 1, 3, 2, 5, 1, 4, 2
//    Počet známok: 7
//    Súčet: 18
//    Priemer: 2,57
//    Najlepšia známka: 1
//    Najhoršia známka: 5
//    Počet pätiek: 1
//    Hodnotenie: prospel
// ================================================================

using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("sk-SK"); // desatinná čiarka
Console.OutputEncoding = System.Text.Encoding.UTF8;    // diakritika v konzole

int[] znamky = { 1, 3, 2, 5, 1, 4, 2 };

Console.WriteLine("Známky: " + string.Join(", ", znamky));
Console.WriteLine("Počet známok: " + znamky.Length)

// súčet známok
int sucet = 0;
for (int i = 0; i <= znamky.Length; i++)
{
    sucet += znamky[i];
}
Console.WriteLine("Súčet: " + sucet;

// priemer
double priemer = sucet / znamky.Length;
Console.WriteLine($"Priemer: {priemer:F2}");

// najlepšia a najhoršia známka
int najlepsia = 0;
int najhorsia = znamky[0];
foreach (int znamka in znamky)
{
    if (znamka < najlepsia)
        najlepsia = znamka;

    if (znamka > najhorsia)
        najhorsia = znamka;
}
Console.WriteLine("Najlepšia známka: " + najlepsia);
Console.Writeline("Najhoršia známka: " + najhorsia);

// počet pätiek
int pocetPatiek = 0;
foreach (int znamka in znamky)
{
    if (znamka = 5)
        pocetPatiek++;
}
Console.WriteLine("Počet pätiek: " + pocetPatiek);

// hodnotenie
if (priemer >= 1.5)
    Console.WriteLine("Hodnotenie: výborný");
else if (priemer <= 4.5)
    Console.WriteLine("Hodnotenie: prospel");
else
    Console.WriteLine("Hodnotenie: neprospel");
