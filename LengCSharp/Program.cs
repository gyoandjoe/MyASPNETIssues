using LengCSharp.POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Elefante elef = new Elefante();
            //elef.Caminar();
            Animal elef2 = new Elefante();
            //elef2.Caminar();
            Animal animal = elef2;

            //var p = new Planeta();
            //Error
            //Elefante elef3 = new Animal();
            //elef3.Caminar();


            Console.ReadKey();
        }

        #region Test Yield

        public static void TestYield()
        {

            foreach (var item in ObtenerPares(0, 5))
            {
                Console.WriteLine(item);
            }
            foreach (var item in ObtenerParesWithYield(0, 5))
            {
                Console.WriteLine(item);
            }
        }

    /// <summary>
    /// en una iteracion primero Se obtiene toda la lista completa y se regresa a quien itera 
    /// </summary>
    /// <param name="inicio"></param>
    /// <param name="fin"></param>
    /// <returns></returns>
        public static IEnumerable<int> ObtenerPares(int inicio, int fin)
        {
            List<int> pares = new List<int>();
            for (int i = inicio; i <= fin; i++)
                if ((i % 2) == 0)
                    pares.Add(i);
            return pares;
        }

        /// <summary>
        /// en una iteracion como un foreach no obtiene toda la lista completa sino que uno por uno segun se vaya necesitando
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public static IEnumerable<int> ObtenerParesWithYield(int inicio, int fin)
        {
            for (int i = inicio; i <= fin; i++)
                if ((i % 2) == 0)
                    yield return i;
        }
        #endregion
    }
}
