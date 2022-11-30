using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_Probleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Problema dorita: ");
            int prob = int.Parse(Console.ReadLine());
            while (prob != 0)
            {
                switch (prob)
                {
                    case 1: Problema1(); 
                        break;
                    case 2: Problema2(); 
                        break;
                    case 3: Problema3(); 
                        break;
                    case 4: Problema4(); 
                        break;
                    case 5: Problema5(); 
                        break;
                    case 6: Problema6(); 
                        break;
                    case 7: Problema7(); 
                        break;
                    case 8: Problema8(); 
                        break;
                    case 9: Problema9(); 
                        break;
                    case 10: Problema10(); 
                        break;
                    case 11: Problema11(); 
                        break;
                    case 12: Problema12(); 
                        break;
                    case 13: Problema13(); 
                        break;
                    case 14: Problema14(); 
                        break;
                    case 15: Problema15(); 
                        break;
                    case 16: Problema16(); 
                        break;
                    case 17: Problema17(); 
                        break;
                    case 18: Problema18(); 
                        break;
                    case 19: Problema19(); 
                        break;
                    case 20: Problema20(); 
                        break;
                    case 21: Problema21(); 
                        break;
                    default: Console.WriteLine("invalid"); 
                        break;
                }
                prob = int.Parse(Console.ReadLine());
            }
        }

        private static void Problema1 ()
        {
            float a, b, x;
            Console.Write($"a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine($"Ecuatie nedeterminata");
                else
                    Console.WriteLine($"Ecuatie imposibila");
            else
            {
                x = -b / a;
                Console.WriteLine($"Solutia = {x}");
            }
            Console.ReadKey();
        }

        private static void Problema2 ()
        {
            float a, b, c, D;
            double x1, x2;
            Console.Write($"a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write($"c = ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.Write($"Ecuatie nedeterminata");
                    else
                        Console.Write($"Ecuatie imposibila");
                else
                {
                    x1 = -c / b;
                    Console.WriteLine($"Ecuatie de gradul 1 cu x1 = {x1}");
                }
            else
            {
                D = b * b - 4 * a * c;
                if (D < 0)
                    Console.WriteLine($"Ecuatia are solutii complexe");
                else
                {
                    if (D == 0)
                    {
                        x1 = x2 = -b / (2 * a);
                        Console.WriteLine($"x1 = x2 = {x1});");
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        Console.WriteLine($"Solutiile sunt x1 = {x1}, x2 = {x2}");
                    }
                }
            }
            Console.ReadKey();
        }

        private static void Problema3()
        {
            int n, k;
            Console.WriteLine($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"k = ");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine($"Se divide");
            else
                Console.WriteLine($"Nu se divide");
            Console.ReadKey();
        }

        private static void Problema4()
        {
            int an;
            Console.Write($"Anul: ");
            an = int.Parse(Console.ReadLine());
            if (((an % 4 == 0) && (an % 100 != 0)) || (an % 400 == 0))
                Console.WriteLine($"Anul {an} este bisect");
            else
                Console.WriteLine($"Anul {an} nu este bisect");
            Console.ReadKey();
        }

        private static void Problema5()
        {
            int n, k, i, cif;
            Console.Write($"Numarul = ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"k = ");
            k = int.Parse(Console.ReadLine());
            for (i = 1; i <= k - 1; i++)
                n = n / 10;
            cif = n % 10;
            Console.WriteLine($"Cifra este {cif}");
            Console.ReadKey();
        }

        private static void Problema6()
        {
            float a, b, c;
            Console.Write($"a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write($"c = ");
            c = float.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine($"Este triunghi");
            else
                Console.WriteLine($"Nu este triunghi");
            Console.ReadKey();
        }

        private static void Problema7()
        {
            int a, b, aux;
            Console.Write($"a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"a inversat este {a}");
            Console.WriteLine($"b inversat este {b}");
            Console.ReadKey();
        }

        private static void Problema8()
        {
            int a, b;
            Console.Write($"a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a inversat este {a}");
            Console.WriteLine($"b inversat este {b}");
            Console.ReadKey();
        }

        private static void Problema9()
        {
            int n, d;
            Console.Write($"Numarul = ");
            n = int.Parse(Console.ReadLine());
            for (d = 1; d <= n; d++)
                if (n % d == 0)
                    Console.WriteLine($"{d}");
            Console.ReadKey();
        }

        private static void Problema10()
        {
            int n, d = 1, nrdiv = 0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0)
                    nrdiv++;
            }
            if (nrdiv == 2)
                Console.Write($"Este prim");
            else
                Console.Write($"Nu este prim");
            Console.ReadKey();
        }

        private static void Problema11()
        {
            int n, ogl = 0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
            }
            Console.Write($"Inversul numarului este {ogl}");
            Console.ReadKey();
        }

        private static void Problema12()
        {
            int n, a, b, i, nr = 0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = int.Parse(Console.ReadLine());
            for (i = a; i <= b; i++)
                if (i % n == 0)
                    nr++;
            Console.Write($"Numarul de numere intregi divizibile cu n care se afla in intervalul [{a},{b}] este {nr}");
            Console.ReadKey();
        }

        private static void Problema13()
        {
            int i, y1, y2, nr = 0;
            Console.Write($"y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write($"y2 = ");
            y2 = int.Parse(Console.ReadLine());
            for (i = y1; i <= y2; i++)
                if (DateTime.IsLeapYear(i))
                    nr++;
            Console.Write($"Intre {y1} si {y2} sunt {nr} ani bisecti");
            Console.ReadKey();
        }

        private static void Problema14()
        {
            int n, ogl = 0, c;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            c = n;
            while (n != 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
            }
            if (c == ogl)
                Console.Write($"Este palindrom");
            else
                Console.Write($"Nu este palindrom");
            Console.ReadKey();
        }

        private static void Problema15()
        {
            int a, b, c;
            Console.Write($"a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write($"c = ");
            c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
                if (b >= c)
                    Console.Write($"Afisare: {c}, {b}, {a}");
                else
                    Console.Write($"Afisare: {b}, {c}, {a}");
            else
                if (b >= a && b >= c)
                if (a >= c)
                    Console.Write($"Afisare: {c}, {a}, {b}");
                else
                    Console.Write($"Afisare: {a}, {c}, {b}");
            else
                if (c >= a && c >= b)
                if (a >= b)
                    Console.Write($"Afisare: {b}, {a}, {c}");
                else
                    Console.Write($"Afisare: {a}, {b}, {c}");
            Console.ReadKey();
        }

        private static void Problema16()
        {
            int a, b, c, d, e;
            Console.Write($"a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write($"b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write($"c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write($"d = ");
            d = int.Parse(Console.ReadLine());
            Console.Write($"e = ");
            e = int.Parse(Console.ReadLine());
            while (a > b || b > c || c > d || d > e)
            {
                if (a > b)
                    (a, b) = (b, a);
                if (b > c)
                    (b, c) = (c, b);
                if (c > d)
                    (c, d) = (d, c);
                if (d > e)
                    (d, e) = (e, d);
            }
            Console.Write($"Se afiseaza: {a}, {b}, {c}, {d}, {e}");
            Console.ReadKey();
        }

        private static void Problema17()
        {
            int n, m, P = 1, cmmmc;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"m = ");
            m = int.Parse(Console.ReadLine());
            P = n * m;
            //cmmdc
            while (n != m)
                if (n > m)
                    n = n - m;
                else
                    m = m - n;
            Console.WriteLine($"Cel mai mare divizor comun este: {n}");

            //cmmmc
            cmmmc = P / n;
            Console.Write($"Cel mai mic multiplu comun este: {cmmmc}");
            Console.ReadKey();
        }

        private static void Problema18()
        {
            int n, d = 2, p=0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n / d;
                }
                if (p != 0)
                    Console.Write($"{d}^{p} x");
                d++;
            }
            Console.ReadKey();
        }

        private static void Problema19()
        {
            int n, c1, c2, cn;
            bool ok = true;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            cn = n;
            c1 = n % 10;
            c2 = (n / 10) % 10;
            while (c1 == c2)
            {
                c2 = cn % 10;
                cn = cn / 10;
            }
            while (n != 0)
            {
                if (n % 10 != c1 && n % 10 != c2)
                    ok = false;
                n = n / 10;
            }
            if (ok)
                Console.Write($"Numarul este format din 2 cifre care se repeta");
            else
                Console.Write($"Numarul nu este format din 2 cifre care se repeta");
            Console.ReadKey();
        }

        private static void Problema20()
        {
            int m = 13, n = 30;
            // TODO aducem fractia la forma ireductibila. 
            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
            Console.ReadKey();
        }

        private static void Problema21()
        {
            int n, k;
            bool ok = false;
            Random r = new Random();
            n = r.Next(1, 1024);
            do
            {
                k = int.Parse(Console.ReadLine());
                if (k < n)
                    Console.WriteLine($"Numarul este mai mare");
                else
                    if (k > n)
                    Console.WriteLine($"Numarul este mai mic");
                else if (k == n)
                {
                    Console.WriteLine($"Ati gasit numarul");
                    ok = true;
                }
            } while (ok == false);
            Console.ReadKey();
        }
    }
}
