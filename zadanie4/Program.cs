using zadanie4;

P0();

void P0()
{
    Wielopak wielopak = new Wielopak();
    wielopak.Produkt = new Produkt();
    wielopak.Produkt.Nazwa = "telewizor";
    wielopak.KategoriaVat = "rtv";
    wielopak.Ilość = 10;
    wielopak.CenaNetto = 5;

    Console.WriteLine(wielopak.CenaBrutto);
}