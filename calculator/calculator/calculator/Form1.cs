using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double suma = 0;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pnlTeza.Visible = false;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtNote.Text.Trim() == "")
            {
                return;
            }
            lstNote.Items.Add(txtNote.Text);
            txtNote.Clear();
            txtNote.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNote.Clear();
            lstNote.Items.Clear();
            pnlTeza.Visible = false;
            if(radCuTeza.Checked)
            {
                radCuTeza.Checked = false;
            }
            if (radFaraTeza.Checked)
            {
                radFaraTeza.Checked = false;
            }
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            if (radCuTeza.Checked == true || radFaraTeza.Checked == true)
            {
                for (int i = 0; i < lstNote.Items.Count; i++)
                {
                    suma = Math.Round(suma + Convert.ToDouble(lstNote.Items[i]), 2);
                }
                suma = suma / lstNote.Items.Count;
                if (radFaraTeza.Checked == true)
                {
                    lblMedie.Text = suma.ToString();
                }
                else
                {
                    total = ((suma * 3) + Convert.ToDouble(txtTeza.Text)) / 4;
                    lblMedie.Text = total.ToString();
                }
            }
            else
            {
                return;
            }

        }

        private void radFaraTeza_CheckedChanged(object sender, EventArgs e)
        {
            if (radFaraTeza.Checked == true)
            {
                pnlTeza.Visible = false;
            }
            
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            lstNote.Items.Remove(lstNote.SelectedItem);
        }

        private void radCuTeza_CheckedChanged(object sender, EventArgs e)
        {
            if(radCuTeza.Checked == true)
            {
                pnlTeza.Visible = true;
                txtTeza.Focus();
            }
        }
    }
}
