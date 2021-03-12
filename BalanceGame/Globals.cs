using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace BalanceGame
{
    public class Globals
    {
        public static NameValueCollection Configuration_file;
        /// <summary>
        ///  Default configuration
        /// </summary>

        //App settings
        public static readonly System.Drawing.Color backColor_default = System.Drawing.Color.FromName("HighLight");
        public static readonly string language_default = "English";
        public static readonly int weight_from_default = 1;
        public static readonly int weight_to_default = 2000;

        public static readonly int weight_from_to_maximum_default = 2000;
        public static readonly int weight_from_to_minimum_default = 1;

        //Panel menu 
        public static readonly string label_title_default = "Balance game";
        public static readonly string button_text_start_default = "Start Game";
        public static readonly string button_text_options_default = "Options"; 
        public static readonly string button_text_exit_default = "Exit";
        public static readonly string label_information_default = "Info";

        //Panel options
        public static readonly string label_title_options_default = "Options";
        public static readonly string label_language_default = "Language";
        public static readonly string label_weightrange_default = "Weight range (g)";
        public static readonly string label_rangefrom_default = "From";
        public static readonly string label_rangeto_default = "To";
        public static readonly string label_background_color_default = "Background color";
        public static readonly string button_text_resetsettings_default = "Reset Settings";

        //Panel game
        public static readonly string button_text_returnmenu_default = "MAIN MENU";
        public static readonly string button_text_newweight_default = "NEW WEIGHT";
        public static readonly string button_text_clear_default = "CLEAR";
        public static readonly string button_text_tutorial_default = "Tutorial";
        public static readonly string textbox_weight_default = "WEIGHTS (grams)";

        //Form information
        public static readonly string label_information_title_default = "Balance Game, V1.1.0";
        public static readonly string caption_information_default = "About the game";
        public static readonly string info_text1_default = "This game was created by Davide Orengo and Giorgio Demarzi. \n A.A. 20-21 Human Co" +
    "mputer Interaction course";
        public static readonly string info_text2_default = "Contact us if you have encountered problem with the game";
        public static readonly string info_text3_default = "Share the project and support us!";
        public static readonly string contacts_label_default = "Contacts";
        public static readonly string label_email = "email@email.it";


      
      
        //Messages

        public static string exiting_without_saving_message = "Are you sure you want return to the menu without saving? Any changes made will not be saved.";
        public static string exiting_without_saving_caption = "Exit without saving?";

        public static string exit_game_message = "Are you sure you want to close?";
        public static string exit_game_caption = "Exit game";

        public static string saving_message = "The modified will be effective only after restarting the game";
        public static string saving_caption = "Information";

        
        public static string finish_game_message = "Great! The weight is {0}g!  \nClick YES to restart e new game or click NO if you want return to the menù";
        public static string finish_game_caption = "Game Over";

        //ITA tutorial
        public static string tutorial_text_intro_default = "Con questo tutorial imparerai come giocare a Balance Game.\n\nSe lo desideri puoi chiudere questa finestra cliccando sul tasto Skip in basso a sinistra, altrimenti continua su Next";
        public static string tutorial_text_page1 = "Page 1";
        public static string tutorial_text_page2 = "Page 2";


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



    }
}
