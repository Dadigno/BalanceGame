using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceGame
{
    public partial class Information_form : Form
    {
        Game main_form;
        public Information_form(Game main_form)
        {
            this.main_form = main_form;
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            main_form.Enabled = true;
        }
    }
}
