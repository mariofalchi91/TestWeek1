using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week1_test_git.ChainOfRespo;

namespace week1_test_git
{
    public enum Categoria 
    {
        Viaggio,
        Alloggio,
        Vitto,
        Altro
    }
    public class Spese
    {
        public DateTime DataSpesa { get; set; }
        public Categoria Categoria {get;set;}
        public string Descrizione { get; set; }
        public double Importo { get; set; }
        public Spese() { }
        public Spese (DateTime data, Categoria categoria, string descrizione, double importo)
        {
            DataSpesa = data;
            Categoria = categoria;
            Descrizione = descrizione;
            Importo = importo;
        }
        public static void GestisciNuovoFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Gestione dell'evento {e.ChangeType} sul file {e.Name}");
            string p = e.FullPath;
            List<Spese> spese= LoadFromFile(p);
            List<SpeseRimborsate> speseElaborate= Determina(spese);
            WriteFile(speseElaborate);
        }

        private static List<SpeseRimborsate> Determina(List<Spese> spese)
        {
            //determina livello di approvazione 
            List<SpeseRimborsate> speseElaborate = new();
            IHandler manager = new ManagerHandler();
            IHandler opManager = new OperationalManagerHandler();
            IHandler ceo = new CeoHandler();
            manager.SetNext(opManager).SetNext(ceo);
            //non sono riuscito a farlo, o l'avrei fatto senza la chain of responsability
            return speseElaborate;
        }

        private static void WriteFile(List<SpeseRimborsate> spese)
        {
            //scrivi
        }

        public static List<Spese> LoadFromFile(string fullpath)
        {
            Console.WriteLine($"carico i dati da {fullpath}");
            List<Spese> spese = new List<Spese>();
            try
            {
                using StreamReader reader = File.OpenText(fullpath);
                while (reader.ReadLine() != null)
                {
                    string[] campi = reader.ReadLine().Split(";");
                    DateTime.TryParse(campi[0], out DateTime D);
                    Categoria.TryParse(campi[1], out Categoria C);
                    string S = campi[2];
                    double.TryParse(campi[3], out double I);
                    Spese tmp = new Spese(D, C, S, I);
                    spese.Add(tmp);
                }

            }
            catch (IOException ioe) { Console.WriteLine($"errore {ioe.Message}"); }
            catch (Exception ex) { Console.WriteLine($"errore {ex.Message}"); }
            return spese;
        }
    }
}
