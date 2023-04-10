using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshrp
{
    public class startclass
    {
        public static void Main(string[] args)
        {
            //    string paev = "";
            //    Random rnd = new Random();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        int nr = rnd.Next(1, 7);
            //        Console.WriteLine(nr);
            //        switch (nr)
            //        {
            //            case 1: paev = "Esmaspaev"; break;
            //            case 2: paev = "Teisepaev"; break;
            //            case 3: paev = "Kolmapaev"; break;
            //            case 4: paev = "Neljapaev"; break;
            //            case 5: paev = "Reede"; break;
            //            case 6: paev = "Laupaev"; break;
            //            case 7: paev = "Pihapaev"; break;
            //            default:
            //                paev = "Tundmatupaev";
            //                break;
            //        }
            //        Console.WriteLine(paev);

            //    }
            //    int j = 0;
            //    while (j < 10)
            //    {
            //        Console.WriteLine(paev);
            //        j++;
            //    }
            //    do
            //    {
            //        Console.WriteLine(j +paev);
            //        j--;
            //    } while (j!=0);


            /*Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("kui vana sa oled?");
                int aeg = int.Parse(Console.ReadLine());
                if (aeg < 6 && aeg > 0)
                {
                    Console.WriteLine("pilet on tauta");
                }
                else if (aeg < 14 && aeg >=  6)
                {
                    Console.WriteLine("lastepilet");
                }
                else if (aeg < 65 && aeg >= 15)
                {
                    Console.WriteLine("täispilet");
                }
                else if (aeg < 100 && aeg >= 65)
                {
                    Console.WriteLine("sooduspilet");
                }
                else
                {
                    Console.WriteLine("viga");
                }

            }
            else
            {
                Console.WriteLine("Ma ootan juku!");
            }
            */

            /*Console.WriteLine("Arv 1: ");

            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tehe: ");
            char tehe = char.Parse(Console.ReadLine());
            if (tehe == '+')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrduub {2}", arv1, arv2, arv1 + arv2);
            }
            else if (tehe == '-')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrduub {2}", arv1, arv2, arv1 - arv2);
            }
            */
            /*
            Console.WriteLine("esimine nimi: ");
            string eesnimi1 = Console.ReadLine();
            Console.WriteLine("teine nimi: ");
            string eesnimi2 = Console.ReadLine();
            if (eesnimi1.ToLower() == "artur" || eesnimi1.ToLower() == "artur" )
            {
                Console.WriteLine(eesnimi1 + " ja " + eesnimi2 + " istuga koos");
            }
            else
            {
                Console.WriteLine("Viga");
            }
            */

            /*Console.WriteLine("a: ");
            string eesnimi1 = Console.ReadLine();
            Console.WriteLine("b: ");
            string eesnimi2 = Console.ReadLine();
            */
            /*Random rnd = new Random();
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(-100, 100);
            }
            foreach(int item in arvud)
            {
                if (item<0)
                {
                    Console.Beep();
                }
                Console.WriteLine(item);
            }
            */
            Random rnd = new Random();
            int arv1 = rnd.Next(-10, 20);
            int arv2 = rnd.Next(-10,20);
            Console.WriteLine(arv1);
            Console.WriteLine(arv2);
            Console.WriteLine("arv1 ruut on" + arv1*arv1);
            Console.WriteLine("arv2 ruut on"+ arv2 * arv2);
            Console.WriteLine("Pause");

            if (arv1>arv2)
            {
                if (arv1 > 0 && arv2 > 0)
                {
                    int arv3 = Math.Abs(arv1) - Math.Abs(arv2);
                    int[] arvud = new int[arv3+1];
                    for (int i = 0; i < arvud.Length; i++)
                    {
                        arvud[i] = arv1 - i;
                    }

                    for (int i = 0; i < arvud.Length; i++)
                    {
                        Console.WriteLine(arvud[i]);
                        
                    }
                }
                else if (arv2 < 0)
                {
                    int arv3= arv1 + Math.Abs(arv2);
                    int[] arvud = new int[arv3+1];
                    for (int i = 0; i < arvud.Length; i++)
                    {
                        arvud[i] = arv2  + i;
                    }
                    for (int i = 0; i < arvud.Length; i++)
                    {
                        Console.WriteLine(arvud[i]);

                    }

                }
                


            }
            else if (arv2>arv1)
            {
                if (arv1 > 0 && arv2 > 0)
                {
                    int arv3 = Math.Abs(arv2) - Math.Abs(arv1);
                    int[] arvud = new int[arv3+1];
                    for (int i = 0; i < arvud.Length; i++)
                    {
                        arvud[i] = arv2  - i;
                    }
               
                for (int i = 0; i < arvud.Length; i++)
                {
                    Console.WriteLine(arvud[i]);
                }
                }
                else if (arv1 < 0)
                {
                    int arv3 = arv2 + Math.Abs(arv1);
                    int[] arvud = new int[arv3+1];
                    for (int i = 0; i < arvud.Length; i++)
                    {
                        arvud[i] = arv1 + i;
                    }
                    for (int i = 0; i < arvud.Length; i++)
                    {
                        Console.WriteLine(arvud[i]);

                    }

                }
            }
            else if (arv2==arv1)
            {
                int[] arvud = new int[1];
                arvud[0] = arv1;
                for (int i = 0; i < arvud.Length; i++)
                {
                    arvud[i] = arv1;
                }
                for (int i = 0; i < arvud.Length; i++)
                {
                    Console.WriteLine(arvud[i]);
                }
            }
            

        }


    }
}
