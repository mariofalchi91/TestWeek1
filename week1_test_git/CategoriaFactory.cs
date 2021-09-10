using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week1_test_git.Importi;

namespace week1_test_git
{
    public class CategoriaFactory
    {
        public Categoria TipoCategoria { get; set; }
        public CategoriaFactory (Categoria C)
        {
            TipoCategoria = C;
        }
        public ITipo Crea()
        {
            ITipo t = null;
            switch(TipoCategoria)
            {
                case Categoria.Vitto: t = new Vitto(); break;
                case Categoria.Alloggio: t = new Alloggio(); break;
                case Categoria.Viaggio: t = new Viaggio(); break;
                case Categoria.Altro: t = new Altro(); break;
            }
            return t;
        }
    }
}
