using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;

namespace BalanceGame
{
    public partial class Game : Form
    {
        NameValueCollection Configuration_file;

        public Game()
        {
            InitializeComponent();
        }

        public static bool CheckConfigFileIsPresent()
        {
            return File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void Game_Load(object sender, EventArgs e)
        {

            if (CheckConfigFileIsPresent())
            {
                try
                {
                    Configuration_file = ConfigurationManager.AppSettings;
                    foreach (string s in Configuration_file.AllKeys)
                        Console.WriteLine("Loading " + s + ": " + Configuration_file.Get(s));
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex.Message);
                }
            } 
            else
            {
                Console.WriteLine("No config file found, default configuration loaded");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
