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
            //P17();
            //P18();
            //P19();
            //P20();
            //P21();
            //P22();
            //P23();
            //P24();
            //P25();
            //P26();
            //P27();
            //P28();
            //P29();
            //P30();
            //P31();
            //P32();
            //P33();
            //P34();
            //P35();
            //P36();
            //P37();
            //P38();
            //P39();
            //P40();
            //P41();
            //P42();
            //P43();
            //P44();
            //P45();
        }

        private static void P45()
        {
            //Să se scrie o funcție care inversează elementele memorate într-un tablou.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = n-1; i >= 0; i--)
            {
                numar = int.Parse(t[i]);
                Console.Write($"{numar} ");
            }
            Console.WriteLine();
        }

        private static void P44()
        {
            //Să se scrie o functie pentru aflarea tablei inmulțirii unui număr utilizând bucla for și reprezentați-o în formatul corespunzător.
            int n, i;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=9;i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        private static void P43()
        {
            //Să se scrie o funcție care calculează pătratul elementelor memorate într-un tablou.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            Console.Write($"Pătratele elementelor tabloului initial sunt: ");

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                Console.Write($"{numar * numar} ");
            }
            Console.WriteLine();
        }

        private static void P42()
        {
            //Scrieti o functie care să se verifice dacă un număr natural este sau nu cub perfect.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i * i * i == n)
                {
                    Console.WriteLine($"Numarul {n} este cub perfect.");
                    return;
                }
            }
            Console.WriteLine($"Numarul {n} nu este cub perfect.");
        }

        private static void P41()
        {
            //Un muncitor lucrează n zile pentru a termina o lucrare. Scrieti o functie prin care sa se determine câte zile sunt necesare
            //pentru a termina aceeaşi lucrare o echipă de m muncitori.
            double n, m;
            Console.Write("n=");
            n = double.Parse(Console.ReadLine());
            Console.Write("m=");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine($"O echipa de {m} muncitori au nevoie de {n / m} zile pentru a termina lucrarea.");
        }

        private static void P40()
        {
            //Viteza unui automobil este de v km / h.Scrieti o functie prin care sa exprimaţi această viteză în m/ s.
            double v, m;
            Console.Write("v=");
            v = double.Parse(Console.ReadLine());
            m = (double)(10 * v / 36);
            Console.WriteLine($"{v} km/h = {m} m/s.");
        }

        private static void P39()
        {
            //Scrieţi o funcţie care să determine diferenţa dintre două momente de timp, date prin ore, minute şi secunde.
        }

        private static void P38()
        {
            //Scrieţi o functie care să calculeze factorialul unui număr întreg n.
            int n, nfactorial = 1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                nfactorial = nfactorial * i;
            }
            Console.WriteLine($"Factorialul lui {n} este {nfactorial}.");
        }

        private static void P37()
        {
            //Să se calculeze şi să se tipărească primii n termeni din şirul Fibonacci, şir definit de relaţia de recurenta:
            //f(n) = f(n - 2) + f(n - 1); f(1) = 1, f(2) = 1.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int f1 = 1, f2 = 1, f3;
            if (n == 1)
            {
                Console.WriteLine($"{f1}");
                return;
            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine($"{f1} {f2}");
                    return;
                }
                else
                {
                    Console.Write($"{f1} {f2} ");
                    for (int i = 3; i <= n; i++)
                    {
                        f3 = f1 + f2;
                        Console.Write($"{f3} ");
                        f1 = f2;
                        f2 = f3;
                    }
                }
            }
        }

        private static void P36()
        {
            // Scrie o metodă care primește ca parametru un număr natural x și apoi afișează:
            //-cifrele numărului(în ordine inversă)
            //-suma cifrelor
            int x, cx, s = 0;
            Console.Write("x=");
            x = int.Parse(Console.ReadLine());
            cx = x;
            Console.Write("Cifrele numarului sunt: ");
            while (cx != 0)
            {
                Console.Write($"{cx % 10} ");
                s = s + cx % 10;
                cx = cx / 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma cifrelor este: {s}.");
        }

        private static void P35()
        {
            //Scrieti o functie cu numele putere care primeste prin parametrul n un numar natural cu cel mult 9 cifre si care furnizeaza
            //prin parametrii x si k doua numere naturale cu proprietatea ca n = xk si x este minim.
            int n, x, k;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (x = 0; x <= n; x++)
            {
                for (k = 0; k <= n; k++)
                    if (x * k == n)
                    {
                        Console.WriteLine($"{n} = {x} * {k}");
                        return;
                    }
            }
        }

        private static void P34()
        {
            //Scrieţi o funcţie care să transforme un unghi exprimat în radiani în valoarea sa exprimată în grade
            //şi una care să facă transformarea inversă.
            int optiune;
            Console.WriteLine("1 = Radiani -> Grade, 2 = Grade -> Radiani");
            optiune = int.Parse(Console.ReadLine());

            if (optiune != 1 && optiune != 2)
            {
                Console.WriteLine("eroare!");
                return;
            }

            switch (optiune)
            {
                case 1:
                    double x, g;
                    Console.WriteLine("Dati valoarea in radiani a unghiului.");
                    Console.Write("x=");
                    x = double.Parse(Console.ReadLine());
                    g = (180 * x) / 3.1415;
                    Console.WriteLine($"{x} radiani sunt {g} grade.");
                    break;
                case 2:
                    double y, r;
                    Console.WriteLine("Dati valoarea in grade a unghiului.");
                    Console.Write("x=");
                    y = double.Parse(Console.ReadLine());
                    r = y * 3.1415 / 180;
                    Console.WriteLine($"{y} grade sunt {r} radiani.");
                    break;
                default:
                    break;
            }
        }

        private static void P33()
        {
            //Să se afişeze toate numerele prime de 3 cifre care citite invers sunt tot numere prime.
            int og, ci;
            bool ok, ok2;

            for (int i = 100; i <= 999; i++)
            {
                ok = true;
                if (i % 2 == 0 && i != 2)
                    ok = false;
                for (int d = 3; d * d <= i; d = d + 2)
                    if (i % d == 0)
                        ok = false;
                if (ok)
                {
                    ci = i;
                    og = 0;
                    while (ci != 0)
                    {
                        og = og * 10 + ci % 10;
                        ci = ci / 10;
                    }
                    ok2 = true;
                    if (og % 2 == 0 && og != 2)
                        ok2 = false;
                    for (int d = 3; d * d <= og; d = d + 2)
                        if (og % d == 0)
                            ok2 = false;
                    if (ok2)
                        Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        private static void P32()
        {
            //Să se afişeze primele n numere prime care au suma cifrelor mai mică sau egală cu m.
            int n, m, k = 0, sc = 0, ci;
            bool ok;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());

            for (int i = 2; ; i++)
            {
                if (k < n)
                {
                    ok = true;
                    if (i % 2 == 0 && i != 2)
                        ok = false;
                    for (int d = 3; d * d <= i; d = d + 2)
                        if (i % d == 0)
                            ok = false;
                    if (ok)
                    {
                        sc = 0;
                        ci = i;
                        while (ci != 0)
                        {
                            sc = sc + ci % 10;
                            ci = ci / 10;
                        }
                        if (sc <= m)
                        {
                            k++;
                            Console.Write($"{i} ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    return;
                }
            }
        }

        private static void P31()
        {
            //Să se genereze toate numerele prime mai mici decât numărul natural n dat.
            int m;
            bool ok;
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            if (m < 2)
            {
                Console.WriteLine($"Nu exista numere prime mai mici decat {m}.");
                return;
            }
            Console.Write($"Numerele prime mai mici decat {m} sunt: ");
            for (int i = 2; i < m; i++)
            {
                ok = true;
                if (i % 2 == 0 && i != 2)
                    ok = false;
                for (int d = 3; d * d <= i; d = d + 2)
                    if (i % d == 0)
                        ok = false;
                if (ok)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void P30()
        {
            //Să se transforme un număr din baza 10 în baza p < 10.Să se transforme un număr din baza p < 10 în baza 10.
        }

        private static void P29()
        {
            //Să se listeze toate numerele ≤n, a căror sumă a cifrelor este divizibilă prin 5.
            int n, ci, sumcif;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                ci = i;
                sumcif = 0;
                while (ci != 0)
                {
                    sumcif = sumcif + ci % 10;
                    ci = ci / 10;
                }
                if (sumcif % 5 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void P28()
        {
            //Să se afişeze toate numerele prime de 3 cifre care, citite invers, sunt tot numere prime.
            int og, ci;
            bool ok, ok2;

            for (int i = 100; i <= 999; i++)
            {
                ok = true;
                if (i % 2 == 0 && i != 2)
                    ok = false;
                for (int d = 3; d * d <= i; d = d + 2)
                    if (i % d == 0)
                        ok = false;
                if (ok)
                {
                    ci = i;
                    og = 0;
                    while (ci != 0)
                    {
                        og = og * 10 + ci % 10;
                        ci = ci / 10;
                    }
                    ok2 = true;
                    if (og % 2 == 0 && og != 2)
                        ok2 = false;
                    for (int d = 3; d * d <= og; d = d + 2)
                        if (og % d == 0)
                            ok2 = false;
                    if (ok2)
                        Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        private static void P27()
        {
            //Să se afişeze primele n numere prime care au suma cifrelor ≤m.
            int n, m, k = 0, sc = 0, ci;
            bool ok;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());

            for (int i = 2; ; i++)
            {
                if (k < n)
                {
                    ok = true;
                    if (i % 2 == 0 && i != 2)
                        ok = false;
                    for (int d = 3; d * d <= i; d = d + 2)
                        if (i % d == 0)
                            ok = false;
                    if (ok)
                    {
                        sc = 0;
                        ci = i;
                        while (ci != 0)
                        {
                            sc = sc + ci % 10;
                            ci = ci / 10;
                        }
                        if (sc <= m)
                        {
                            k++;
                            Console.Write($"{i} ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    return;
                }
            }
        }

        private static void P26()
        {
            //Să se afişeze toate numerele prime mai mici sau egale cu un numar m dat.
            int m;
            bool ok;
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            if (m < 2)
            {
                Console.WriteLine($"Nu exista numere prime mai mici sau egale cu {m}.");
                return;
            }
            Console.Write($"Numerele prime mai mici sau egale cu {m} sunt: ");
            for (int i = 2; i <= m; i++)
            {
                ok = true;
                if (i % 2 == 0 && i != 2)
                    ok = false;
                for (int d = 3; d * d <= i; d = d + 2)
                    if (i % d == 0)
                        ok = false;
                if (ok)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void P25()
        {
            //Un număr se numeşte “palindrom” dacă citit invers este acelaşi număr. Să se verifice dacă un număr este sau nu palindrom.
            int n, cn, og = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            cn = n;
            while (cn != 0)
            {
                og = og * 10 + cn % 10;
                cn = cn / 10;
            }
            if (og == n)
                Console.WriteLine($"{n} este palindrom.");
            else
                Console.WriteLine($"{n} nu este palindrom.");
        }

        private static void P24()
        {
            //Se citeşte un număr natural.Câte cifre conţine?
            int n, k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                k++;
                n = n / 10;
            }
            Console.WriteLine($"Numarul dat contine {k} cifre.");
        }

        private static void P23()
        {
            //Efectuaţi împărţirea întreagă a două numere, făra a utiliza operatorii / şi %, ci doar scăderi repetate.
            int a, b, c = 0, r = 0, ca;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            ca = a;
            while (ca - b >= 0)
            {
                ca = ca - b;
                c++;
            }
            Console.WriteLine($"{a} / {b} = {c} r {ca}");
        }

        private static void P22()
        {
            //Să se calculeze produsul a două numere naturale prin adunări repetate.
            int a, b, p = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
                p = p + b;
            Console.WriteLine($"{a} * {b} = {p}");
        }

        private static void P21()
        {
            //Se citesc 3 numere naturale n, p şi k, apoi un şir de n numere naturale.Câte dintre acestea, împărţite la p dau restul k?
            int n, p, k, cate = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("p=");
            p = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numere sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar % p == k)
                    cate++;
            }
            Console.WriteLine($"Din cele {n} numere sunt {cate} care impartite la {p} dau restul {k}.");
        }

        private static void P20()
        {
            //Se citeşte un şir de numere întregi pâna la întâlnirea numărului 0.Să se calculeze media aritmetică a numerelor din şir.
            double s = 0, k = 0;

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < t.Length; i++)
            {
                numar = int.Parse(t[i]);
                if (numar == 0)
                    break;
                s = s + numar;
                k++;
            }
            if (k < 2)
                Console.WriteLine("Nu sunt destule numere pentru a calcula media aritmetica.");
            else
                Console.WriteLine($"Media aritmetica a celor {k} numere este {s / k}.");
        }

        private static void P19()
        {
            //Să se scrie un program care să citească trei numere reale a, b şi c, apoi să pună o întrebare de genul:
            //Ce doriţi să calculăm? Aria sau perimetrul?.Dacă se va răspunde prin ‘aria’ atunci se va calcula şi afişa aria, altfel perimetrul.
            double a, b, c;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriţi să calculăm? Aria(1) sau perimetrul(2)?");
            int operatie;
            operatie = int.Parse(Console.ReadLine());
            if (operatie != 1 && operatie != 2)
            {
                Console.WriteLine("eroare!");
                return;
            }
            switch (operatie)
            {
                case 1:
                    {
                        double result, p;
                        p = (a + b + c) / 2;
                        result = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                        Console.WriteLine($"Aria este egala cu {result}.");
                    }
                    break;
                case 2:
                    {
                        double result;
                        result = a + b + c;
                        Console.WriteLine($"Perimetrul este egal cu {result}.");
                    }
                    break;
                default:
                    break;
            }
        }

        private static void P18()
        {
            //Să se scrie un program care să citească două numere reale a şi b. Apoi să pună utilizatorului o întrebare:
            //Ce doriţi să calculăm ? Media aritmetică(1) sau geometrică(2)?. Dacă se va răspunde prin 1, se va calcula şi afişa media aritmetică,
            //iar pentru 2 media geometrică(numai dacă numerele sunt pozitive !, iar de nu, se va afişa ‘eroare !’).
            //Dacă nu se răspunde prin 1 sau 2 se va produce un sunet în difuzor.
            int operatie;
            Console.WriteLine("Ce doriţi să calculăm? Media aritmetică(1) sau media geometrică(2)?");
            operatie = int.Parse(Console.ReadLine());
            if (operatie != 1 && operatie != 2)
            {
                Console.WriteLine("eroare!");
                return;
            }
            switch (operatie)
            {
                case 1:
                    {
                        double a, b;
                        double result;
                        Console.WriteLine("Introduceti 2 valori pentru care doriti sa aflati media aritmetica.");
                        Console.Write("a=");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b=");
                        b = int.Parse(Console.ReadLine());
                        result = (a + b) / 2;
                        Console.WriteLine($"Media aritmetica a celor 2 numere este: {result}");
                    }
                    break;
                case 2:
                    {
                        double a, b;
                        double result;
                        Console.WriteLine("Introduceti 2 valori pentru care doriti sa aflati media geometrica.");
                        Console.Write("a=");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b=");
                        b = int.Parse(Console.ReadLine());
                        if (a < 0 || b < 0)
                        {
                            Console.WriteLine("eroare!");
                            return;
                        }
                        result = Math.Sqrt(a * b);
                        Console.WriteLine($"Media geometrica a celor 2 numere este: {result}");
                    }
                    break;
                default:
                    break;
            }
        }

        private static void P17()
        {
            //Un punct material se află la distanţa x0 de origine, la momentul iniţial t0, când începe să se mişte rectiliniu uniform.
            //Stiind că la momentul t se află la distanţa x faţă de origine, să se determine viteza v de mişcare a punctului material, la momentul t.
            int x, x0, t, t0, v;
            Console.Write("x0=");
            x0 = int.Parse(Console.ReadLine());
            Console.Write("t0=");
            t0 = int.Parse(Console.ReadLine());
            Console.Write("x=");
            x = int.Parse(Console.ReadLine());
            Console.Write("t=");
            t = int.Parse(Console.ReadLine());
            v = (x - x0) / (t - t0);
            Console.WriteLine($"Viteza de miscare a punctului material la momentul t={t} este de {v} m/s.");
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
            int operatie;
            Console.WriteLine("Ce operatie doriti sa efectuati?");
            Console.WriteLine("1 = adunare, 2 = scadere, 3 = inmultire, 4 = impartire, 5 = radical, 6 = modul");
            operatie = int.Parse(Console.ReadLine());

            switch (operatie)
            {
                case 1:
                    {
                        int a, b, result;
                        Console.WriteLine("Introduceti 2 valori pe care doriti sa le adunati.");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = a + b;
                        Console.WriteLine($"{a} + {b} = {result}");
                    }
                    break;
                case 2:
                    {
                        int a, b, result;
                        Console.WriteLine("Introduceti 2 valori pe care doriti sa le scadeti.");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = a - b;
                        Console.WriteLine($"{a} - {b} = {result}");
                    }
                    break;
                case 3:
                    {
                        int a, b, result;
                        Console.WriteLine("Introduceti 2 valori pe care doriti sa le inmultiti.");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = a * b;
                        Console.WriteLine($"{a} * {b} = {result}");
                    }
                    break;
                case 4:
                    {
                        int a, b, result;
                        Console.WriteLine("Introduceti 2 valori pe care doriti sa le impartiti.");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        result = a / b;
                        Console.WriteLine($"{a} / {b} = {result}");
                    }
                    break;
                case 5:
                    {
                        int a;
                        double result;
                        Console.WriteLine("Introduceti o valoare pentru care doriti radicalul sau.");
                        a = int.Parse(Console.ReadLine());
                        result = Math.Sqrt(a);
                        Console.WriteLine($"sqrt({a}) = {result}");
                    }
                    break;
                case 6:
                    {
                        int a, result;
                        Console.WriteLine("Introduceti o valoare pentru care doriti modulul sau.");
                        a = int.Parse(Console.ReadLine());
                        result = Math.Abs(a);
                        Console.WriteLine($"|{a}| = {result}");
                    }
                    break;
                default:
                    break;
            }
        }

        private static void P1()
        {
            //Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers
            //utilizand instructiunea switch.
            float c, f;
            int optiune;
            Console.WriteLine("1 = Celsius -> Fahrenheit, 2 = Fahrenheit -> Celsius");
            optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                    Console.WriteLine("Dati o temperatura in grade Celsius: ");
                    c = float.Parse(Console.ReadLine());
                    f = c * (float)1.8 + 32;
                    Console.WriteLine($"Temperatura corespunzatoare in grade Fahrenheit este: {f}");
                    break;
                case 2:
                    Console.WriteLine("Dati o temperatura in grade Fahrenheit: ");
                    f = float.Parse(Console.ReadLine());
                    c = (f - 32) / (float)1.8;
                    Console.WriteLine($"Temperatura corespunzatoare in grade Celsius este: {c}");
                    break;
                default:
                    break;
            }
        }
    }
}
