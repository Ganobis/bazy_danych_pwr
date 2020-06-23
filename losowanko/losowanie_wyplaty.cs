using System; 
using System.IO;

namespace losowanko
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            string s = "(";
            string[,] dane = new string[3, 12] { {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"}, 
                                 { "kierownik", "kierowca", "magazynier", "ksiegowy", "kierowca", "kierowca", "kierowca", "konserwator", "magazynier", "kierowca", "kierownik", "planer" },
                                 { "04-01", "04-01", "04-01", "04-01", "04-01", "04-01", "04-01", "04-01", "23-01", "21-02", "08-03", "09-03" } }; 
            using (StreamWriter file = new StreamWriter(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\insert.txt"))
            {
                file.WriteLine("INSERT INTO wyplaty(id_pracownika, data, pensja, premmia)\nVALUES");
                for (int i = 1; i < 6; i++) // do 5 bo 5 miesiecy
                {
                    for(int j = 0; j < 11; j++)  //bo 11 osób
                    {
                        if(dane[2, j][4] - '0' < i)
                        {
                            s += dane[0, j] + " , '08-0" + (i+1).ToString() + "-2020', " + Zbierz_wynagodzenie(dane[1, j]) + ", ";
                            if (rnd.Next(0, 100) > 80)
                            {
                                if (rnd.Next(0, 100) > 80)
                                    s +=  rnd.Next(200, 500);
                                else
                                    s += rnd.Next(50, 150);
                            }
                            else
                                s += "NULL";
                            s +=  "),";
                            file.WriteLine(s);
                            s = "(";
                        }
                        else if(dane[2, j][4] - '0' == i)
                        {
                            s +=  dane[0, j] + " , '08-0" + (i+1).ToString() + "-2020, " + (int)(Zbierz_wynagodzenie(dane[1, j]) * ((29.5 - (((dane[2, j][0] - '0') * 10) + (dane[2, j][1] - '0'))) / 29.5)) + ", NULL),";
                            file.WriteLine(s);
                            s = "(";
                        }
                    }
                }
            }
        }
        static int Zbierz_wynagodzenie(string s)
        {
            if (s.Equals("kierowca"))
                return 3900;
            if (s.Equals("kierownik"))
                return 5500;
            if (s.Equals("magazynier"))
                return 2780;
            if (s.Equals("ksiegowy"))
                return 2750;
            if (s.Equals("konserwator"))
                return 2600;
            if (s.Equals("planer"))
                return 3800;
            return 0;
        }
    }
}
