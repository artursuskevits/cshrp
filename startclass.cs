using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshrp
{
    public class startclass
    {
        public static void Main(string[] args)
        {

            
            try
            {
                StreamWriter textik = new StreamWriter(@"..\..\..\text.txt",true);
                string lause = "=)\n";
                textik.WriteLine(lause);
                textik.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga!");
            }

            try
            {
                StreamReader text = new StreamReader(@"..\..\..\text.txt", true);
                string laused = text.ReadToEnd();
                text.Close();
                


            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga!");
            }
            List<string> textlist = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\text.txt"))
                {
                    textlist.Add(rida);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga!");
            }
            foreach (var rida in textlist)
            {
                Console.WriteLine(rida);
            }


            /*
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp = Console.ReadKey();
            } while (nupp.Key != ConsoleKey.Backspace);
            */
            /*
            List<inimine> list = new List<inimine>();
            Dictionary<int,string> dic = new Dictionary<int,string>(5);
            dic.Add(1, "üks");
            dic.Add(2, "kaks");
            dic.Add(3, "kolm");
            dic.Add(4, "neli");
            dic.Add(5, "viis");
            foreach (KeyValuePair<int,string> keyValue in dic)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }
            Dictionary<int, inimine> iniminedic = new Dictionary<int, inimine>();
            iniminedic.Add(1, new inimine() { Nimi = "Alina", Vanus = 17 });
            iniminedic.Add(2, new inimine() { Nimi = "Andrei", Vanus = 17 });
            iniminedic.Add(3, new inimine() { Nimi = "Genadiy", Vanus = 17 });
            iniminedic.Add(4, new inimine() { Nimi = "Vlad", Vanus = 17 });
            foreach (inimine item in iniminedic.Values)
            {
                Console.WriteLine(item.Nimi+" "+item.Vanus);
            }
            
            foreach (KeyValuePair<int, inimine> keyvalue in iniminedic)
            {
                Console.WriteLine(keyvalue.Key + "-" + keyvalue.Value.Nimi + " " + keyvalue.Value.Vanus);
            }
            */
            //inimine inimene = new inimine();
            //inimene.Nimi = "Mati";
            //inimene.Vanus = 65;
            //list.Add(inimene);
            //list.Add(new inimine() { Nimi = "Kati" });

            //foreach (inimine item in list)
            //{
            //    Console.WriteLine(item.Nimi);
            //}

            /*ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimine");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            int prikol =Convert.ToInt32(arrayList.IndexOf("Teine") + 1);
            if (arrayList.Contains("Teine"))
            {
                Console.WriteLine("ok");
                Console.WriteLine("Teine asub kohal " + prikol.ToString());
            }
            else
            {
                Console.WriteLine("wrong command");
            }
            Console.WriteLine("Kokku jarjendis on "+arrayList.Count+ " elemente");
            arrayList.Insert(3, "Neljas");
            arrayList.Insert(4, "Viies");
            arrayList.Sort();
            foreach (string item in arrayList)
            {
                Console.Write(item + ", ");
            }
            arrayList.RemoveAt(0);
            arrayList.Remove("Viies");
            Console.WriteLine("\n");
            foreach (string item in arrayList)
            {
                Console.Write(item + ", ");
            }
            arrayList.Clear();
            */

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
            Console.WriteLine("Arv 1: ");
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
            /*
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
            */
            /*
            Console.WriteLine("kirjuta esimine arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta teine arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta kolmas arv");
            int arv3 = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta neljas arv");
            int arv4 = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta viies arv");
            int arv5 = int.Parse(Console.ReadLine());
            int[] numbers = new int[5];
            numbers[0] = arv1;
            numbers[1] = arv2;
            numbers[2] = arv3;
            numbers[3] = arv4;
            numbers[4] = arv5;
            int summ = arv1 + arv2 + arv3 + arv4 + arv5;
            int keskmine = (arv1 + arv2 + arv3 + arv4 + arv5) / 5;
            int korrutis= arv1*arv2*arv3* arv4 * arv5;
            Console.WriteLine("summa: " + summ);
            Console.WriteLine("keskmine: " + keskmine);
            Console.WriteLine("korritus: " + korrutis);
            */

            //string answer = "0";
            //while (answer != "elephant")
            //{
            //    Console.WriteLine("Osta elevant ära!");
            //    answer = Console.ReadLine();
            //}
            //string answer;
            //do
            //{
            //    Console.WriteLine("Osta elevant ära!");
            //    answer = Console.ReadLine();
            //} while (answer != "elephant");

            /*
            Random rnd = new Random();
            int nr = rnd.Next(0, 9);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("krijuta arv ");
                int answer = int.Parse(Console.ReadLine());
                if (nr==answer)
                {
                    Console.WriteLine("oige!");
                }
                
            }
            Console.WriteLine("arvuti arv on " + nr);  
            */
            /*
            Console.WriteLine("kirjuta esimine arv");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta teine arv");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta kolmane arv");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta nelja arv");
            int d = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int> { a, b, c, d };
            int maxNumber = numbers.Max();
            numbers.Remove(maxNumber);
            int secondNumber = numbers.Max();
            numbers.Remove(secondNumber);
            int thirdNumber = numbers.Max();
            numbers.Remove(thirdNumber);
            int fourthNumber = numbers.Max();
            numbers.Remove(fourthNumber);
            string result = maxNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString() + fourthNumber.ToString();
            Console.WriteLine(Convert.ToInt32(result));
            */

            /*
            for (int i = 1; i <= 10; i++)
            {
                
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
              
            }
            */

            //string name = "Python";
            //alamprog.TERE(name);
            //int a = 12;
            //int b = 13;
            //int vastus =alamprog.Korruta(a, b);
            ////Console.WriteLine(vastus);
            ////Console.WriteLine(alamprog.Korruta(5, 6));
            ////double c= alamprog.Keskmine();
            ////Console.WriteLine(c);
            //string c=alamprog.murr(12, 3,'*');
            //Console.WriteLine(c);

            //alamprog.stars(12);
            //alamprog.ultrastars();
        }

    }
}
