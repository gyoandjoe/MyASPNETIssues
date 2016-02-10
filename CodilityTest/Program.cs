using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTest
{
    public class pit
    {
        public List<int> DecreaseList = new List<int>();
        //public List<int> DecreaseList = new List<int>();
    }

    public class SolutionTask3
    {
        public List<int> checkLeft(int[] A,int indexCandidate)
        {
            List<int> result = new List<int>();
            for (int index = indexCandidate; index > 0; index--)
            {
                if (A[index - 1] > A[index])
                {
                    result.Add(A[index - 1]);
                }
                else
                    break;
            }
            if (result.Count == 0)
                return null;
            else
                return result;
        }

        public List<int> checkRight(int[] A, int indexCandidate)
        {
            List<int> result = new List<int>();
            for (int index = indexCandidate; index < A.Length - 1; index++)
            {
                if (A[index] < A[index + 1])
                {
                    result.Add(A[index + 1]);
                }
                else
                    break;
            }
            if (result.Count == 0)
                return null;
            else
                return result;
        }

        public int Task3(int[] A)
        {
            var pitResults = new List<Int64>();
            for (int cont = 0; cont < A.Length; cont++)
            {
                var resultL = checkLeft(A, cont);
                if (resultL != null)
                {
                    var resultR = checkRight(A, cont);
                    if (resultR != null)
                    {
                        var resultFirstL = resultL.LastOrDefault() - A[cont];
                        var resultLastR =  resultR.FirstOrDefault() - A[cont];
                        
                        if (resultFirstL > resultLastR)
                        {
                            pitResults.Add(resultLastR);
                        }
                        else
                            pitResults.Add(resultFirstL);
                    }
                }
                

            }
            return (int) (pitResults.Count() != 0 ? pitResults.Max() : -1) ;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            TAsk3();
            //Task1();
        }

        public static void TAsk3()
        {
            SolutionTask3 sl = new SolutionTask3();
            int[] A = { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };
            Console.WriteLine(sl.Task3(A));
            Console.ReadKey();
        }

        //public static3 

        public static int Task1()
        {
            var L = new IntList();
            var B = new IntList();
            var C = new IntList();
            var D = new IntList();

            L.next = B;
            B.next = C;
            C.next = D;


            var currentItem = L;
            int counter = 1;
            while (true)
            {
                if (currentItem.next != null)
                {
                    counter++;
                    currentItem = currentItem.next;
                }
                else
                    break;
            }
            return counter;
            Console.WriteLine(counter);
            Console.ReadKey();
        }


        public static void SampleTest()
        {
            var result = Samplesolution(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int Samplesolution( int[] A)
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

    class IntList
    {
        public int value;
        public IntList next;
    };


}
