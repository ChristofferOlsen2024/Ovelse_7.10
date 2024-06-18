using Ovelse_7._10;

Regn mandag = new();
mandag.Dag = "Mandag";
mandag.Nedbor = 7;

Regn tirsdag = new();
tirsdag.Dag = "Tirsdag";
tirsdag.Nedbor = 13;

Vejr vejr = new();
int samletNedbor = vejr.SamletNedbor(mandag, tirsdag);
Console.WriteLine($"Den samlede nedbør er {samletNedbor}mm");