using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ColdWarScript
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread recoilThread = new Thread(Recoil);
            recoilThread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        static int[] RecoilAmount(string weapon)
        {
            if (weapon == "Krig")
                return new int[] {3, 0, 182 };
            if (weapon == "XM4")
                return new int[] { 6, 0, 200 };
            if (weapon == "AK47U")
                return new int[] { 8, -2, 193 };
            if (weapon == "LC10")
                return new int[] { 11, 0, 222 };

            return new int[] { 0, 0 };
        }

        static void Recoil()
        {
            while (true)
            {
                if (Form1.enable && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
                {
                    try
                    {
                        Mouse.RelativeMove(RecoilAmount(Form1.weapon)[1], Convert.ToInt32(RecoilAmount(Form1.weapon)[0] / Form1.smooth));
                        Thread.Sleep(RecoilAmount(Form1.weapon)[2]);
                    }
                    catch
                    {}
                }
            }
        }
    }
}
