using System;

namespace Repetitionsövningar
{
    class Program
    {
        static void Main(string[] args)
        {
            string villSpela = "ja";
            Console.WriteLine("Välkommen till repetitionsövningar");

            while (villSpela == "ja")
            {
                Console.WriteLine("Vilken uppgift vill du se nu?");
                int uppgift = Int32.Parse(Console.ReadLine());

                if(uppgift == 1)
                {
                    Console.WriteLine("Hello World");
                }
                else if(uppgift == 2)
                {
                    Console.WriteLine("Once upon a time");
                    Console.WriteLine("I was falling in love");
                    Console.WriteLine("Now I'm only falling apart");
                }
                else if(uppgift == 3)
                {
                    Console.WriteLine("Once upon a time I was falling in love now I'm only falling apart");
                }
                else if(uppgift == 4)
                {
                    string text = "Live and sleep!";
                    Console.WriteLine(text);
                }
                else if(uppgift == 5)
                {
                    string name = "Ada Lovelace";
                    Console.WriteLine($"Hej {name}!");
                }
                else if(uppgift == 6)
                {
                    Console.WriteLine("Skriv vad du vill så skriver jag ut det!");
                    string användarInput = Console.ReadLine();
                    Console.WriteLine($"Det här skrev du: {användarInput}");
                }
                else if(uppgift == 7)
                {
                    Console.WriteLine("Skriv vad du vill så skriver jag ut det 3 gånger!");
                    string användarInput = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(användarInput);
                    }
                }
                else if(uppgift == 8)
                {
                    Console.WriteLine("Vad är ditt namn?");
                    string namn = Console.ReadLine();
                    Console.WriteLine($"Välkommen {namn}!");
                }
                else if(uppgift == 9)
                {
                    Console.WriteLine("Hej, hur mår du idag?");
                    Console.ReadLine();
                    Console.WriteLine("Vad bra, vad ska du hitta på idag?");
                    Console.ReadLine();
                    Console.WriteLine("Vad roligt, ha det så kul!");
                }
                else if(uppgift == 10)
                {
                    Console.WriteLine("Hej, ge mig ett namn till huvudkaraktären i berättelsen");
                    string huvudKaraktär = Console.ReadLine();
                    Console.WriteLine("Kan du ge mig ett yrke till huvudkaraktären");
                    string huvudKaraktärYrke = Console.ReadLine();
                    Console.WriteLine($"Det var en gång en underlig varelse som hette {huvudKaraktär}. {huvudKaraktär} tyckte mycket om sitt jobb som {huvudKaraktärYrke}. {huvudKaraktär} har många vänner som också jobbar som {huvudKaraktärYrke} och dem har de väldigt roligt tillsammans på jobbet");
                }
                else if(uppgift == 11)
                {
                    int days = 200;
                    double hours = 3.5;
                    string coding = "It sure is!";
                    Console.WriteLine("Days to summer:");
                    Console.WriteLine(days);
                    Console.WriteLine("Hours to lunch:");
                    Console.WriteLine(hours);
                    Console.WriteLine("Coding is fun:");
                    Console.WriteLine(coding);
                }
                else if(uppgift == 12)
                {
                    Console.WriteLine("Ge mig ett heltal så skriver jag ut det");
                    int användarTal = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Ditt tal är {användarTal}!");
                }
                else if(uppgift == 13)
                {
                    Console.WriteLine("Ge mig ett decimaltal så skriver jag ut det");
                    double användarTal = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"Ditt tal är {användarTal}!");
                }
                else if(uppgift == 14)
                {
                    Console.WriteLine("Ge mig en boolean, true eller false?");
                    bool användarBoolean = Boolean.Parse(Console.ReadLine());
                    Console.WriteLine($"Det är {användarBoolean}!");
                }
                else if(uppgift == 15)
                {
                    Console.WriteLine("Ge mig en text!");
                    string användarText = Console.ReadLine();
                    Console.WriteLine("Ge mig ett heltal!");
                    int användarTal = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ge mig ett decimaltal!");
                    double användarDecimal = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Ge mig en boolean, true eller false?");
                    bool användarBoolean = Boolean.Parse(Console.ReadLine());
                    Console.WriteLine($"Din text är: {användarText}");
                    Console.WriteLine($"Ditt heltal är: {användarTal}");
                    Console.WriteLine($"Ditt decimaltal är: {användarDecimal}");
                    Console.WriteLine($"Din boolean är: {användarBoolean}");
                }
                else if(uppgift == 16)
                {
                    Console.WriteLine("Mata in ett visst antal dagar så gör jag om det till sekunder!");
                    int antalDagar = Int32.Parse(Console.ReadLine());
                    int dagarTillSekund = antalDagar * 24 * 3600;
                    Console.WriteLine($"{antalDagar} dagar är {dagarTillSekund} sekunder!");
                }
                else if(uppgift == 17)
                {
                    Console.WriteLine("Ge mig två stycken heltal!");
                    int heltal1 = Int32.Parse(Console.ReadLine());
                    int heltal2 = Int32.Parse(Console.ReadLine());
                    int summa = heltal1 + heltal2;
                    Console.WriteLine($"Summan av dina två heltal är {summa}");
                }
                else if(uppgift == 18)
                {
                    Console.WriteLine("Ge mig tre stycken heltal!");
                    int heltal1 = Int32.Parse(Console.ReadLine());
                    int heltal2 = Int32.Parse(Console.ReadLine());
                    int heltal3 = Int32.Parse(Console.ReadLine());
                    int summa = heltal1 + heltal2 + heltal3;
                    Console.WriteLine($"Summan av dina tre heltal är {summa}");
                }
                else if(uppgift == 19)
                {
                    Console.WriteLine("Ge mig två stycken heltal!");
                    int heltal1 = Int32.Parse(Console.ReadLine());
                    int heltal2 = Int32.Parse(Console.ReadLine());
                    int summa = heltal1 + heltal2;
                    Console.WriteLine($"{heltal1} + {heltal2} = {summa}");
                }
                else if(uppgift == 20)
                {
                    Console.WriteLine("Ge mig två stycken heltal!");
                    int heltal1 = Int32.Parse(Console.ReadLine());
                    int heltal2 = Int32.Parse(Console.ReadLine());
                    int summa = heltal1 * heltal2;
                    Console.WriteLine($"{heltal1} * {heltal2} = {summa}");
                }
                else if(uppgift == 21)
                {
                    Console.WriteLine("Ge mig två stycken heltal!");
                    int heltal1 = Int32.Parse(Console.ReadLine());
                    int heltal2 = Int32.Parse(Console.ReadLine());
                    double summa = heltal1 + heltal2;
                    double medelvärde1 = summa / 2;
                    Console.WriteLine($"Medelvärdet av dina tal är {medelvärde1}");
                }
                else if(uppgift == 22)
                {
                    Console.WriteLine("Ge mig tre stycken heltal!");
                    int heltal1 = Int32.Parse(Console.ReadLine());
                    int heltal2 = Int32.Parse(Console.ReadLine());
                    int heltal3 = Int32.Parse(Console.ReadLine());
                    double summa = heltal1 + heltal2 + heltal3;
                    double medelvärde1 = summa / 3;
                    Console.WriteLine($"Medelvärdet av dina tal är {medelvärde1}");
                }
                else if(uppgift == 23)
                {
                    Console.WriteLine("Ge mig ditt första tal!");
                    double tal1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Ge mig ditt andra tal!");
                    double tal2 = Double.Parse(Console.ReadLine());
                    double summa = tal1 + tal2;
                    double summa2 = tal1 - tal2;
                    double produkt = tal1 * tal2;
                    double kvot = tal1 / tal2;
                    Console.WriteLine($"{tal1} + {tal2} = {summa}");
                    Console.WriteLine($"{tal1} - {tal2} = {summa2}");
                    Console.WriteLine($"{tal1} * {tal2} = {produkt}");
                    Console.WriteLine($"{tal1} / {tal2} = {kvot}");
                }
                else if(uppgift == 24)
                {
                    Console.WriteLine("Hur snabbt kör du?");
                    int userSpeed = Int32.Parse(Console.ReadLine());
                    if(userSpeed > 120)
                    {
                        Console.WriteLine("Speeding!");
                    }
                    else
                    {
                        Console.WriteLine("Du kör lagligt");
                    }
                }
                else if(uppgift == 25)
                {
                    Console.WriteLine("Ge mig ett heltal");
                    
                }

                Console.WriteLine("Vill du se en ny uppgift?");
                villSpela = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Hejdå");
        }

        
    }
}
