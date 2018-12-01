using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaizQuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            long numeroDeLinhas = 2;
            double X = 0;
            double S = 0, E = 0;
            double M = 0;
            double e = 0.000000000000001;

            while ((line = Console.ReadLine()) != null)
            {
                X = Convert.ToInt64(line);
                E = X;
                while ((E - S) > e)
                {
                    M = (S + E) / 2;

                    if ((M * M) > X)
                    {
                        E = M;
                    }
                    else
                    {
                        S = M;
                    }
                }
                Console.WriteLine("{0}: {1}", X, M.ToString("#.000"));

                numeroDeLinhas--;
                if (numeroDeLinhas == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Fim da entrada");
            Console.ReadKey();
        }
    }
 }
