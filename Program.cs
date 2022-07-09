using System;
using System.Windows.Forms;

namespace plappy_bird
{
    static class Program
    {
        [MTAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Form2());
        }

    }
}