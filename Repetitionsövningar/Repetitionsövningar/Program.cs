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
                    Console.WriteLine("Ge mig ett nummer så skriver jag ut det");
                }

                Console.WriteLine("Vill du se en ny uppgift?");
                villSpela = Console.ReadLine().ToLower();
            }
        }
    }
}
