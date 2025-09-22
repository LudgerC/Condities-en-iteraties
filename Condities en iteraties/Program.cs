Console.WriteLine("Geef een woord in: ");// Vraag een woord
string woord = Console.ReadLine();// Opslaan het woord

// Menu tonen
Console.WriteLine("Kies een methode om de tekst om te keren:");
Console.WriteLine("1. For-loop");
Console.WriteLine("2. While-loop");
Console.WriteLine("3. Do-while-loop");
Console.WriteLine("4. Recursie");

// Kies van de gebruiker lezen
char keuze = Console.ReadLine()[0];
string omgekeerd = "";
int i = 0;

switch (keuze)
{
    case '1':
        for (i = woord.Length - 1; i >= 0; i--)
        {
            omgekeerd += woord[i];
        }
        Console.WriteLine("Omgekeerd: " + omgekeerd);
        break;
    case '2':
        i = woord.Length - 1;
        while (i >= 0)
        {
            omgekeerd += woord[i];
            i--;
        };
        Console.WriteLine("Omgekeerd: " + omgekeerd);
        break;
    case '3':
        i = woord.Length - 1;
        do
        {
            omgekeerd += woord[i];
            i--;
        } while (i >= 0);
        Console.WriteLine("Omgekeerd: " + omgekeerd);
        break;
    case '4':
        // Lokale functie voor recursie
        string OmkerenRecursief(string w)
        {
            if (w.Length <= 1)
                return w;

            char laatste = w[w.Length - 1];
            string rest = w.Substring(0, w.Length - 1);
            return laatste + OmkerenRecursief(rest);
        }

        omgekeerd = OmkerenRecursief(woord);
        Console.WriteLine("Omgekeerd: " + omgekeerd);
        break;
    default:
        Console.WriteLine("Ongeldige keuze");
        break;
}