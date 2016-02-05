using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengCSharp.POO
{
    
    public class Animal
    {
        /// <summary>
        /// Con virtual podemos especificar que este metodo puede ser sobre escrito en clases derivadas
        /// </summary>
        public virtual string Caminar()
        {
            Console.WriteLine("Animal caminando");
            return "Animal Corriendo";
        }
    }
}
