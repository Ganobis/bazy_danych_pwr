using System;
using System.IO;

namespace losowanko
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            string[] towar = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\produkty.txt"); //16
            string[] miasta = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\miasta_transport.txt"); //210
            string[] dodatkowe = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\dodatkowe_informacje.txt"); //22
            string[] rejestracje = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\rejestracje.txt"); //5
            string[] id_kierowcy = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\kierowcy.txt");  //6
            string[] id_konternerow = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\kontenery.txt");  //
            int miesiac = 1;
            int dzien = 4;
            string dzien_s;
            int ciezarowki = 2;
            int kierowcy = 4;
            int licznik = 0;
            int pomocnicza = 0;
            using (StreamWriter file = new StreamWriter(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\insert.txt"))
            {
                file.WriteLine("INSERT INTO pracownicy(towar, cel, pochodzenie, termin, rejestracha_samochodu, specialne_warunki, id_pracownika, id_klienta, id_kontenera)\nVALUES");
                for (int i = 0; i < 169; i++)  //tyle dni od 04-01 do 22-06
                {
                    if (dzien > 31 || (dzien > 30 && miesiac % 2 == 0) || (dzien > 29 && miesiac == 2)) // odpowiedznie przejście miesiąców
                    {
                        dzien = 1;
                        miesiac++;
                    }
                    if ((dzien == 12 && miesiac == 1) || (dzien == 21 && miesiac == 2) || (dzien == 20 && miesiac == 6))    // daty zakupu ciężarówek
                        ciezarowki++;
                    if ((dzien == 21 && miesiac == 2) || (dzien == 20 && miesiac == 6))  //zatrudnienie nowych kierowców
                        kierowcy++;
                    if (dzien < 10)                 // zapisanie dany dnia
                        dzien_s = "0" + dzien;
                    else
                        dzien_s = dzien.ToString();
                    //losowanie ilości zleceń w zależności od liczby ciężarówek
                    pomocnicza = rnd.Next(0, 100);
                    if (ciezarowki == 2)
                    {
                        if(pomocnicza > 100)
                            pomocnicza = 4;
                        else if(pomocnicza > 80)
                            pomocnicza = 3;
                        else if (pomocnicza > 35)
                            pomocnicza = 2;
                        else if (pomocnicza > 11)
                            pomocnicza = 1;
                        else
                            pomocnicza = 0;
                    }
                    else if(ciezarowki == 3)
                    {
                        if (pomocnicza > 99)
                            pomocnicza = 5;
                        else if (pomocnicza > 80)
                            pomocnicza = 4;
                        else if (pomocnicza > 30)
                            pomocnicza = 3;
                        else if (pomocnicza > 10)
                            pomocnicza = 2;
                        else if (pomocnicza > 3)
                            pomocnicza = 1;
                        else
                            pomocnicza = 0;
                    }
                    else
                    {
                        if (pomocnicza > 99)
                            pomocnicza = 7;
                        else if (pomocnicza > 90)
                            pomocnicza = 6;
                        else if (pomocnicza > 55)
                            pomocnicza = 5;
                        else if (pomocnicza > 25)
                            pomocnicza = 4;
                        else if (pomocnicza > 15)
                            pomocnicza = 3;
                        else if (pomocnicza > 10)
                            pomocnicza = 2;
                        else if (pomocnicza > 2)
                            pomocnicza = 1;
                        else
                            pomocnicza = 0;

                    }

                    for (int j = 0; j < pomocnicza; j++)
                    {
                        file.WriteLine("('" + towar[rnd.Next(0, 16)] + "', '" + miasta[rnd.Next(0, 209)] + "', '" + miasta[rnd.Next(0, 209)] + "', '" +
                        dzien_s + "-0" + miesiac.ToString() + "-2020', '" + rejestracje[licznik % ciezarowki] + "', '" + dodatkowe[rnd.Next(0, 22)] + "', '" + id_kierowcy[licznik % kierowcy] +
                        "', '" + i + "', '" + id_konternerow[licznik % 7] + "'),");
                        licznik++;
                    }

                    dzien++;
                }
            }
        }
    }
}
