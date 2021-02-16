using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceGame
{
    partial class Game : Form
    {
        List<int> weights_selected = new List<int>();
        int value_reached = 0;
        int target = 0;
        private void init_gamevars()
        {
            Random r = new Random();
            target = r.Next(Globals.weight_from, Globals.weight_to); //for ints
        }


        private void return_menu_click(object sender, EventArgs e)
        {
            panel_game.Hide();
            panel_menu.Show();
        }

        private void weight_1_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Show();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_5_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Show();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_10_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Show();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_100_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Show();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_500_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Show();
            panel_onplate_1000.Hide();
        }

        private void weight_1000_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Show();
        }

        private void onplate_1_click(object sender, EventArgs e)
        {
            add_weight(1);
        }

        private void onplate_5_click(object sender, EventArgs e)
        {
            add_weight(5);
        }

        private void onplate_10_click(object sender, EventArgs e)
        {
            add_weight(10);
        }

        private void onplate_100_click(object sender, EventArgs e)
        {
            add_weight(100);
        }

        private void onplate_500_click(object sender, EventArgs e)
        {
            add_weight(500);
        }

        private void onplate_1000_click(object sender, EventArgs e)
        {
            add_weight(1000);
        }

        private void clear_click(object sender, EventArgs e)
        {
            /*panel_plateweight_1.Hide();
            panel_plateweight_5.Hide();
            panel_plateweight_10.Hide();
            panel_plateweight_100.Hide();
            panel_plateweight_500.Hide();
            panel_plateweight_1000.Hide();*/
            weights_selected.Clear();
            refresh_game();
        }

        private void add_weight(int weight)
        {
            weights_selected.Add(weight);
            refresh_game();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            weights_selected.RemoveAt(weights_selected.Count - 1);
            refresh_game();
        }

        private void refresh_game()
        {
            //Count the number of weights
            var q = from x in weights_selected
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };

            value_reached = 0;
            foreach (var x in q)
            {
                value_reached += (x.Value * x.Count);

                switch (x.Value)
                {
                    case 1:
                        if (x.Count > 0)
                        {
                            panel_plateweight_1.Show();
                            weight_1_label.Text = "x" + x.Count;
                        }
                        else
                        {
                            panel_plateweight_1.Hide();
                        }
                        break;
                    case 5:
                        if (x.Count > 0)
                        {
                            panel_plateweight_5.Show();
                            weight_5_label.Text = "x" + x.Count;
                        }
                        else
                        {
                            panel_plateweight_5.Hide();
                        }
                        break;
                    case 10:
                        if (x.Count > 0)
                        {
                            panel_plateweight_10.Show();
                            weight_10_label.Text = "x" + x.Count;
                        }
                        else
                        {
                            panel_plateweight_10.Hide();
                        }
                        break;
                    case 100:
                        if (x.Count > 0)
                        {
                            panel_plateweight_100.Show();
                            weight_100_label.Text = "x" + x.Count;
                        }
                        else
                        {
                            panel_plateweight_100.Hide();
                        }
                        break;
                    case 500:
                        if (x.Count > 0)
                        {
                            panel_plateweight_500.Show();
                            weight_500_label.Text = "x" + x.Count;
                        }
                        else
                        {
                            panel_plateweight_500.Hide();
                        }
                        break;
                    case 1000:
                        if (x.Count > 0)
                        {
                            panel_plateweight_1000.Show();
                            weight_1000_label.Text = "x" + x.Count;
                        }
                        else
                        {
                            panel_plateweight_1000.Hide();
                        }
                        break;
                }
            }
        }

    }

}
