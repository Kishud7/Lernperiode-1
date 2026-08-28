// See https://aka.ms/new-console-template for more information



Console.WriteLine("Bitte geben Sie an, was für eine Rechnung Sie machen wollen. Für Addition +, für Subtraktion -, für Multiplikation x und für Division :");

string Userinput = Console.ReadLine();

if (Userinput == "+")
{
    Console.WriteLine("Bitte geben Sie Ihre erste Zahl ein:");
    double input11 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Bitte geben Sie Ihre zweite Zahl ein:");
    double input12 = Convert.ToDouble(Console.ReadLine());
    double result1 = input11 + input12;
    Console.WriteLine("Ihre Ergebniss ist " + result1);
}

else if (Userinput == "-")
{
    Console.WriteLine("Bitte geben Sie Ihre erste Zahl ein:");
    double input21 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Bitte geben Sie Ihre zweite Zahl ein:");
    double input22 = Convert.ToDouble(Console.ReadLine());
    double result2 = input21 - input22;
    Console.WriteLine("Ihre Ergebniss ist " + result2);
}

else if (Userinput == "x")
{
    Console.WriteLine("Bitte geben Sie Ihre erste Zahl ein:");
    double input31 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Bitte geben Sie Ihre zweite Zahl ein:");
    double input32 = Convert.ToDouble(Console.ReadLine());
    double result3 = input31 * input32;
    Console.WriteLine("Ihre Ergebniss ist " + result3);
}

else if (Userinput == ":")
{
    Console.WriteLine("Bitte geben Sie Ihre erste Zahl ein:");
    double input41 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Bitte geben Sie Ihre zweite Zahl ein:");
    double input42 = Convert.ToDouble(Console.ReadLine());
    double result4 = input41 / input42;
    Console.WriteLine("Ihre Ergebniss ist " + result4);
}

else Console.WriteLine("Ungültige Eingabe!");