# Multifabriken
## Instruktioner
### Konsolapplikationen kräver att din dator har .NET SDK installerat
1. Klona ner repot från den nuvarande git-sidan
2. Öppna mappen "Multifabriken" via en terminal
3. Starta applikltionen genom att skriva in kommandot `dotnet run` i terminalen
4.Följ sedan applikationens instruktioner

## Bakgrundsbeskrivning till uppgiften "Multifabriken"
Utveckla en konsolapplikation för bolaget Multifabriken AB. De vill skapa en konsolapplikation för sina kunder där man kan välja att beställa nya produkter från deras fabrik. Fabriken kan producera bilar, godis, snören eller tofu. Via inmatning av beställning ska nya produkter skapas av den valda typen och samtliga produkter man beställt ska kunna listas av användaren.


## Teknologier
* Ramverk: .NET6 Core
* Applikationstyp: Konsolapplikation (Command line arguments)
* Designmönster: Objektorienterad programmering (OOP)
* Programmeringsspråk: C#


## Kravspecifikation
|Kravnummer|Uppfyllt|Kravbeskrivning|
|-------|------|------|
|**1**  |**Ja**| *Lösningen ska bestå av en konsolapplikation skriven i C# som är körbar med .NET Core* |
|**2**  |**Ja**| *När man startar programmet ska man mötas av en meny samt en kort introduktion till programmet* |
|**3**  |**Ja**| *Man ska kunna göra ett val i menyn med vilken typ av produkt man vill beställa, om man vill lista alla  - produkter man beställt, eller om man vill avsluta programmet*  |
|**4**  |**Ja**| *Produkterna man kan välja mellan är bilar, godis, snören samt tofu* |
|**5**  |**Ja**| *När man väljer att skapa ett snöre så ombes man att mata in "färg" samt "längd"* |
|**6**  |**Ja**| *När man väljer att skapa en bil ska man ombes att mata in ett "registreringsnummer", en "färg", och sedan ett  - "bilmärke"* |
|**7**  |**Ja**| *När man väljer att skapa en godis ombes man att mata in "smak" följt av "antal"* |
|**8**  |**Ja**| *När man väljer att skapa tofu ombes man att mata in "volym" i liter samt en "kryddning"* |
|**9**  |**Ja**| *Om man väljer att lista alla produkter ska alla produkter man beställt hittills skrivas ut med den  - informationen man angett* |
|**10** |**Ja**| *Om man väljer att avsluta programmet ska programmet helt enkelt sluta köras* |
|**11** |**Ja**| *Lösningen ska bestå av en "Program.cs" fil, en ".csproj" fil samt en fil för varje extra klass du skapar* |
|**12** |**Ja**| * Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf* |
|**13** |**Ja**| *reflections-filen ska en ska innehålla en kort beskrivning av kodens funktioner och struktur* |
|**14** |**Ja**| *Filen reflections ska också innehålla en egen analys och reflektion över hur du strukturerat din kod genom användandet av metoder och klasser. |