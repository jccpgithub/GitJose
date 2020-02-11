using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo.Services
{
    public class PaisRepositorioEnMemoria: IRepositorioPais
    {
        public List<string> ObtenerTodos()
        {
            List<string> paises = new List<string>() { "España", "Mexico", "Francia","Alemania","Argentina" };
            return paises;
        }
    }
}
