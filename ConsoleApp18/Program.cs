NewMethod();

static void NewMethod()
{
    int numar1;
   double numar2;
    double rezultat;
    double rest;
        numar1 = 10;
        numar2 = 5.5;
    Console.WriteLine(numar1 + numar2);
    Console.WriteLine(numar1 - numar2);
    Console.WriteLine(numar1 * numar2);
    Console.WriteLine(numar1 / numar2);
    Console.WriteLine(numar1 + numar2);

    rezultat = numar1 + numar2 * 2 / 3;
    rest = 10 % 4;
    Console.WriteLine(rezultat);
    Console.WriteLine(rest);

    Console.WriteLine("Terminat");
}

