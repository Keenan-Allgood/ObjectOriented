﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the aapplication.
        /// </summary> keenan was here
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TableDA.GetAllTables();
            Application.Run(new GUI());
            
        }
    }
}
