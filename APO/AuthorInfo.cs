using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Czerniawski
{
    public partial class AuthorInfo : Form
    {
        public AuthorInfo()
        {
            InitializeComponent();
            label1.Text = "Steganografia" + Environment.NewLine
                                          + "Autor: Łukasz Czerniawski" + Environment.NewLine
                                          + "Prowadzący: mgr inż. Roszkowiak Łukasz" + Environment.NewLine
                                          + "Algorytmy Przetwarzania Obrazów 2019" + Environment.NewLine
                                          + "Inżynieria oprogramowania grupa ID06IO2";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
