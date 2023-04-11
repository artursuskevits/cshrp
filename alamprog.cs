using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cshrp
{
    public class alamprog
    {
        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }

        public static void TERE(string nimi)
        {
            Console.WriteLine("Tere {0}", nimi);
        }

        public static double Keskmine()
        {
            double retarv = 0;
            Console.WriteLine("kui palju nubereid");
            int kord = int.Parse(Console.ReadLine());
            for (int i = 0; i < kord; i++)
            {
                Console.WriteLine("kirjuta arv");
                int answer = int.Parse(Console.ReadLine());
                retarv += answer;
            }
            retarv = retarv / kord;
            return retarv;

        }
        public static string murr(int arv1, int arv2,char tehe)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            int j = Convert.ToInt32(table.Compute(arv1.ToString()+tehe.ToString()+arv2.ToString(),String.Empty));

            string murrcounter = "";
            for (int i = 0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                murrcounter += "*";
            }
            return murrcounter;
        }
        public static void stars(int arv1)
        {
            string starscounter = "";
            for (int i = 0; i < arv1; i++)
            {
                starscounter += "*";
            }
            Console.WriteLine(starscounter);
        }

        public static void ultrastars()
        {
            int kuiplaju = 0;
            //string starscounter = "";
            Console.WriteLine("kui palju korda");
            int kord = int.Parse(Console.ReadLine());
            for (int i = 0; i < kord; i++)
            {
                string starscounter = "";
                Console.WriteLine("kui palju tähti soovite näha");
                kuiplaju= int.Parse(Console.ReadLine());
                for (int j = 0; j < kuiplaju; j++)
                {
                    starscounter += "*";
                }
                Console.WriteLine(starscounter);
            }
        }
    }
}
