using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int solution( int[] A)
        {
            var noTotalItems = A.Length;
            Int64 index = 0;
            Int64 sumPart1, sumPart2;
            List<int> indicesEquilibrados = new List<int>();

            for (int equilibriumCandidateIndex = 0; equilibriumCandidateIndex < noTotalItems; equilibriumCandidateIndex++)
            {
                //Debemos checar para cada Index si es o no un indice equilibrado
                index = 0;
                sumPart2 =  sumPart1 = 0;
                foreach (var item in A)
                {
                    if (index < equilibriumCandidateIndex)
                    {
                        sumPart1 = sumPart1 + item;
                    }
                    else if (index > equilibriumCandidateIndex)
                    {
                        sumPart2= sumPart2 + item;
                    }
                    index++;
                }

                if (sumPart1 == sumPart2)
                {
                    indicesEquilibrados.Add(equilibriumCandidateIndex);
                    break;
                }

                
            }

            return (indicesEquilibrados.Any() ? indicesEquilibrados.FirstOrDefault() : -1);


        }
    }


}
