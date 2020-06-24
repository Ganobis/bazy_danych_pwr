using System; 
using System.IO;

namespace losowanko
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            string[] imie = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\imiona.txt"); //195
            string[] nazwisko = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\nazwiska.txt"); //50
            string[] pesel = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\pesele.txt"); //100
            string[] telefon = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\telefony.txt"); //100
            string[] dodatkowe = File.ReadAllLines(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\dodatkowe_informacje.txt"); //100
            using (StreamWriter file = new StreamWriter(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\insert.txt"))
            {
                file.WriteLine("INSERT INTO klienci(imie, nazwisko, telefon, pesel, dodatkowe_informacje)\nVALUES");
                for(int i =  0; i < 35; i++)
                {
                    file.WriteLine("('" + imie[rnd.Next(0, 194)] + "', '" + nazwisko[rnd.Next(0, 49)] + "', '" + telefon[i] + "', '" + pesel[i] + "', " +
                                   dodatkowe[rnd.Next(0, 11)] + "),");
                }
            }
        }
    }
}
