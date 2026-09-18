// See https://aka.ms/new-console-template for more information

Taschenrechner();

static void Taschenrechner()
{
    Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("         TASCHENRECHNER");
    Console.WriteLine("==================================");
    Console.WriteLine();
    Console.WriteLine("Wähle eine Rechenart:");
    Console.WriteLine("+  = Addition");
    Console.WriteLine("-  = Subtraktion");
    Console.WriteLine("*  = Multiplikation");
    Console.WriteLine("/  = Division");
    Console.WriteLine("a  = Algebra");
    Console.WriteLine();
    Console.Write("Deine Auswahl: ");

    string Rechenart = Console.ReadLine();

    if (Rechenart == "+")
    {
        Console.Write("Bitte geben Sie Ihre erste Zahl ein: ");
        double InputZahl1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bitte geben Sie Ihre zweite Zahl ein: ");
        double InputZahl2 = Convert.ToDouble(Console.ReadLine());

        double result = InputZahl1 + InputZahl2;

        Console.WriteLine("Ihr Ergebnis ist: " + result);

        Neustart();
    }

    else if (Rechenart == "-")
    {
        Console.Write("Bitte geben Sie Ihre erste Zahl ein: ");
        double InputZahl1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bitte geben Sie Ihre zweite Zahl ein: ");
        double InputZahl2 = Convert.ToDouble(Console.ReadLine());

        double result = InputZahl1 - InputZahl2;

        Console.WriteLine("Ihr Ergebnis ist: " + result);

        Neustart();
    }

    else if (Rechenart == "*")
    {
        Console.Write("Bitte geben Sie Ihre erste Zahl ein: ");
        double InputZahl1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bitte geben Sie Ihre zweite Zahl ein: ");
        double InputZahl2 = Convert.ToDouble(Console.ReadLine());

        double result = InputZahl1 * InputZahl2;

        Console.WriteLine("Ihr Ergebnis ist: " + result);

        Neustart();
    }

    else if (Rechenart == "/")
    {
        Console.Write("Bitte geben Sie Ihre erste Zahl ein: ");
        double InputZahl1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bitte geben Sie Ihre zweite Zahl ein: ");
        double InputZahl2 = Convert.ToDouble(Console.ReadLine());

        if (InputZahl2 != 0)
        {
            double result = InputZahl1 / InputZahl2;

            Console.WriteLine("Ihr Ergebnis ist: " + result);
        }
        else
        {
            Console.WriteLine("Man kann nicht durch 0 teilen.");
        }

        Neustart();
    }

    else if (Rechenart == "a")
    {
        Algebra();
    }

    else
    {
        Console.WriteLine("Ungültige Eingabe!");
        Console.WriteLine("Drücke Enter, um es erneut zu versuchen.");

        Console.ReadLine();

        Taschenrechner();
    }
}


static void Algebra()
{
    Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("             ALGEBRA");
    Console.WriteLine("==================================");
    Console.WriteLine();
    Console.WriteLine("Dieses Programm löst Gleichungen");
    Console.WriteLine("in der Form:");
    Console.WriteLine();
    Console.WriteLine("ax + b = c");
    Console.WriteLine();
    Console.WriteLine("Beispiel: 2x + 5 = 15");
    Console.WriteLine();

    Console.Write("Gib die Zahl vor x ein (a): ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Gib die Zahl nach x ein (b): ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Gib die Zahl auf der rechten Seite ein (c): ");
    double c = Convert.ToDouble(Console.ReadLine());

    if (a != 0)
    {
        double x = (c - b) / a;

        Console.WriteLine();
        Console.WriteLine("Die Gleichung lautet:");
        Console.WriteLine(a + "x + " + b + " = " + c);

        Console.WriteLine();
        Console.WriteLine("Lösung:");
        Console.WriteLine("x = " + x);
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Die Zahl vor x darf nicht 0 sein.");
    }

    Neustart();
}


static void Neustart()
{
    Console.WriteLine();
    Console.WriteLine("Drücke Enter, um eine neue Rechnung zu starten.");

    Console.ReadLine();

    Taschenrechner();
}