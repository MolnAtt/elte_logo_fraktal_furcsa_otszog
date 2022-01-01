using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */


		/* Függvények vége */
		void FELADAT()
		{
			Fra5(4, 50);
		}

		void Fra(int szint, double méret)
		{
			if (szint > 1)
			{
				Fra(szint - 1, méret / 2);
				Jobbra(72);
				Fra(szint - 1, méret / 2);
				Balra(144);
				Fra(szint - 1, méret / 2);
				Balra(72);
				Fra(szint - 1, méret / 2);
				Jobbra(72);
				Fra(szint - 1, méret / 2);
				Jobbra(72);
				Fra(szint - 1, méret / 2);
			}
			else
				Előre(méret);
		}
		void Fra5(int szint, double méret)
		{
            for (int i = 0; i < 5; i++)/*#ism#*/
            {
				Fra(szint, méret);
				Jobbra(72);
            }
		}
	}
}
