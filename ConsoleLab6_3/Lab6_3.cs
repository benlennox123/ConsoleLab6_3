using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6_3
{
    class Lab6_3
    {
        static void Main(string[] args)
        {
            string Text1 = "Привет, {дом яблоко}эта{ипотека} {телефон ноутб}}}ук, красный}программа{человек{  чтобы} {само}кат} дверь}работает!";
            Console.WriteLine(Text1);
            StringBuilder Massiv1 = new StringBuilder(Text1);
            int L1 = Text1.Length;
            string Text2 = "";
            bool f = false;
            int p = 0;
            int q = 0;
            int t = 0;
            bool k = false;
            do
            {
                for (int i = t; i < L1; i++)
                {
                    if (k == true)
                    {
                        int w = p - t;
                        StringBuilder Massiv2 = new StringBuilder(Text2);
                        int L2 = Text2.Length;
                        Text2 = "";
                        for (int j = 0; j < L2-w; j++)
                        {
                            Text2 += Massiv2[j].ToString();
                        }
                        k = false;
                        t = p;
                        break;
                    }
                    if (Massiv1[i] == '{')
                    {
                        f = true;
                        continue;
                    }
                    if (f == false)
                    {
                        Text2 += Massiv1[i].ToString();
                    }
                    if (Massiv1[i] == '}' && f==true)
                    {
                        t = i;
                        f = false;
                        continue;
                    }
                    if (Massiv1[i] == '}' && f == false)
                    {
                        p = i;
                        k = true;
                        f = true;
                        break;
                    }
                    q = i;
                }
            }
            while (q!=L1-1);
            Console.WriteLine(Text2);
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
