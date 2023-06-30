using zadanie5;

P0();

void P0()
{
    Macierz<string> macierz1 = new Macierz<string>(2, 3);
    Macierz<string> macierz2 = new Macierz<string>(2, 3);

    macierz1[0, 0] = "Ala";
    macierz1[0, 1] = "ma";
    macierz1[0, 2] = "kota";
    macierz1[1, 0] = "kot";
    macierz1[1, 1] = "ma";
    macierz1[1, 2] = "ale";

    macierz2[0, 0] = "Ala";
    macierz2[0, 1] = "ma";
    macierz2[0, 2] = "kota";
    macierz2[1, 0] = "kot";
    macierz2[1, 1] = "ma";
    macierz2[1, 2] = "Ale";

    Console.WriteLine(macierz1.Equals(macierz2));
}