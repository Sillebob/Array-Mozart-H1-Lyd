using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Mozart_H1_Lyd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           //MINUET
            string[] filesM = new string[16];/*erklærer et string array med plads til minuetfilerne.
                                              * Der kan kun være 16 filer pr. gennemløb af forløkken*/

            int[,] minuet = new int[11, 16]
            #region Tal i arrayet
            {

                { 96, 22, 141, 41, 105, 122, 11, 30, 70, 121, 26, 9, 112, 49, 109, 14 },
                { 32, 6, 128, 63, 146, 43, 134, 81, 117, 39, 126, 56, 174, 18, 116, 83 },
                { 69, 95, 158, 13, 153, 55, 110, 24, 66, 139, 15, 132, 73, 58, 145, 79 },
                { 40, 17, 113, 85, 161, 2, 159, 100, 90, 176, 7, 34, 67, 160, 52, 170, },
                { 148, 74, 163, 45, 80, 97, 36, 107, 25, 143, 64, 125, 76, 136, 1, 93 },
                { 104, 157, 27, 167, 154, 68, 118, 91, 138, 71, 150, 29, 101, 162, 23, 151 },
                { 152, 60, 171, 53, 99, 133, 21, 127, 16, 155, 57, 175, 43, 168, 89, 172 },
                { 119, 84, 114, 50, 140, 86, 169, 94, 120, 88, 48, 166, 51, 115, 72, 111 },
                { 98, 142, 42, 156, 75, 129, 62, 123, 65, 77, 19, 82, 137, 38, 149, 8 },
                { 3, 87, 165, 61, 135, 47, 147, 33, 102, 4, 31, 164, 144, 59, 173, 78 },
                { 54, 130, 10, 103, 28, 37, 106, 5, 35, 20, 108, 92, 12, 124, 44, 131 }
            };
            #endregion

            Random ran = new Random();//Til brug til terningekastet
            for (int i = 0; i < 16; i++)
            {
                int terningekastM = ran.Next(1, 7) + ran.Next(1,7);//to terninger med tilfældige tal
                filesM[i] = @"C:\Users\mari47jg\source\repos\Mozart H1 Lyd\Mozart H1 Lyd\Resources\M" + minuet[(terningekastM -2), (i)] + ".wav";
                //Trækker 2 fra da det laveste terningkast man kan få er 2 men index starter på 0
            
            }
            
            Afspil(filesM);
           
            //TRIO
            string[] filesT = new string[16];//Der kan kun være 16 filer pr. gennemløb af forløkken
            int[,] trio = new int[6, 16]
            #region Tal i array
            {
                { 72, 6, 59, 25, 81, 41, 89, 13, 36, 5, 46, 79, 30, 95, 19, 66 },
                { 56, 82, 42, 74, 14, 7, 26, 71, 76, 20, 64, 84, 8, 35, 47, 88 },
                { 75, 39, 54, 1, 65, 43, 15, 80, 9, 34, 93, 48, 69, 58, 90, 21 },
                { 40, 73, 16, 68, 29, 55, 2, 61, 22, 67, 49, 77, 57, 87, 33, 10 },
                { 83, 3, 28, 53, 37, 17, 44, 70, 63, 85, 32, 96, 12, 23, 50, 91 },
                { 18, 45, 62, 38, 4, 27, 52, 94, 11, 92, 24, 86, 51, 60, 78, 31 }
            };
            #endregion
            
            for (int i = 0; i < 16; i++)
            {
                int terningekastT = ran.Next(1, 7);                            
                filesT[i] = @"C:\Users\mari47jg\source\repos\Mozart H1 Lyd\Mozart H1 Lyd\Resources\T" + minuet[(terningekastT-1), (i)] + ".wav";
                //Trækker en fra da laveste terningkast er 1 men index starter på 0
            }
            Afspil(filesT);

           
        }
        
        //Opretter metode til musikafspilning
        public static void Afspil(string[] arraynavn)
        {
            SoundPlayer sp = new SoundPlayer();
            foreach (string musicelementT in arraynavn)

            {

                sp.SoundLocation = musicelementT;

                sp.Load();

                sp.PlaySync();

            }
        }
    }

}
    

