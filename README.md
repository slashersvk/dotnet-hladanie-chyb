# Hľadanie chýb v C# (.NET)

Tri krátke konzolové programy v C#, do ktorých niekto zaniesol chyby. Tvojou úlohou je nájsť ich a opraviť.

| # | Cvičenie | Úroveň | Čo precvičuje |
|---|----------|--------|---------------|
| 1 | [Priemer známok](01-PriemerZnamok/Program.cs) | ľahké | polia, cykly `for` a `foreach`, podmienky, delenie čísel |
| 2 | [Pokladňa](02-Pokladna/Program.cs) | stredné | typ `decimal`, metódy, súčty, hľadanie maxima |
| 3 | [Analýza textu](03-AnalyzaTextu/Program.cs) | ťažšie | reťazce a znaky, metódy s návratovou hodnotou |

V každom programe sú **4 syntaktické chyby** (program sa nedá preložiť) a **4 logické chyby** (program sa preloží, ale vypíše zlý výsledok alebo spadne). Čo má program robiť a aký výstup má vypísať, nájdeš v hlavičke súboru `Program.cs`.

## Ako program spustiť

Každé cvičenie je samostatný konzolový projekt: priečinok so súborom `.csproj` a jediným zdrojovým súborom `Program.cs`. Potrebuješ [.NET SDK](https://dotnet.microsoft.com/download) vo verzii 10 alebo novšej.

**Visual Studio:** otvor súbor `.csproj` z priečinka cvičenia (dvojklikom alebo cez *File → Open → Project/Solution*) a spusti ho klávesom F5.

**Príkazový riadok:**

```bash
cd 01-PriemerZnamok
dotnet run
```

Máš .NET 8? V súbore `.csproj` zmeň `<TargetFramework>net10.0</TargetFramework>` na `net8.0`.

## Postup

1. Spusti program a prečítaj si chybové hlásenia prekladača. Každé hlásenie obsahuje číslo riadku a stĺpca, napríklad `Program.cs(39,52): error CS1002: ; expected`. Vo Visual Studiu ich nájdeš v okne *Error List* a dvojklikom na hlásenie skočíš na chybný riadok.
2. Opravuj syntaktické chyby, kým sa program nepreloží. Prekladač najprv hlási iba chyby zápisu a ostatné chyby ukáže až po ich oprave. Preto po každej oprave program prelož znova.
3. Keď program beží, porovnaj jeho výstup s očakávaným výstupom v hlavičke súboru. Kde sa líši, hľadaj logickú chybu.
4. Hotovo máš, keď sa výstup zhoduje s očakávaným do posledného znaku.

**Pravidlá:** zadané údaje (známky, položky, texty) ani texty výpisov nemeň, opravuj len chyby. Každá chyba sa dá opraviť zmenou jedného riadku.

**Tip:** keď nevieš, prečo program počíta zle, dopíš si pomocné `Console.WriteLine(...)` s hodnotami premenných alebo si program krokuj v debuggeri (F9 nastaví breakpoint, F10 vykoná ďalší riadok). Pred odovzdaním pomocné výpisy zmaž.
