List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
Eruption chileFirst = eruptions.Where(er => er.Location == "Chile").OrderBy(er => er.Year).ToList().First();
Console.WriteLine($"{chileFirst.Location} - {chileFirst.Volcano} - {chileFirst.Year}");
Console.WriteLine("---------------------------------------------");

Eruption hawiianFirst = eruptions.Where(er => er.Location == "Hawaiian Is").OrderBy(er => er.Year).ToList().FirstOrDefault();
if (hawiianFirst == null)
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
}
else
{
    Console.WriteLine($"{hawiianFirst.Location} - {hawiianFirst.Volcano} - {hawiianFirst.Year}");
}
Console.WriteLine("---------------------------------------------");


IEnumerable<Eruption> highEruptions = eruptions.Where(er => er.ElevationInMeters > 2000);
PrintEach(highEruptions);
Console.WriteLine("---------------------------------------------");


IEnumerable<Eruption> zEruptions = eruptions.Where(er => er.Volcano.StartsWith("Z"));
PrintEach(zEruptions);
Console.WriteLine($"Number of Eruptions {zEruptions.Count()}");
Console.WriteLine("---------------------------------------------");

int highestEruption = eruptions.Max(er => er.ElevationInMeters);
Console.WriteLine($"{highestEruption}");
Console.WriteLine("---------------------------------------------");

string highestEruptionName = eruptions.Find(er => er.ElevationInMeters == highestEruption).Volcano;
Console.WriteLine($"{highestEruptionName}");
Console.WriteLine("---------------------------------------------");

IEnumerable<Eruption> alphabeticalEruptions = eruptions.OrderBy(er => er.Volcano);
PrintEach(alphabeticalEruptions);
Console.WriteLine("---------------------------------------------");


List<string> alphabeticalEruptionsBefore = eruptions.Where(er => er.Year < 1000).OrderBy(er => er.Volcano).Select(er => er.Volcano).ToList();
PrintEach(alphabeticalEruptionsBefore);
Console.WriteLine("---------------------------------------------");



// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
