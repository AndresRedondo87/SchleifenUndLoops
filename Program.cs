using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchleifenUndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            ////----------------------------------------------------------------------------- FOR Loop
            //for (int zaehler = 1; zaehler <= 10; zaehler++)    //normal Zaehler
            //{
            //    Console.WriteLine("Normal-Zählerwert ist {0}", zaehler);
            //}

            //for (int zaehler = 10; zaehler >= 0; zaehler--)    //Countdown Zaehler
            //{
            //    Console.WriteLine("Countdown-Zählerwert ist {0}", zaehler);
            //}

            //Console.WriteLine("-----------");
            //for (int zaehler = 1; zaehler < 10; zaehler += 2)   //ungerade Zaehler
            //{
            //    Console.WriteLine("Ungerade-Zählerwert ist {0}", zaehler);
            //}
            //Console.WriteLine("---------------------");

            ////Andere Lösung für ungerade Zahlen
            //for (int zaehler = 1; zaehler < 16; zaehler++)    //normal Zaehler
            //{
            //    if (zaehler % 2 != 0)   //wenn nicht teilbar(es hat Rest) durch 2, dann ungerade
            //    {
            //        Console.WriteLine("Mein Ungerade-Zählerwert ist {0}", zaehler);

            //    }
            //}

            ////----------------------------------------------------------------------------- DO WHILE Loop

            //// 1. Zählervariable anlegen
            //int counter = 25;

            //Console.WriteLine("Klein Counter von 25 bis 30");
            //do
            //{
            //    Console.WriteLine(counter);
            //    // 3. Dafür sorgen, dass Bedingung irgendwann nicht mehr erfüllt ist. 
            //    counter++;
            //    // 2. Bedingung einfügen
            //} while (counter <= 30);

            //int lengthOfText = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.WriteLine("Bitte trage den Namen aller deine Freunde nacheinander ein: \n(insgesamt über 20 char zum beenden oder leer lassen)");
            //    string nameOfAFriend = Console.ReadLine();
            //    int currentLength = nameOfAFriend.Length;
            //    lengthOfText += currentLength;
            //    wholeText += nameOfAFriend;

            //    /// AR eigener test um schleife zu verlassen, es klappt, cool
            //    if (String.IsNullOrEmpty(nameOfAFriend))
            //        break;

            //} while (lengthOfText < 20);
            //Console.WriteLine("Danke, das reicht! Deine Freunde sind {0}", wholeText);




            ////Herausforderung: Noten von Schuler nacheinander eingeben, bis "-1" zum beenden eingetragen wird.
            ////Dann natuerlich alle anzeigen
            //string notenListe = string.Empty;//leer initialisieren
            //string neueNote = string.Empty;//leer initialisieren
            //do
            //{
            //    Console.WriteLine("Bitte trage die Noten nacheinander ein: \n(\"-1\" zum beenden)");

            //    neueNote = Console.ReadLine();
            //    // AR erweiterung Leere Eingaben mi zwei Streichen ersetzen, es klappt, cool
            //    neueNote = neueNote.Equals("") ? "--" : neueNote;

            //    notenListe = notenListe += " " + neueNote + " ";
            //} while (!neueNote.Equals("-1"));

            //Console.WriteLine("Danke, das reicht! Dien noten sind: {0}", notenListe);

            //Console.WriteLine("---------------------");



            ////-----------------------------------------------------------------------------  WHILE Loop
            //int counter2 = 0;
            //string enteredText = "";
            //// überprüfen ob enteredText ein leerer String ist
            //// AR hier ist es eigentlich nichtmal eingegeben, aber hat den leere wert schon default initialisiert, 
            //// so wir gehen in der While rein.
            //while (enteredText.Equals(""))
            //{
            //    Console.WriteLine("Bitte drücke Enter um, um eins hochzuzählen,\nOder gib etwas anderes ein, um die Zählung zu beenden");
            //    // Benutzereingabe
            //    enteredText = Console.ReadLine();

            //    //// AR Angepasst Zählen hoch vor den Anzeige, sonst nicht sauber
            //    //counter2++;
            //    //Console.WriteLine("Aktuelle Anzahl der Schüler im Bus: {0}", counter2);
            //    //////// Zählen hoch
            //    //////counter2++;
            //    ///
            //    //Verbesserung vorgeschlagen vom kollege und auch von ihm erweitert (ich nur zusammenintegriert)
            //    //weiter zaehlen wenn gultige eingabe,sonst nicht zahlen und einfach zu ende anzeige gehen
            //    if (enteredText == "")
            //    {
            //        Console.WriteLine("Aktuelle Anzahl der Schüler im Bus: {0}", ++counter2);
            //    }
            //    //kein else wegen abbruch
            //}
            //Console.WriteLine($"Im Bus sind {counter2} Schüler. \nEs kann losgehen. Drücke Enter um loszufahren");


            ////-------------------------------------------------- Break and Continue
            //for (int counter3 = 0; counter3 < 10; counter3++)
            //{

            //    //Console.WriteLine(counter3);//ganz am anfang
            //    if (counter3 == 8)
            //    {
            //        Console.WriteLine("bei 8 machen wir schluss!!");
            //        break;//endet das aktueller Loop
            //        Console.WriteLine("Nach ein break wird alles ignoriert!! Unerreichbare code!!");
            //    }

            //    if (counter3 % 2 == 0)
            //    {
            //        Console.WriteLine("Als nächstes kommt eine ungerade Zahl");
            //        continue;//macht weiter in das aktueller Loop.
            //        //es überspringt zu der nächste Durchlauf von dieser loop
            //        Console.WriteLine("Nach ein continue wird alles ignoriert!! Unerreichbare code!!");
            //    }

            //    if (counter3 == 5)
            //    {
            //        Console.WriteLine("FÜNF,Continue!!");
            //        continue;//macht weiter in das aktueller Loop.
            //        //es überspringt zu der nächste Durchlauf von dieser loop, so zu sagen wieder von anfang!
            //    }

            //    // BREAK und CONTINUE IMMER AM ENDE VON EINE CODEBLOCK!! WAS DARUNTER KOMMT IST UNERREICHBAR!!
            //    Console.WriteLine(counter3);
            //}
            ////-------------------------------------------------- Break and Continue Ende

            ////-------------------------------------------------- Herausforderung Loops - Durchschnitt
            //////Stelle Dir vor, Du seist ein Entwickler und bekommst einen Job, in dem Du ein Programm für einen Lehrer erstellen musst.
            //////Er braucht ein in c# geschriebenes Programm, das die durchschnittliche Punktzahl seiner Schüler berechnet. 
            //////Er möchte also jede Punktzahl einzeln eingeben können und dann nach Eingabe von -1 die endgültige Durchschnittspunktzahl erhalten.

            //////Das Tool sollte also prüfen, ob der Eintrag eine Zahl ist und diese zur Summe addieren. 
            //////Schließlich, wenn er fertig ist, sollte das Programm auf die Konsole schreiben, was die durchschnittliche Punktzahl ist.
            //////Die eingegebenen Zahlen sollten nur zwischen 1 und 6 liegen.Stellen Sie sicher, dass das Programm nicht abstürzt, 
            //////wenn der Lehrer einen falschen Wert eingibt.

            //////Teste Dein Programm gründlich. 
            /////


            //-------------------------------------------------- Herausforderung Loops - Durchschnitt 
            double noteInDouble, notenSumme=0, durchschnitt;
            int notenZaehler = 0;

            Console.WriteLine("Herausforderung Durchschnitt berechnen:");
            do
            {
                noteInDouble = notenEingabe();

                if((noteInDouble !=-2)&&(noteInDouble != -1))
                {
                    notenZaehler++;
                    notenSumme = notenSumme + noteInDouble;
                }
            } while (noteInDouble !=-1);

            // um Fehler zu vermeiden, kein dirch zero te
            if(notenZaehler > 0)
            {
                durchschnitt = durchschnittBerechnen(notenSumme, notenZaehler);
                Console.WriteLine($"Die Durchschnitt von den NotenSumme {notenSumme} von den {notenZaehler} Noten ist: {durchschnitt}");
            }
            else
            {
                Console.WriteLine($"Die Durchschnitt von KEINE Gültige Noten kann nicht berechnet werden!!!");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Saubere Eingaben kriegen (-2 als ungültige eingabe verwendet)
        /// </summary>
        /// <returns></returns>
        static double notenEingabe()
        {
            string neueNote = string.Empty; //leer initialisieren
            double inputInDouble = 0;
            bool validZahl = false;

            Console.WriteLine("Bitte tragen Sie die Noten ein [von 1 bis 6](\"-1\" zum beenden):");

            neueNote = Console.ReadLine();
            // AR erweiterung Leere Eingaben mi zwei Streichen ersetzen, es klappt, cool
            validZahl = double.TryParse(neueNote, out inputInDouble);

            if (validZahl)
            {
                return inputInDouble;
            }
            else
            {
                Console.WriteLine("Geben Sie Bitte nur gültige Noten ein!![von 1 bis 6](\"-1\" zum beenden):");
                return inputInDouble = -2;
            }
        }
        static public double durchschnittBerechnen(double summe, int zahl)
        {
            return summe / zahl;
        }
        //-------------------------------------------------- Herausforderung Loops - Durchschnitt  ENDE
    }
}
