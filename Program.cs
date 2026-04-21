using System;
using System.Collections.Generic;


class Programm
{
    static void Main(string[] args)
    {

        List<Robot> roboter = new List<Robot>();

        Robot robby = new Robot("Robby", 100);
        robby.Status();

        Robot ralph = new Robot("Ralph", 100);
        ralph.Status();

        Robot dave = new Robot("Dave", 100);
        dave.Status();

        roboter.Add(robby);
        roboter.Add(ralph);
        roboter.Add(dave);

        Console.WriteLine("Wähle einen Roboter aus.");
        Console.WriteLine("1: Robby");
        Console.WriteLine("2: Ralph");
        Console.WriteLine("3: Dave");



        int auswahlRobot = Convert.ToInt32(Console.ReadLine());
        Robot aktuellerRoboter = roboter[auswahlRobot - 1];

        bool showMenu = true;
        while (showMenu)
        {

            Console.WriteLine("Geben Sie bitte eine Zahl ein.");
            Console.WriteLine("1: aktuellerRoboter Status anzeigen");
            Console.WriteLine("2: aktuellerRoboter putzen lassen");
            Console.WriteLine("3: aktuellerRoboter einkaufen lassen");
            Console.WriteLine("4: aktuellerRoboter schlafen lassen");
            Console.WriteLine("5: aktuellerRoboter reparieren lassen");
            Console.WriteLine("6: aktuellerRoboter aufladen lassen");
            Console.WriteLine("0: Beenden");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {


                case 1:
                    aktuellerRoboter.Status();
                    break;

                case 2:
                    aktuellerRoboter.Putzen();
                    break;

                case 3:
                    aktuellerRoboter.Einkaufen();

                    break;

                case 4:
                    aktuellerRoboter.Schlafen();

                    break;

                case 5:
                    aktuellerRoboter.Reparieren();

                    break;

                case 6:
                    aktuellerRoboter.Aufladen();

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
                aktuellerRoboter.Status();
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

    public bool HatGenugAkku(int kosten)
    {
        if (Akku > kosten)
        {
            Akku -= kosten;
            return true;
        }
        else
        {
            Console.WriteLine("Akku zu niedrig, bitte laden!");
            return false;
        }
    }

    public void Status()
    {
        Console.WriteLine($"Name: {Name}, Akku: {Akku}");
    }

    public void Putzen()
    {
        if (HatGenugAkku(20))
        {
            Console.WriteLine("Robby putzt die Wohnung.");
        }
    }




    public void Einkaufen()
    {
        if (HatGenugAkku(20))
        {
            Console.WriteLine("Robby geht einkaufen.");
        }
    }
    public void Schlafen()
    {
        if (HatGenugAkku(5))
        {
            Console.WriteLine("Robby schläft.");
        }
    }
    public void Reparieren()
    {
        if (HatGenugAkku(5))
        {
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