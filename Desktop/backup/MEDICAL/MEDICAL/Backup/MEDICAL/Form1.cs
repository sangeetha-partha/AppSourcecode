using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MEDICAL
{ 
    
    public partial class Form1 : Form
    {
        DS.DS_USER.UserMst_SelectDataTable UDT = new DS.DS_USER.UserMst_SelectDataTable();
        DS.DS_USERTableAdapters.UserMst_SelectTableAdapter UAdapter = new MEDICAL.DS.DS_USERTableAdapters.UserMst_SelectTableAdapter();
        public string username;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbltime.Text = System.DateTime.Now.ToString();
            lblday.Text = System.DateTime.Now.DayOfWeek.ToString();



            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = System.Drawing.Color.DarkSeaGreen;
                }
                catch (Exception a)
                {

                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {

                MessageBox.Show("Enter Login Name !", "Medical System");
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Enter Login Password !", "Medical System");
            }
            else
            {
                UDT = UAdapter.SelectForLOGIN(txtname.Text, txtpass.Text);
                if(UDT.Rows.Count>0)
                { lblname.Text = "welcome " + txtname.Text;
                    username = txtname.Text;
                    txtname.Text = "";
                    txtpass.Text = "";
                    gplogin.Visible = false;
                    menulogout.Visible = true;
                    mENUToolStripMenuItem.Enabled = true;
                    sELLToolStripMenuItem.Enabled = true;
                    cLIENTSToolStripMenuItem.Enabled = true;
                    rEPORTSToolStripMenuItem.Enabled = true;
                    mANAGEUSERToolStripMenuItem.Enabled = true;
                    cOMPANYToolStripMenuItem.Enabled = true;
                   
                }
                else
                {
                    MessageBox.Show("Invalid LoginName OR Password !", "Medical System");
                }
            }
        }

        private void menulogout_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            gplogin.Visible = true;
            menulogout.Visible = false;
            mENUToolStripMenuItem.Enabled = false;
            sELLToolStripMenuItem.Enabled = false;
            cLIENTSToolStripMenuItem.Enabled = false;
            rEPORTSToolStripMenuItem.Enabled = false;
            mANAGEUSERToolStripMenuItem.Enabled = false;
            cOMPANYToolStripMenuItem.Enabled = false;

            lblname.Text = "";
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new ADDItem(username);
            additem.MdiParent = this;
            additem.Show();
        }
        private void closeExistingForm()
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception)
            {

            }

        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDNEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new UserMst(username);
            additem.MdiParent = this;
            additem.Show();
        }

        private void aDDNEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Company();
            additem.MdiParent = this;
            additem.Show();

        }

        private void aDDNEWToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Client();
            additem.MdiParent = this;
            additem.Show();

        }

        private void sELLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DS.DS_SALES.SALES_SELECTDataTable SDT = new MEDICAL.DS.DS_SALES.SALES_SELECTDataTable();
            DS.DS_SALESTableAdapters.SALES_SELECTTableAdapter SAdapter = new MEDICAL.DS.DS_SALESTableAdapters.SALES_SELECTTableAdapter();
            int del = SAdapter.Delete();
            closeExistingForm();
            Form additem = new SELL();
            additem.MdiParent = this;
            additem.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
