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
   
  Console.WriteLine("/n");






}



Console.WriteLine("Tryck På ENTER att sluta :)");
Console.ReadLine();