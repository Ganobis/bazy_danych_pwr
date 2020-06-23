using System;
using System.IO;

namespace losowanko
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            string[] nr_konta = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\dodatkowe_informacje.txt");
            string[] imie = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\imiona.txt"); //200
            string[] nazwisko = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\nazwiska.txt"); //50
            string[] pesel = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\pesele.txt"); //100
            string[] telefon = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\telefony.txt"); //100
            string[] miasta = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\miasta.txt"); //13
            string[] d_zat = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\data_z.txt"); //15
            string[] d_kon = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\data_k.txt"); //15
            string[] stanowisko = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\stanowiska.txt"); //15
            using (StreamWriter file = new StreamWriter(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\insert.txt"))
            {
                file.WriteLine("INSERT INTO pracownicy(imie, nazwisko, pesel, nr_konta, telefon, data_zatrudnienia, data_konca_umowy, stanowiska)\nVALUES");
                for (int i = 0; i < 15; i++)
                {
                    file.WriteLine("('" + imie[rnd.Next(0, 199)] + "', '" + nazwisko[rnd.Next(0, 49)] + "', '" + pesel[i] + "', '" +
                                        nr_konta[i] + "', '"  + miasta[rnd.Next(0, 12)] + "', '" + telefon[i] + "', '" + d_zat[i] +
                                        "', '" + d_kon[i] + "', '" +  stanowisko[i] +"'),");
                }
            }
        }
    }
}
