using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();

            
            
            Random ran = new Random();
            int[,] minuettenArray = new int[12, 16];
            int[,] trioenArray = new int[6, 16];
            int n = 0;
            for (int i = 0; i<minuettenArray.GetLength(0);i++)
            {
                for (int j = 0; j < minuettenArray.GetLength(1); j++)
                {
                    
                    for (int m = 0; m < minuettenArray.GetLength(0); m++)
                    {
                        for (int p = 0; p < minuettenArray.GetLength(1); p++)
                        {
                            do
                            {
                                n = ran.Next(1, 177);
                            } while (minuettenArray[m, p] == n);
                        }
                    }
                    minuettenArray[i, j] = n;
                    
                }
            }
            for (int i = 0; i<trioenArray.GetLength(0); i++)
            {
                for (int j = 0; j < trioenArray.GetLength(1); j++)
                {
                    for (int m = 0; m < trioenArray.GetLength(0); m++)
                    {
                        for (int p = 0; p < trioenArray.GetLength(1); p++)
                        {
                            do
                            {
                                n = ran.Next(1, 97);
                            } while (trioenArray[m, p] == n);
                        }
                    }
                    trioenArray[i, j] = n;
                }
            }
            
            

            string[] musikArray = new string[32];
            for (int i = 0; i < 32; i++)
            {
                if (i < 16)
                {
                    int terning1 = ran.Next(1, 7);
                    int terning2 = ran.Next(1, 7);
                    int minuettenTerning = terning1 + terning2 -1 ;
                    musikArray[i] = "M" + minuettenArray[minuettenTerning, i] ;
                    
                }
                else
                {
                    
                    int trioenTerning = ran.Next(1, 7) - 1;
                    musikArray[i] = "T" + trioenArray[ trioenTerning, i-16];
                }
                musikArray[i] = musikArray[i] + ".wav";
               
            }
            foreach (string musik in musikArray){
                Console.WriteLine(musik);
                player.SoundLocation = @"E:\Programmering\GrundlæggendeProgrammering\Mozart\Wave\" + musik;
                player.Load();
                player.PlaySync();
            }    

        }
    }
}
