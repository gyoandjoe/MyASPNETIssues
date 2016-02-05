using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengCSharp.POO
{
    public class Elefante : Animal
    {
        public override string Caminar()
        {
            Console.WriteLine("Elefante Caminando");
            //base.Caminar();
            return "Elefante Caminando";

        }
    }
}
