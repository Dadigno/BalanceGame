using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceGame
{
    public class Globals
    {
        public string[] language_list;

        /// <summary>
        ///  Default configuration
        /// </summary>

        //App settings
        public static readonly System.Drawing.Color backColor_default = System.Drawing.Color.FromName("HighLight");
        public static readonly string language_default = "English";
        public static readonly int weight_from_default = 1;
        public static readonly int weight_to_default = 10000;
        public static readonly int weight_from_to_maximum_default = 50000;
        public static readonly int weight_from_to_minimum_default = 1;

        //Panel menu 
        public static readonly string button_start_text_default = "Start Game";
        public static readonly string button_options_text_default = "Options"; 
        public static readonly string button_exit_text_default = "Exit";
        public static readonly string title_options_text_default = "Options";

        //Panel options
        public static readonly string language_label_text_default = "Language";
        public static readonly string weightrange_label_text_default = "Weight range (g)";
        public static readonly string range_from_label_text_default = "From";
        public static readonly string range_to_label_text_default = "To";
        public static readonly string background_color_label_text_default = "Background color";
        public static readonly string reset_settings_button_text_default = "Reset Settings";
        public static readonly string save_options_button_text_default = "Save";


        //Messages

        public static readonly string exiting_without_saving_message = "Are you sure you want return to the menu without saving? Any changes made will not be saved.";
        public static readonly string exiting_without_saving_caption = "Exit without saving?";

        public static readonly string exit_game_message = "Are you sure you want to close?";
        public static readonly string exit_game_caption = "Exit game";

        public static readonly string saving_message = "The modified will be effective only after restarting the game";
        public static readonly string saving_caption = "Information";

        /// <summary>
        /// Game configuration
        /// </summary>

        //Game variables
        public static string language;
        public static int weight_from;
        public static int weight_to;
        public static int weight_from_to_maximum;
        public static int weight_from_to_minimum;
        public static System.Drawing.Color backColor;
        /*
        //Panel menu 
        public static string button_start_text;
        public static string button_options_text;
        public static string button_exit_text;
        public static string title_options_text;

        //Panel options
        public static string language_label_text;
        public static string weightrange_label_text;
        public static string range_from_label_text;
        public static string range_to_label_text;
        public static string background_color_label_text;
        public static string reset_settings_button_text;
        public static string save_options_button_text;
        */


    }
}
