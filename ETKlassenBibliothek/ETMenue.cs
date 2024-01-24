﻿namespace ETKlassenBibliothek;
using Figgle;

public class ETMenue
{
    public static void ETSubMenue()
    {
        bool Exit = false;

        do
        {
            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("Elektrotechnik"));

            //Konsolentitel wird geändert.
            Console.Title = "BFTMultiTool";

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                "                              >>> ET-Submenue <<<\n" +
                                "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

            //Beschreibung der Software.
            Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

            string HauptAusw;


            //Eingabeaufforderung 
            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\t1 - Spannungsfall");
            Console.WriteLine("\ti - Informatik");
            Console.WriteLine("\tm - Mathematik");
            Console.WriteLine("\tp - Physik");
            Console.WriteLine("\tw - Wirtschaft\n");
            Console.Write("Eingabe:");
            HauptAusw = Console.ReadLine().ToLower();

            switch (HauptAusw)
            {
                case "1":
                    Console.Clear();
                    //Hier das Etechnikmenü aufrufen
                    
                    break;

                case "i":
                    Console.Clear();
                    //Hier das Informationstechnikmenü aufrufen
                    break;

                case "m":
                    Console.Clear();
                    //Hier das Mathematikmenü aufrufen
                    break;

                case "p":
                    Console.Clear();
                    //Hier das Physikmenü aufrufen
                    break;

                case "w":
                    Console.Clear();
                    //Hier das Wirtschaftsmenü aufrufen
                    break;

                case "exit":
                    Exit = true;
                    break;
                default:

                    Console.WriteLine("Ungültige Eingabe");
                    Console.ReadKey();

                    (int, int) cPosAM = Console.GetCursorPosition();

                    KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                    break;
            }

        } while (!Exit);

    }

}