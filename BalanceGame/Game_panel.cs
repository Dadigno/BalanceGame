using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BalanceGame
{
    partial class Game : Form
    {
        List<int> weights_selected = new List<int>();
        int value_reached = 0;
        int target = 0;
        int avaliable_moves = 0;

        int arrow_offset;
        int arrow_max_pos;
        int plate_zero_pos;
        int plate_offset;
        

        private void InitializeGame()
        {
            //Rescale all components in panel game
            foreach (Control ctrl in game_controls)
            {
                /*if(ctrl.Text == "adfg" || ctrl.Text == "B")
                {
                    Console.WriteLine("Sono qui");
                }*/
                resize_control(ctrl);
            }

            Random r = new Random();
            target = r.Next(Globals.weight_from, Globals.weight_to);
            debug_target.Text = target.ToString();
            avaliable_moves = Globals.maximum_moves;

            //Initialice indicator
            arrow_offset = balance_indicator.Left;
            arrow_max_pos = arrow_offset + balance_body.Width / 2;
            plate_zero_pos = panel_plate_left.Location.Y; // = panel_plate_reight.Location.Y;
            plate_offset = (25 * screen.Height) / 1080;
            move_arrow();
            move_plate();
        }

        private void new_weight_click(object sender, EventArgs e)
        {
            clear_click(this, new EventArgs());

            Random r = new Random();
            target = r.Next(Globals.weight_from, Globals.weight_to);
            move_arrow();
            
            debug_target.Text = target.ToString();
        }

        private void clear_click(object sender, EventArgs e)
        {
            weights_selected.Clear();
            value_reached = 0;

            avaliable_moves = Globals.maximum_moves;
            moves_avaliable_value_label.Text = avaliable_moves.ToString();
            panel_win_lost.Hide();
            weight_result_label.Text = " ?  ?";

            refresh_game();
        }

        private void tutorial_button_Click(object sender, EventArgs e)
        {
            Tutorial_form tutorial_form = new Tutorial_form(this);
            tutorial_form.Show();
            this.Enabled = false;
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

        private void outplate_1_click(object sender, EventArgs e)
        {
            remove_weight(1);
        }

        private void outplate_5_click(object sender, EventArgs e)
        {
            remove_weight(5);
        }

        private void outplate_10_click(object sender, EventArgs e)
        {
            remove_weight(10);
        }

        private void outplate_100_click(object sender, EventArgs e)
        {
            remove_weight(100);
        }

        private void outplate_500_click(object sender, EventArgs e)
        {
            remove_weight(500);
        }

        private void outplate_1000_click(object sender, EventArgs e)
        {
            remove_weight(1000);
        }

        

        private void add_weight(int weight)
        {
            if (avaliable_moves > 0)
            {
                avaliable_moves -= 1;
                weights_selected.Add(weight);
                refresh_game();
            }
            
        }
         
        private void remove_weight(int weight)
        {
            if (avaliable_moves > 0)
            {
                avaliable_moves -= 1;
                weights_selected.Remove(weight);
                refresh_game();
            }
            
        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (weights_selected.Count > 0)
            {
                avaliable_moves += 1;
                panel_win_lost.Hide();
                weights_selected.RemoveAt(weights_selected.Count - 1);
                refresh_game();
            }
        }

        private void move_arrow()
        {
            
            int diff = target - value_reached;

            balance_indicator.Left -= (balance_indicator.Left - arrow_offset) + (int)((diff * balance_body.Size.Width * 0.5f) / target);

            if (balance_indicator.Left > arrow_max_pos)
            {
                balance_indicator.Left = arrow_max_pos;
            }

            debug_arrowX.Text = balance_indicator.Location.X.ToString();

        }

        private void move_plate()
        {
            if( value_reached > target)
            {
                panel_plate_left.Location = new Point(panel_plate_left.Location.X, plate_zero_pos - plate_offset);
                panel_plate_right.Location = new Point(panel_plate_right.Location.X, plate_zero_pos + plate_offset);
            }
            else if (value_reached < target)
            {
                panel_plate_left.Location = new Point(panel_plate_left.Location.X, plate_zero_pos + plate_offset);
                panel_plate_right.Location = new Point(panel_plate_right.Location.X, plate_zero_pos - plate_offset);
            }
            else
            {
                panel_plate_left.Location = new Point(panel_plate_left.Location.X, plate_zero_pos);
                panel_plate_right.Location = new Point(panel_plate_right.Location.X, plate_zero_pos);
            }
        }

        private void refresh_game()
        {

            panel_plateweight_1.Hide();
            panel_plateweight_5.Hide();
            panel_plateweight_10.Hide();
            panel_plateweight_100.Hide();
            panel_plateweight_500.Hide();
            panel_plateweight_1000.Hide();

            value_reached = 0;
            debug_reached.Text = value_reached.ToString();
            moves_avaliable_value_label.Text = avaliable_moves.ToString();
            
            //Count the number of weights
            if (weights_selected.Count > 0) { 
                var q = from x in weights_selected
                        group x by x into g
                        let count = g.Count()
                        orderby count descending
                        select new { Value = g.Key, Count = count };

                value_reached = 0;
                foreach (var x in q)
                {

                    value_reached += (x.Value * x.Count);
                    debug_reached.Text = value_reached.ToString();

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
            else
            {
                panel_plateweight_1.Hide();
                panel_plateweight_5.Hide();
                panel_plateweight_10.Hide();
                panel_plateweight_100.Hide();
                panel_plateweight_500.Hide();
                panel_plateweight_1000.Hide();
            }

            move_arrow();
            move_plate();


            if (value_reached == target)
            {
                /*var result = MessageBox.Show(String.Format(Globals.finish_game_message, value_reached), Globals.finish_game_caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.None);

                if (result == DialogResult.Yes)
                {
                    clear_click(this, new EventArgs());
                    new_weight_click(this, new EventArgs());
                }
                else
                {
                    clear_click(this, new EventArgs());
                    new_weight_click(this, new EventArgs());
                    return_menu_click(this, new EventArgs());
                }*/
                message_win_lost.Text = String.Format (Globals.finish_game_message, value_reached);

                weight_result_label.Text = String.Format(value_reached.ToString()) + "g";
                smile_sad.Hide();
                smile_happy.Show();
                panel_win_lost.Show();


            }

            if (avaliable_moves == 0 && value_reached != target)
            {
                message_win_lost.Text = String.Format(Globals.finish_game_nomoves);
                smile_sad.Show();
                smile_happy.Hide();
                panel_win_lost.Show();
            }
        }
    }
}
