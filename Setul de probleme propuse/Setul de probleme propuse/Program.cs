using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_propuse___laborator
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
        }

        private static void P16()
        {
            //O carte are n foi şi r rânduri pe fiecare pagină.Câte rânduri are cartea?
            int n, r;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("r=");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cartea are {n * r} randuri.");
        }

        private static void P15()
        {
            //Scrieţi un program care să calculeze factorialul unui număr întreg n.
            int n, nfactorial = 1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                nfactorial = nfactorial * i;
            }
            Console.WriteLine($"Factorialul lui {n} este {nfactorial}.");
        }

        private static void P14()
        {
            //Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero,
            //şi să determine cel mai mic număr şi cel mai mare număr citit.           
            int minv = int.MaxValue, maxv = int.MinValue;

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < t.Length; i++)
            {
                numar = int.Parse(t[i]);
                if (numar == 0)
                    break;
                if (numar < minv)
                    minv = numar;
                if (numar > maxv)
                    maxv = numar;
            }
            Console.WriteLine($"Cel mai mic numar citit este {minv} si cel mai mare numar citit este {maxv}.");
        }

        private static void P13()
        {
            //Elaboraţi un program care să tipărească tabela corespunzătoare Celsius - Fahrenheit.
            double f;
            Console.WriteLine("Celsius | Fahrenheit");
            for (double i = 0; i <= 300; i++)
            {
                f = 1.8 * i + 32;
                if (i < 10)
                    Console.WriteLine($"   {i}    |   {f}     ");
                else if (i < 100)
                    Console.WriteLine($"   {i}   |   {f}     ");
                else
                    Console.WriteLine($"   {i}  |   {f}     ");
            }
        }

        private static void P12()
        {
            //Elaboraţi un program care să tipărească tabela de temperaturi Fahrenheit şi echivalenţele lor în centigrade sau grade Celsius,
            //folosind formula: C = (5 / 9) * (F - 32), între valorile extreme 0 şi 300 grade Fahrenheit.
            double c;
            Console.WriteLine("Fahrenheit   |     Celsius");
            for (double i = 0; i <= 300; i++)
            {
                c = (i - 32) * 0.555;
                if (i < 10)
                    Console.WriteLine($"     {i}       |     {c}     ");
                else if (i < 100)
                    Console.WriteLine($"     {i}      |     {c}     ");
                else
                    Console.WriteLine($"     {i}     |     {c}     ");
            }
        }

        private static void P11()
        {
            //Să se determine dacă două numere sunt prime între ele sau nu.
            int a, b, r, ca, cb, cmmdc;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            ca = a;
            cb = b;
            if (ca == 0 || cb == 0)
            {
                cmmdc = ca + cb;
            }
            else
            {
                r = ca % cb;
                while (r != 0)
                {
                    ca = cb;
                    cb = r;
                    r = ca % cb;
                }
                cmmdc = cb;
            }
            if (cmmdc == 1)
                Console.WriteLine($"Numerele {a} si {b} sunt prime intre ele.");
            else
                Console.WriteLine($"Numerele {a} si {b} nu sunt prime intre ele.");
        }

        private static void P10()
        {
            //Să se afişeze primele n numere prime.
            int n, k = 0, i = 2;
            bool ok;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Primele {n} numere prime sunt: ");
            while (k < n)
            {
                ok = true;
                if (i % 2 == 0 && i != 2)
                    ok = false;
                for (int d = 3; d * d <= i; d = d + 2)
                    if (i % d == 0)
                        ok = false;
                if (ok)
                {
                    Console.Write($"{i} ");
                    k++;
                }
                i++;
            }
        }

        private static void P9()
        {
            //Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două numere întregi a şi b.
            int a, b, r, x, y, ca, cb;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            ca = a;
            cb = b;

            //CMMDC
            if (ca == 0 || cb == 0)
            {
                Console.WriteLine($"Cel mai mare divizor comun este: {ca + cb}");
            }
            else
            {
                r = ca % cb;
                while (r != 0)
                {
                    ca = cb;
                    cb = r;
                    r = ca % cb;
                }
                Console.WriteLine($"Cel mai mare divizor comun este: {cb}");
            }

            //CMMMC
            x = a;
            y = b;
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            Console.WriteLine($"Cel mai mic multiplu comun este: {a * b / x}");
        }

        private static void P8()
        {
            //Fie a. Să se scrie un algoritm pentru calculul mediei aritmetice, geometrice şi armonice a tuturor divizorilor lui a.
            double a, s = 0, p = 1, k = 0;
            double ma, mg, mh;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    s = s + i;
                    p = p * i;
                    k++;
                }
            }
            ma = s / k;
            mg = Math.Sqrt(p);
            mh = (2 * p) / s;
            Console.WriteLine($"Media aritmetica a divizorilor lui {a} este {ma}, media geometrica este {mg} si media armonica este {mh}.");
        }

        private static void P7()
        {
            //Fie n, k. Să se scrie un algoritm pentru calculul numărului combinărilor de n elemente luate câte k.
            int n, k, nfactorial = 1, kfactorial = 1, nMinuskfactorial = 1;
            double rezultat;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                nfactorial = nfactorial * i;
            for (int i = 1; i <= k; i++)
                kfactorial = kfactorial * i;
            for (int i = 1; i <= n - k; i++)
                nMinuskfactorial = nMinuskfactorial * i;
            rezultat = nfactorial / (kfactorial * nMinuskfactorial);
            Console.WriteLine($"Combinari de {n} luate cate {k} este {rezultat}.");
        }

        private static void P6()
        {
            //Două numere întregi x şi y sunt "prietene" dacă suma divizorilor numărului x este egală cu
            //suma divizorilor numărului y. Să se găsească numerele "prietene" din intervalul[a, b].
        }

        private static void P5()
        {
            //Să se determine numerele perfecte din intervalul[a, b], pentru a, b date.
            int a, b, s, k = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                s = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        s = s + j;
                }
                if (s == i)
                {
                    Console.Write($"{i} ");
                    k++;
                }
            }
            if (k == 0)
                Console.WriteLine($"Nu exista numere perfecte in intervalul [{a}, {b}].");
        }

        private static void P4()
        {
            //Să se verifice dacă numărul n este perfect. (Un număr n este perfect dacă
            //este egal cu suma divizorilor lui diferiţi de n; exemplu: 6 = 1 + 2 + 3).
            int n, s = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    s = s + i;
            }
            if (s == n)
                Console.WriteLine($"Numarul {n} este perfect.");
            else
                Console.WriteLine($"Numarul {n} nu este perfect.");
        }

        private static void P3()
        {
            //Fie i, j, k. Să se determine restul împărţirii numărului natural i la puterea j la k.
            int i, j, k, p = 1;
            double result;
            Console.Write("i=");
            i = int.Parse(Console.ReadLine());
            Console.Write("j=");
            j = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            for (int x = 1; x <= j; x++)
            {
                p = p * i;
            }
            result = p % k;
            Console.WriteLine(result);
        }

        private static void P2()
        {
            //Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică:
            //adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru
            //selectarea funcției calculatorului.). După selectarea opțiunii dorite, programul trebuie să
            //ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii,
            //înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.
        }

        private static void P1()
        {
            //Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers
            //utilizand instructiunea switch.
            Console.WriteLine("Dati temperatura in grade Celsius daca doriti sa convertirti in Fahrenheit sau valoarea 0 daca doriti sa convertiti din Fahrenheit in Celsius.");
            double n, result;
            n = double.Parse(Console.ReadLine());
            if (n != 0)
            {
                result = 1.8 * n + 32;
                Console.WriteLine($"{n} grade Celsius sunt {result} gradea Fahrenheit.");
            }
            else
            {
                Console.WriteLine("Dati temperatura in grade Fahrenheit.");
                n = double.Parse(Console.ReadLine());
                result = ((n - 32) * 5) / 9;
                Console.WriteLine($"{n} grade Fahrenheit sunt {result} gradea Celsius.");
            }
        }
    }
}
