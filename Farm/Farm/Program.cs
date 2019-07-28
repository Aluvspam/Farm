using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FarmClasses;
using FarmClasses.Enums;

namespace Farm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new FarmAction().ReadAnimals("[09:38:47] Horses like this one have many uses." + Environment.NewLine + "[09:38:47] It has been branded by and belongs to the settlement of Bragadiru." + Environment.NewLine + "[09:38:47] It is being taken care of by Andrei."+Environment.NewLine+ "[09:38:47] He is very strong and has a good reserve of fat." + Environment.NewLine + "[09:38:47] It has lightning movement. It has very strong leg muscles. It seems overly aggressive. It has a certain spark in its eyes. " + Environment.NewLine + "[09:38:47] Its colour is blood bay.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
