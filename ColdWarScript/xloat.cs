using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWarScript
{

    public partial class xloat : Form
    {
        public static bool enable;
        public static string weapon;
        public static int smooth;
        public static int clickInterval;

        public xloat()
        {
            InitializeComponent();
        }

        private void enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableCheckBox.Checked)
                enable = true;
            else
                enable = false;
        }

        private void weaponCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon = weaponCombo.Text;
        }

        private void smoothSlider_Scroll(object sender, EventArgs e)
        {
            smooth = smoothSlider.Value;
            smoothValue.Text = smoothSlider.Value.ToString();
        }
        private void autoClickInterval_Scroll_1(object sender, EventArgs e)
        {
            clickInterval = autoClickInterval.Value;
            autoClickIntervalValue.Text = autoClickInterval.Value.ToString();
        }

        private void xloat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


    }

}
