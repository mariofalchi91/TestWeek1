using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_test_git
{
    public enum ApprovatoSiNo
    {
        APPROVATA,
        RESPINTA
    }
    public enum LvlApprovazione
    {
        Manager,
        OperationalManager,
        CEO
    }
    public class SpeseRimborsate
    {
        public DateTime DataSpesa { get; set; }
        public Categoria Categoria { get; set; }
        public string Descrizione { get; set; }
        public ApprovatoSiNo Approvato { get; set; }
        public LvlApprovazione Livello { get; set; }
        public double ImportoRimborsato { get; set; }
        public SpeseRimborsate() { }
        public SpeseRimborsate (DateTime data, Categoria categoria, string descrizione, ApprovatoSiNo approvato, LvlApprovazione lvl ,double importo)
        {
            DataSpesa = data;
            Categoria = categoria;
            Descrizione = descrizione;
            Approvato = approvato;
            Livello = lvl;
            ImportoRimborsato = importo;
        }
    }
}
