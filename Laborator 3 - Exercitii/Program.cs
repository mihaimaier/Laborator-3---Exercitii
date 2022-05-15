using System;

namespace Laborator_3___Exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 3 - Exercitii

            //Exercitiu1();
            //Exercitiu2();
            //Exercitiu3();
            //Exercitiu4();
            //Exercitiu5();
            //Exercitiu6();
            //Exercitiu7();
            //Exercitiu8();
            //Exercitiu9();
            //Exercitiu10();

            // Sa nu uitati sa salvati in mod frecvent (Ctrl+S) pentru a nu pierde munca
            Console.ReadLine();
        }
        static void Exercitiu1()
        {
            // Scrieti un program care sa calculeze maximul a trei numere citite de la tastatura.Ex: se citeste 3,15,4 Vom afisa 15.

            int numar1, numar2, numar3;

            Console.WriteLine("Introduceti Primul Numar");
            numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti Al Doilea Numar");
            numar2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti Al Treilea Numar");
            numar3 = int.Parse(Console.ReadLine());

            if (numar1 > numar2)
            {
                if (numar1 > numar3)
                {
                    Console.Write("Primul Numar Este Cel Mai Mare!\n");
                }
                else
                {
                    Console.Write("Al Treilea Numar Este Cel Mai Mare!\n");
                }
            }
            else if (numar2 > numar3)
                Console.Write("Al Doilea Numar Este Cel Mai Mare!\n");
            else
                Console.Write("Al Treailea Numar Este Cel Mai Mare!\n");
        }

        static void Exercitiu2()
        {
            //Scrieti un program care va citi de la tastatura un numar intreg pozitiv si va afisa valoarea acestuia in basa 2.Ex: se citeste 42, vom afisa 101010.

            Console.WriteLine("Introduceti un Numar");
            int numar = int.Parse(Console.ReadLine());

            if (numar < 0)
            {
                Console.WriteLine("Ati Introdus un Numar Invalid!");
            }
            else
            {
                string baza2 = Convert.ToString(numar, 2);
                Console.WriteLine(baza2);
            }
        }

        static void Exercitiu3()
        {
            //Scrieti un program care determina daca un numar n citit de la tastatura este un patrat perfect.

            Console.Write("Introduceti un Numar: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Ati Introdus un Numar Invalid!");
            }
            else if (Math.Ceiling((double)Math.Sqrt(n)) == Math.Floor((double)Math.Sqrt(n)))
            {
                Console.WriteLine("Numarul este un patrat perfect!");
            }
            else
            {
                Console.WriteLine("Numarul nu este un patrat perfect!");
            }
        }

        static void Exercitiu4()
        {
            // Se citesc numere de la tastatură până la apariția lui zero. Să se determine suma lor.

            int suma = 0, numar;
            do
            {
                Console.WriteLine("Introduceti un Numar");
                numar = int.Parse(Console.ReadLine());
                suma += numar;
            }
            while (numar != 0);

            Console.WriteLine("Suma Totala Este: " + suma);
            Console.ReadLine();
        }

        static void Exercitiu5()
        {
            // Se citesc numere de la tastatură până când se introduc două numere consecutive egale. Să se determine suma tuturor numerelor citite

            int suma = 0, numar, temp;
            do
            {
                Console.WriteLine("Introduceti un Numar");
                numar = int.Parse(Console.ReadLine());
                suma += numar;
                temp = numar * 1;
            }
            while (numar == temp);
            Console.WriteLine("Suma Totala Este: " + suma);
            Console.ReadLine();
        }

        static void Exercitiu6()
        {
            //Scrieti un program care va determina daca un numar n este sau numar prim, n fiind citit de la tastatura. Daca este numar prim, va afisa “prim”. In caz contrar va afisa numarul cu care este divizibil.

            Console.WriteLine("Introduceti un Numar");
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)                                                 // Un numar par nu poate fi mai mic sau egal cu 1
            {
                Console.WriteLine("Ati Introdus un Numar Invalid!");
            }
            else if (EstePrimsauNu(n))
            {
                Console.WriteLine("Prim");
            }
            else
            {
                int factor;
                for (factor = 1; factor <= n; factor++) // Conditia creata sa vada daca numarul este impar si sa scoata divizori
                {
                    if (n % factor == 0)
                    {
                        Console.Write(factor + ",");
                    }
                }
                Console.ReadKey();
            }
            static bool EstePrimsauNu(int num) // Conditia Creata sa vada daca numarul este impar sau par
            {
                for (int i = 2; i < num; i++)
                    if (num % i == 0) // Operatorul modulo (%) calculează restul unei operații de împărțire. În acest caz, calculează restul lui i împărțit la 2. Dacă i este un număr par, rezultatul va fi 0 și dacă este un număr impar, rezultatul va fi 1. Deci, această instrucțiune if verifică pentru a vedea dacă i este un numar par.
                        return false;
                return true;
            }
        }

        static void Exercitiu7()
        {
            //Se citesc doua numere de la tastatura. Scrieti un program care va calcula cel mai mare divizor comun al numerelor.

            Console.WriteLine("Introduceti Primul Numar");
            int numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti Al Doilea Numar");
            int numar2 = int.Parse(Console.ReadLine());

            while (numar1 != numar2)
            {
                if (numar1 > numar2)
                    numar1 -= numar2;
                else
                    numar2 -= numar1;
            }
            Console.WriteLine("Cel mai mare divizor comun al numerelor este: " + numar1);
        }

        static void Exercitiu8()
        {
            //Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze
            // Buzz, daca e multiplu si de 3 si de 5(ex: 15) sa se afiseze FizzBuzz, in restul cazurilor sa se afiseze numarul.

            Console.WriteLine("Introduceti Numarul");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Exercitiu9()
        {
            //Scrieti un program care citind de la tastatura lungimea si latimea unui dreptunghi, va afisa diagonala acestuia.

            double latime;
            double lungime;
            double diagonala;

            do
            {
                Console.WriteLine("Introduceti Latimea");
                latime = int.Parse(Console.ReadLine());

                if (latime != 0)
                {
                    Console.WriteLine("Introduceti Lungimea");
                    lungime = int.Parse(Console.ReadLine());

                    diagonala = Math.Sqrt((latime * latime) + (lungime * lungime));
                    Console.WriteLine("Diagonala este {0} ", diagonala);
                }
            }
            while (latime != 0);
        }

        static void Exercitiu10()
        {
            {
                //Arpsod adoră două lucruri: matematica și clătitele bunicii sale. Într-o zi, aceasta s-a apucat să prepare clătite.
                //Arpsod mănâncă toate clătitele începând de la a N - a clătită preparată, până la a M - a clătită preparată(inclusiv N și M).
                //Pentru că el vrea să mănânce clătite cu diferite umpluturi și-a făcut următoarea regulă:
                //“Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată. Dacă
                //numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem. Dacă suma
                //divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu
                //înghețată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
                //înghețată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
                //Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de
                //ordine par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi
                //simplă.


                {
                    int m, i, x, d = 2, p, s = 1, ciocolata = 0, inghetata = 0, nr, ok2, gem = 0, zahar = 0, simpla = 0, t, ok1,ClatiteIn, ClatiteOut;
                    Console.WriteLine("Cate Clatite A Mancat?");
                    m = int.Parse(Console.ReadLine());
                    t = int.Parse(Console.ReadLine());
                    ClatiteIn = m >> t;
                    ClatiteOut = m - t + 1 << '\n';
                    for (i = t; i <= m; i++)
                    {
                        x = i;
                        d = 2;
                        s = 1;
                        ok1 = 1;
                        ok2 = 1;
                        nr = 1;
                        while (x > 1)
                        {
                            p = 0;
                            while (x % d == 0)
                            {
                                p++;
                                x = x / d;
                            }
                            nr = nr * (p + 1);
                            if (p % 2 == 1)
                                ok1 = 0;
                            if (p % 3 != 0)
                                ok2 = 0;
                            s = (int)(s * ((Math.Pow(d, p + 1) - 1) / (d - 1)));
                            d++;
                            if (x > 1 && d * d > x)
                                d = x;
                        }
                        if (nr == 2)
                            ciocolata++;
                        else if (ok1 == 1 || ok2 == 1)
                            gem++;
                        else if (s - i == i)
                            inghetata++;
                        else if (i % 2 == 0)
                            zahar++;
                        else
                            simpla++;
                     ClatiteOut = " " + ciocolata + " " + gem + " " + inghetata + " " + zahar + " " + simpla;
                    }
                    Console.WriteLine(ClatiteIn);
                    Console.WriteLine(ClatiteOut);
                }
            }
        }
    }
}