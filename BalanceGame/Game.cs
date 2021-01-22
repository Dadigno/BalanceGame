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
            InitializeMenu();

            
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
                    //foreach (string s in Configuration_file.AllKeys)
                    //    Console.WriteLine("Loading " + s + ": " + Configuration_file.Get(s));
                    if (Configuration_file.Get("Lang") != "EN")
                    {
                        Language_load(Configuration_file.Get("Lang"));
                    }
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

        private void Language_load(string language) /* TODO */
        {
            Console.WriteLine("Only EN language is supported");
            /*if (language == "IT")
            {
                
                title_label.Text = Configuration_file.Get("Title_label");
                button_exit.Text = Configuration_file.Get("Button_exit_text");
                button_start.Text = Configuration_file.Get("Title_label");
                return_menu.Text = Configuration_file.Get("return_menu");
                button_options.Text = Configuration_file.Get("button_options");
            }
            else
            {

            }*/
        }

    }
}
