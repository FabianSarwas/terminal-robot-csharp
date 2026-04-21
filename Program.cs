using System;



class Programm
{
    static void Main(string[] args)
    {
        Robot robby = new Robot("Robby", 100);
        robby.Status();

        bool showMenu = true;
        while (showMenu)
        {
            Console.WriteLine("Geben Sie bitte eine Zahl ein.");
            Console.WriteLine("1: Robby Status anzeigen");
            Console.WriteLine("2: Robby putzen lassen");
            Console.WriteLine("3: Robby einkaufen lassen");
            Console.WriteLine("4: Robby schlafen lassen");
            Console.WriteLine("5: Robby reparieren lassen");
            Console.WriteLine("6: Robby aufladen lassen");
            Console.WriteLine("0: Beenden");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {


                case 1:
                    robby.Status();
                    break;

                case 2:
                    robby.Putzen();
                    break;

                case 3:
                    robby.Einkaufen();

                    break;

                case 4:
                    robby.Schlafen();

                    break;

                case 5:
                    robby.Reparieren();

                    break;

                case 6:
                    robby.Aufladen();

                    break;

                case 0:
                    showMenu = false;
                    Console.WriteLine("Programm beendet");
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }

            if (auswahl >= 2 && auswahl <= 6)
            {
                robby.Status();
            }

        }
    }
}
class Robot
{
    public string Name { get; set; }
    public int Akku { get; set; }

    public Robot(string name, int akku)
    {
        Name = name;
        Akku = akku;
    }


    public void Status()
    {
        Console.WriteLine($"Name: {Name}, Akku: {Akku}");
    }

    public void Putzen()
    {


        if (Akku < 20)
        {
            Console.WriteLine("Akku zu niedrig, bitte aufladen.");
        }
        else
        {
            Akku -= 20;
            Console.WriteLine("Robby putzt die Wohnung.");
        }
    }




    public void Einkaufen()
    {
        if (Akku < 20)
        {
            Console.WriteLine("Akku zu niedrig, bitte aufladen.");
        }
        else
        {
            Akku -= 20;
            Console.WriteLine("Robby geht einkaufen.");
        }
    }

    public void Schlafen()
    {
        if (Akku < 5)
        {
            Console.WriteLine("Akku zu niedrig, bitte aufladen.");
        }
        else
        {
            Akku -= 5;
            Console.WriteLine("Robby schläft.");
        }
    }

    public void Reparieren()
    {
        if (Akku < 5)
        {
            Console.WriteLine("Akku zu niedrig, bitte aufladen.");
        }
        else
        {
            Akku -= 5;
            Console.WriteLine("Robby repariert sich selbst.");
        }
    }

    public void Aufladen()
    {
        Akku += 20;
        if (Akku > 100)
        {
            Akku = 100;
        }

        Console.WriteLine("Robby wird aufgeladen.");
    }

}