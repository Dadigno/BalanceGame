using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace BalanceGame
{
    public partial class Game : Form
    {
        NameValueCollection Configuration_file;
        Size screen;
        MemberInfo[] myMemberInfo;

        //Controls
        List<Control> menu_controls;
        List<Control> game_controls;

        public Game()
        {
            screen = Screen.PrimaryScreen.Bounds.Size;

            InitializeComponent();

            menu_controls = new List<Control>() { panel_menu, button_exit, button_options, button_start, info_button, title_label, info_label,
                                                  save_options_button, title_options, reset_settings_button, color_combobox, return_menu_button, background_color_label, range_to_label, range_from_label, weight_to_combobox, weight_from_combobox, weight_range_label, language_label, language_combobox
            };
            game_controls = new List<Control>() {
                onplate_1000, weight_1000, weight_1000_sprite, weight_1000_button, weight_1000_label, panel_onplate_1000, panel_plateweight_1000,
                onplate_500, weight_500, weight_500_sprite, weight_500_button, weight_500_label, panel_onplate_500, panel_plateweight_500,
                onplate_100, weight_100, weight_100_sprite, weight_100_button, weight_100_label, panel_onplate_100, panel_plateweight_100,
                onplate_10, weight_10, weight_10_sprite, weight_10_button, weight_10_label, panel_onplate_10, panel_plateweight_10,
                onplate_5, weight_5, weight_5_sprite, weight_5_button, weight_5_label, panel_onplate_5, panel_plateweight_5,
                onplate_1, weight_1, weight_1_sprite, weight_1_button, weight_1_label, panel_onplate_1, panel_plateweight_1,
                weight_text, balance_indicator, weight_inc, balance_rightplate, balance_leftplate, undo, clear, new_weight, balance_body, return_menu,
                tutorial_button, 
                debug_arrowX, debug_reached, debug_target,
                panel_plate_left, panel_plate_right,
            };
           
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

            InitializeGame();
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

        private void resize_control(Control ctrl)
        {
            //Dimension
            Size t = ctrl.Size;
            ctrl.Width = (t.Width * screen.Width) / 1920;
            ctrl.Height = (t.Height * screen.Height) / 1080;

            //Location
            Point p = ctrl.Location;
            ctrl.Location = new Point( (p.X * screen.Width) / 1920, ( p.Y * screen.Height) / 1080);

            //Font
            Font font = ctrl.Font;
            float s = font.Size;
            float newSize = (s * screen.Height) / 1080;
            ctrl.Font = new Font(font.FontFamily, newSize, font.Style, font.Unit, font.GdiCharSet);

        }
    }
}
