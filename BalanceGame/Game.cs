using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Linq;

namespace BalanceGame
{
    public partial class Game : Form
    {
        NameValueCollection Configuration_file;
        Size screen;
        MemberInfo[] myMemberInfo;

        public Game()
        {
            screen = Screen.PrimaryScreen.Bounds.Size;

            InitializeComponent();

            /*Control ctrl = this.TopLevelControl;
            

            foreach (var pb in ctrl.Controls.OfType<Label>())
            {
                Size t = pb.Size;
                pb.Width = (t.Width * screen.Width) / 1920;
                pb.Height = (t.Height * screen.Height) / 1080;
            }
            foreach (var pb in ctrl.Controls.OfType<TextBox>())
            {
                Size t = pb.Size;
                pb.Width = (t.Width * screen.Width) / 1920;
                pb.Height = (t.Height * screen.Height) / 1080;
            }
            foreach (var pb in ctrl.Controls.OfType<PictureBox>())
            {
                Size t = pb.Size;
                pb.Width = (t.Width * screen.Width) / 1920;
                pb.Height = (t.Height * screen.Height) / 1080;
            }
            foreach (var pb in ctrl.Controls.OfType<Button>())
            {
                Size t = pb.Size;
                pb.Width = (t.Width * screen.Width) / 1920;
                pb.Height = (t.Height * screen.Height) / 1080;
            }
            foreach (var pb in ctrl.Controls.OfType<Panel>())
            {
                Size t = pb.Size;
                pb.Width = (t.Width * screen.Width) / 1920;
                pb.Height = (t.Height * screen.Height) / 1080;
            }*/

            InitializeMenu();

            
           
        }

        private static void SetSetting(string key, string value)
        {
            Configuration configuration =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
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
                    
                    if(Configuration_file.Get("Default_conf") == "True")
                    {
                        //Load deafult configuration
                        set_configuration(true);
                    }
                    else
                    {
                        //Load from config file a custom configuration
                        set_configuration();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex.Message);
                    Console.WriteLine("Default configuration loaded");
                    set_configuration(true);
                }
            }
            else
            {
                set_configuration(true);
                Console.WriteLine("No config file found, default configuration loaded");
            }

            init_gamevars();
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
