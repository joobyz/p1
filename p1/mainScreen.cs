using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetID;

namespace p1
{
    public partial class mainScreen : Form
    {
        private string      logname;
        private string      val;
        private int         matchesFirst;
        private int         matchesSecond;

        GetID.GetID getID = new GetID.GetID();
        

        public mainScreen()
        {
            InitializeComponent();

            getID.ValueChanged += (s, e) => {
                CheckValue(getID.Value);
            };
            getID.ErrorChanged += (s, e) => {
                ShowError(getID.ErrorMessage);
            };
        }

        #region EventHandlers
        private void ShowError(string errorMessage)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowError), new object[] { errorMessage });
                return;
            }

            txt_right.Text += Environment.NewLine + errorMessage;
        }

        private void CheckValue(string value)
        {
            val = getID.Value;

            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(CheckValue), new object[] { value });
                return;
            }

            if (val.Length == 5)
            {
                string first    = val.Remove(1, 4);
                string second   = val.Substring(1);

                matchesFirst    = Regex.Matches(first, @"[A-Z]").Count;
                matchesSecond   = Regex.Matches(second, @"[0-9]").Count;

                if (matchesFirst == 1 && matchesSecond == 4)
                {
                    txt_left.Text +=  val + " MEGFELELŐ" + Environment.NewLine;
                }
                else
                {
                    txt_left.Text += val + " NEM MEGFELELŐ" + Environment.NewLine;
                }
                
            }
            else
            {
                txt_left.Text += val + " NEM MEGFELELŐ" + Environment.NewLine;
            }
        }
        #endregion


        #region ButtonClickEvents
        private void btn_start_Click(object sender, EventArgs e)
        {
            getID.Go();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            getID.Stop();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            logname = "log-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            using (StreamWriter objWriter = new StreamWriter(logname))
            {
                objWriter.Write(txt_left.Text);
                MessageBox.Show("Log fájl mentése megtörtént: " + logname);
            }
        }
        #endregion
    }
}
