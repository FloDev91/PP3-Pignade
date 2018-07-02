using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_GoToFenAjoutClient_Click(object sender, EventArgs e)
        {
            FenAjoutClient FenAjoutClient = new FenAjoutClient();
            FenAjoutClient.Tag = this;
            FenAjoutClient.Show(this);
            Hide();
        }

        private void bt_GoToFenAjoutPersonnel_Click(object sender, EventArgs e)
        {
            FenAjoutPersonnel FenAjoutPersonnel = new FenAjoutPersonnel();
            FenAjoutPersonnel.Tag = this;
            FenAjoutPersonnel.Show(this);
            Hide();
        }

        private void bt_GoToFenAjoutActivite_Click(object sender, EventArgs e)
        {
            FenAjoutActivite FenAjoutActivite = new FenAjoutActivite();
            FenAjoutActivite.Tag = this;
            FenAjoutActivite.Show(this);
            Hide();
        }

        private void bt_GoToFenActivite_Click(object sender, EventArgs e)
        {
            FenActivite FenActivite = new FenActivite();
            FenActivite.Tag = this;
            FenActivite.Show(this);
            Hide();
        }
    }
}
