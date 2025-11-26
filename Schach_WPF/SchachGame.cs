using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schach_WPF
{
    public class SchachGame
    {
        public int AmZug { get; set; } // Weiß = 0 , Schwarz = 1
        public int[] Punkte { get; set; } = { 0, 0 };
        
        public Feld Spielfeld { get; set; }

        public SchachGame(Feld SpielFeld, int AmZug = 0, int[]? Punkte = null )
        {
            Spielfeld = new Feld();
            AmZug = 0;

            if (Punkte != null)
            {
                this.Punkte = Punkte;
            }
            else
            {
                this.Punkte = new int[] { 0, 0 };
            }

        }




    }
}
