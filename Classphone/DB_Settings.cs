using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Classphone
{
    class DB_Settings
    {
        public static bool Language;                                                        // Se [TRUE] é italiano. Se [FALSE] é inglese
        public static string Zone;
        public static string DeviceName;
        public static string TypeOfLockScreen;                                              //Variabile per il tipo di blocco schermo [PIN/PWD/SEQUENCE/TAP]
        public static string ValueOfLockScreen;                                             //Variabile per il valore del blocco schermo [PIN/Password]
        public static List<int> ValutOfLockScren = new List<int>();                         //Lista di interi per la sequenza

        public static string BackgroundColor = "White";                                     

        public static List<ContactClass> ListOfContacts = new List<ContactClass>();         //Lista di oggetti per i contatti

        
        
        public static void ReloadFile()
        {
            string docPath = AppDomain.CurrentDomain.BaseDirectory;                         //Prendo il Path del file classphone.exe
            docPath = Path.Combine(docPath, "config.txt");                                  

            System.IO.File.WriteAllText(docPath, string.Empty);                             //Pulisco il file

            string Pattern = "";
            if (DB_Settings.TypeOfLockScreen == "SEQUENCE")                                 //controllo il tipo di blocco schermo
            {
                foreach (var s in DB_Settings.ValutOfLockScren)                             //Prende la lista della sequenza e lo aggiunge alla variabile stringa
                {
                    Pattern = Pattern + s.ToString();
                }
                using (StreamWriter sw = new StreamWriter(docPath, true)) //scrivo su file tutti i parametri separati tra loro in sequenza
                {
                    sw.Write(
                        "Settings{\n" +
                        "Lingua:" + DB_Settings.Language + "¬\n" +
                        "Zona:" + DB_Settings.Zone + "¬\n" +
                        "DeviceName:" + DB_Settings.DeviceName + "¬\n" +
                        "TipoLockScreen:" + DB_Settings.TypeOfLockScreen + "¬\n" +
                        "ValueLockScreen:" + Pattern + "¬\n" +
                        "BackColor:" + DB_Settings.BackgroundColor + "¬\n" +
                        "}\n" +
                        "Contact{\n");
                    if (!ListOfContacts.Any())                            //Controllo se la lista dei contatti é vuota
                        sw.Write("¬\n}");
                    else
                    {
                        foreach (var s in ListOfContacts)                   //foreach delle lista per inserire i contatti nel file
                        {
                            sw.Write(
                            "[\n" +
                            "Nome:" + s.name + "¬\n" +
                            "Cognome:" + s.surname + "¬\n" +
                            "Cell:" + s.number + "¬\n" +
                            "]\n"
                            );
                        }
                        sw.Write("}");
                        
                    }

                    sw.Flush();
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter sw = new StreamWriter(docPath, true))
                {
                    sw.Write(
                        "Settings{\n" +
                        "Lingua:" + DB_Settings.Language + "¬\n" +
                        "Zona:" + DB_Settings.Zone + "¬\n" +
                        "DeviceName:" + DB_Settings.DeviceName + "¬\n" +
                        "TipoLockScreen:" + DB_Settings.TypeOfLockScreen + "¬\n" +
                        "ValueLockScreen:" + DB_Settings.ValueOfLockScreen + "¬\n" +
                        "BackColor:" + DB_Settings.BackgroundColor + "¬\n" +
                        "}\n" +
                        "Contact{\n");
                    if (!ListOfContacts.Any())
                        sw.Write("¬\n}");
                    else
                    {
                        foreach (var s in ListOfContacts)
                        {
                            sw.Write(
                            "[\n" +
                            "Nome:" + s.name + "¬\n" +
                            "Cognome:" + s.surname + "¬\n" +
                            "Cell:" + s.number + "¬\n" +
                            "]\n"
                            );
                        }
                        sw.Write("}");

                    }

                    sw.Flush();
                    sw.Close();
                }
            }
        }

    }
}
