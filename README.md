# Hľadanie chýb v C# (.NET)

Tri krátke konzolové programy v C#, do ktorých niekto zaniesol chyby. Tvojou úlohou je nájsť ich a opraviť.

| # | Cvičenie | Úroveň | Čo precvičuje |
|---|----------|--------|---------------|
| 1 | [Priemer známok](01-priemer-znamok.cs) | ľahké | polia, cykly `for` a `foreach`, podmienky, delenie čísel |
| 2 | [Pokladňa](02-pokladna.cs) | stredné | typ `decimal`, metódy, súčty, hľadanie maxima |
| 3 | [Analýza textu](03-analyza-textu.cs) | ťažšie | reťazce a znaky, metódy s návratovou hodnotou |

V každom programe sú **4 syntaktické chyby** (program sa nedá preložiť) a **4 logické chyby** (program sa preloží, ale vypíše zlý výsledok alebo spadne). Čo má program robiť a aký výstup má vypísať, nájdeš v hlavičke každého súboru.

## Ako program spustiť

Každé cvičenie je jeden súbor `.cs`, netreba k nemu projekt ani `.csproj`. Potrebuješ [.NET SDK](https://dotnet.microsoft.com/download) vo verzii 10 alebo novšej.

```bash
dotnet run 01-priemer-znamok.cs
```

Máš staršie .NET (8 alebo 9)? Vytvor si projekt príkazom `dotnet new console -n Cvicenie1` a obsah súboru skopíruj do `Program.cs`.

## Postup

1. Spusti program a prečítaj si chybové hlásenia prekladača. Každé hlásenie obsahuje číslo riadku a stĺpca, napríklad `01-priemer-znamok.cs(39,52): error CS1002: ; expected`.
2. Opravuj syntaktické chyby, kým sa program nepreloží. Jedna chyba niekedy vyvolá viac hlásení, preto opravuj odhora a po každej oprave program spusti znova.
3. Keď program beží, porovnaj jeho výstup s očakávaným výstupom v hlavičke súboru. Kde sa líši, hľadaj logickú chybu.
4. Hotovo máš, keď sa výstup zhoduje s očakávaným do posledného znaku.

**Pravidlá:** zadané údaje (známky, položky, texty) ani texty výpisov nemeň, opravuj len chyby. Každá chyba sa dá opraviť zmenou jedného riadku.

**Tip:** keď nevieš, prečo program počíta zle, dopíš si pomocné `Console.WriteLine(...)` s hodnotami premenných alebo si program krokuj v debuggeri. Pred odovzdaním pomocné výpisy zmaž.

Ak `dotnet run` vypíše varovanie `NU1903` o balíku `Microsoft.DotNet.ILCompiler`, pre cvičenie ho môžeš ignorovať (pochádza zo staršej verzie SDK).
