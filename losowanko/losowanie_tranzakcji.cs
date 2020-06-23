using System;
using System.IO;

namespace losowanko
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            double pomoc;
            string linia = "";
            using (StreamWriter file = new StreamWriter(@"C:\Users\kasia\Documents\GitHub\bazy_danych_pwr\dane_do_losowania\insert.txt"))
            {
                file.WriteLine("INSERT INTO tranzakcje(uznania, kwota)\nVALUES");
                for (int i = 0; i < 620; i++)
                {
                    linia = "";
                    pomoc = rnd.Next(0, 99);
                    if (pomoc > 78)
                        linia += "(0, ";
                    else
                        linia += "(1, ";
                    pomoc = rnd.Next(0, 99);
                    if(pomoc > 85)
                    {
                        linia += rnd.Next(10, 100);
                    }
                    else if (pomoc > 20)
                    {
                        linia += rnd.Next(100, 600);
                    }
                    else if(pomoc > 1)
                    {
                        linia += rnd.Next(600, 1500);
                    }
                    else
                    {
                        linia += rnd.Next(3000, 10000);
                    }
                    linia += "." + rnd.Next(0, 99) + "),";
                    file.WriteLine(linia);
                }
            }
        }
    }
}
