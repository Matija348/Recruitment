List<string> rekryter = [
    "Felix",
    "Benjamin",
    "Kevin",
    "Sandor",
    "Edvin",
    "Moustafa",
    "Calin",
    "Renat",
    "Aris",
    "David",
];

List<string> lagen = [];

while (lagen.Count < 3)
{

  Console.WriteLine("Möjliga rekryter");
  for (int i = 0;i < lagen.Count;i++)
  {
    Console.WriteLine($"[{i}] {rekryter[i]}");
  }
   
  Console.WriteLine("Rekryter");
for (int i = 0; i < lagen.Count; i++)
  {
    Console.WriteLine($"{lagen[i]}");
  }

  Console.WriteLine("\nChoose a recruit:");
  int rNum = 0;
  bool couldConvert = false;
  while (couldConvert == false || rNum < 0 || rNum >= rekryter.Count)
  {
    string nText = Console.ReadLine();
    couldConvert = int.TryParse(nText, out rNum);

    if (couldConvert == false)
    {
      Console.WriteLine("Inte en nummer!");
    }
    else if (rNum < 0 || rNum >= rekryter.Count)
    {
      Console.WriteLine("inte en valid index!");
    }
  }

  string recruit = rekryter[rNum];
  lagen.Add(recruit);
  rekryter.RemoveAt(rNum);
}

Console.WriteLine($"You recruited a total of {lagen.Count} players.");

Console.WriteLine("Press ENTER to quit");
Console.ReadLine();