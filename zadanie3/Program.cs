using zadanie3;

P0();

void P0()
{
    Wektor wektor1 = new Wektor(1, 2, 3);
    Wektor wektor2 = new Wektor(2, 3, 4);

    Wektor wektor3 = wektor1 / 2;

    Console.WriteLine(wektor3[0]);
    Console.WriteLine(wektor3[1]);
    Console.WriteLine(wektor3[2]);
}