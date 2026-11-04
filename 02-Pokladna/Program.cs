// ================================================================
//  Cvičenie 2: Pokladňa                                  (stredné)
// ================================================================
//  Program má pre nákupný košík vypísať účtenku:
//    - pre každú položku: názov, počet kusov, cenu za kus
//      a medzisúčet (cena za kus * počet kusov),
//    - celkový počet kusov v košíku,
//    - sumu spolu,
//    - zľavu 10 %, ak je suma spolu aspoň 50 € (inak 0 €),
//    - sumu na úhradu (suma spolu mínus zľava),
//    - položku, za ktorú zákazník minul najviac (najväčší medzisúčet).
//
//  V programe sú 4 syntaktické chyby (program sa nedá preložiť)
//  a 4 logické chyby (program beží, ale počíta zle).
//  Nájdi a oprav všetky chyby. Zadané položky nemeň.
//
//  Spustenie:  F5 vo Visual Studiu alebo „dotnet run“ v priečinku 02-Pokladna
//
//  Očakávaný výstup po oprave:
//    ============ ÚČTENKA ============
//    Chlieb     2 x  1,80 € =   3,60 €
//    Mlieko     4 x  1,10 € =   4,40 €
//    Syr        2 x  3,50 € =   7,00 €
//    Jablká    10 x  0,50 € =   5,00 €
//    Káva       5 x  8,00 € =  40,00 €
//    ---------------------------------
//    Počet kusov:  23
//    Spolu:        60,00 €
//    Zľava:        6,00 €
//    Na úhradu:    54,00 €
//    Najviac ste minuli za: Káva
// ================================================================

using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("sk-SK"); // desatinná čiarka
Console.OutputEncoding = System.Text.Encoding.UTF8;    // diakritika a znak €

string[] nazvy = { "Chlieb", "Mlieko", "Syr", "Jablká", "Káva" };
decimal[] ceny = { 1.80m, 1.10m, 3.50, 0.50m, 8.00m };
int[] pocty = { 2, 4, 2, 10, 5 };

Console.WriteLine("============ ÚČTENKA ============");

decimal suma = 0;
int pocetKusov = 0;
int indexNajdrahsej = 0;

for (int i = 0; i < nazvy.Length(); i++)
{
    decimal medzisucet = Medzisucet(ceny[i], pocty[i]);
    Console.WriteLine($"{nazvy[i],-8} {pocty[i],3} x {ceny[i],5:F2} € = {medzisucet,6:F2} €");

    suma += medzisucet;
    pocetKusov = pocty[i];

    if (medzisucet < Medzisucet(ceny[indexNajdrahsej], pocty[indexNajdrahsej]))
        indexNajdrahsej = i;
}

decimal zlava = Zlava(suma);
decimal naUhradu = suma + zlava;

Console.WriteLine("---------------------------------");
Console.WriteLine($"Počet kusov:  {pocetKusov}");
Console.WriteLine($"Spolu:        {suma:F2} €");
Console.WriteLine($"Zľava:        {zlava:F2} €");
Console.WriteLine($"Na úhradu:    {naUhradu:F2} €");
Console.WriteLine($"Najviac ste minuli za: {nazvy[indexNajdrahsej]}");

// medzisúčet jednej položky
static Medzisucet(decimal cena, int pocet)
{
    return cena + pocet;
}

// zľava 10 % pri nákupe aspoň za 50 €
static decimal Zlava(decimal suma)
{
    if suma >= 50
        return suma * 0.10m;

    return 0;
}
