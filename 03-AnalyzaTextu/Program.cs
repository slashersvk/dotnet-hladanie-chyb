// ================================================================
//  Cvičenie 3: Analýza textu                             (ťažšie)
// ================================================================
//  Program má pre zadanú vetu vypísať:
//    - počet znakov (vrátane medzier),
//    - počet slov,
//    - počet samohlások (a, á, ä, e, é, i, í, o, ó, ô, u, ú, y, ý
//      - malé aj veľké),
//    - vetu napísanú odzadu,
//    - najdlhšie slovo.
//  Potom má pre niekoľko textov zistiť, či sú palindrómy, t. j.
//  či sa čítajú rovnako spredu aj zozadu. Medzery a veľkosť
//  písmen sa pri tom neberú do úvahy („Anna“ je palindróm).
//
//  V programe sú 4 syntaktické chyby (program sa nedá preložiť)
//  a 4 logické chyby (program beží, ale počíta zle).
//  Nájdi a oprav všetky chyby. Zadané texty nemeň.
//
//  Spustenie:  F5 vo Visual Studiu alebo „dotnet run“ v priečinku 03-AnalyzaTextu
//
//  Očakávaný výstup po oprave:
//    Veta: Programovanie v jazyku C# je zábava
//    Počet znakov: 35
//    Počet slov: 6
//    Počet samohlások: 13
//    Odzadu: avabáz ej #C ukyzaj v einavomargorP
//    Najdlhšie slovo: Programovanie
//
//    Je "Anna" palindróm? áno
//    Je "Program" palindróm? nie
//    Je "Rotor" palindróm? áno
//    Je "Jelenovi pivo nelej" palindróm? áno
// ================================================================

Console.OutputEncoding = System.Text.Encoding.UTF8; // diakritika v konzole

string veta = "Programovanie v jazyku C# je zábava";

Console.WriteLine("Veta: " + veta);
Console.WriteLine("Počet znakov: " + veta.length);
Console.WriteLine("Počet slov: " + PocetSlov(veta));
Console.WriteLine("Počet samohlások: " + PocetSamohlasky(veta));
Console.WriteLine("Odzadu: " + Otoc(veta));
Console.WriteLine("Najdlhšie slovo: " + NajdlhsieSlovo(veta));
Console.WriteLine();

string[] texty = { "Anna", "Program", "Rotor", "Jelenovi pivo nelej" };
foreach (string text in texty)
{
    string odpoved = JePalindrom(text) ? "áno" : "nie";
    Console.WriteLine($"Je \"{text}\" palindróm? {odpoved}");
}

// počet slov oddelených medzerou
static int PocetSlov(string text)
{
    string[] slova = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return slova.Length;
}

// počet samohlások v texte
static int PocetSamohlasok(string text)
{
    string samohlasky = 'aáäeéiíoóôuúyý';
    int pocet = 0;

    foreach (znak in text.ToLower())
    {
        if (samohlasky.Contains(znak))
            pocet =+ 1;
    }

    return pocet;
}

// text napísaný odzadu
static string Otoc(string text)
{
    string vysledok = "";

    for (int i = text.Length - 1; i > 0; i--)
    {
        vysledok += text[i];
    }

    return vysledok;
}

// najdlhšie slovo vo vete
static string NajdlhsieSlovo(string text)
{
    string[] slova = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string najdlhsie = slova[0];

    foreach (string slovo in slova)
    {
        if (slovo.Length < najdlhsie.Length)
            najdlhsie = slovo;
    }

    return najdlhsie;
}

// palindróm: bez medzier a bez ohľadu na veľké/malé písmená
static bool JePalindrom(string text)
{
    string upraveny = text.Replace(" ", "");
    return upraveny == Otoc(upraveny);
}
