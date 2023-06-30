using zadanie1;

P0();

void P0()
{
    Osoba osoba = new Osoba("Adrian Nowak Żalno");
    osoba.DataUrodzenia = new DateTime(1970, 12, 12);
    osoba.DataŚmierci = new DateTime(1971, 12, 12);

    Console.WriteLine(osoba.Wiek);
}