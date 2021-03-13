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
        public static readonly string button_text_start_default = "Start";
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
        public static string saving_caption = "Pay attention";

        public static string finish_game_message = "Great! The weight is {0}g!  \nClick YES to restart e new game or click NO if you want return to the menù.";
        public static string finish_game_caption = "Game Over";

        //ITA tutorial
        public static string tutorial_text_intro_default = "Welcome to the Balance Game!\n\nYour goal is to measure the weight in grams of the unknown object.\n\n\n\n\n\n\nIf you wish you can close this tutorial by clicking on the Skip button at the bottom, otherwise continue to Next.";
        public static string tutorial_text_page1 = "You have to put on the right plate the weights presented on the menu.\n\nTo put a weight on the plate, you\nhave to click on the desired weight\nand then on the green button that\nwill appear next to the chosen\nweight.\n\nTo remove a weight on the plate\nyou have to click on the desired\nweight and then on the similar red\nbutton.";
        public static string tutorial_text_page2 = "Putting the weights on the plate, the indicator on the balance body moves. The goal is to make it reach the center.\n\nIn this way the balance is achieved and you know exactly the weight of the unknown object!";
        public static string tutorial_text_page3 = "Below the balance body there are four buttons.\nFrom left to right:\n\nMain menu: Lets you return to the main menu.\nNew weight: changes the weight value of the unknown object.\nClear: removes all the weights from the right plate.\nUndo: removes the last weight you put on the right plate.";
        public static string tutorial_text_page4 = "The tutorial is over!\n\nNow you can close this window\n\nHave fun!";

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
