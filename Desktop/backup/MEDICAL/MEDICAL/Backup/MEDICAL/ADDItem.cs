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
    public partial class ADDItem : Form
    {
        DS.DS_ITEM.StockInMst_SelectDataTable IDT = new MEDICAL.DS.DS_ITEM.StockInMst_SelectDataTable();
        DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter IAdapter = new MEDICAL.DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter();

        DS.DS_COMPANY.CompanyMst_SelectDataTable CDT = new MEDICAL.DS.DS_COMPANY.CompanyMst_SelectDataTable();
        DS.DS_COMPANYTableAdapters.CompanyMst_SelectTableAdapter CAdapter = new MEDICAL.DS.DS_COMPANYTableAdapters.CompanyMst_SelectTableAdapter();

        DS.DS_STOCK.StockMst_SelectDataTable SDT = new MEDICAL.DS.DS_STOCK.StockMst_SelectDataTable();
        DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter SAdapter = new MEDICAL.DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter();

        DS.DS_USER.UserMst_SelectDataTable UDT = new DS.DS_USER.UserMst_SelectDataTable();
        DS.DS_USERTableAdapters.UserMst_SelectTableAdapter UAdapter = new MEDICAL.DS.DS_USERTableAdapters.UserMst_SelectTableAdapter();
        public string username;
        public ADDItem(string uname)
        {
            username = uname;
            InitializeComponent();
        }

        private void ADDItem_Load(object sender, EventArgs e)
        {
            CDT = CAdapter.SelectComapny();
            cmbdompany.DataSource = CDT;
            cmbdompany.DisplayMember = "Cname";
            cmbdompany.ValueMember = "Cid";

            IDT = IAdapter.SelectItem();
            comboBox1.DataSource = IDT;
            comboBox1.DisplayMember = "I_name";
            comboBox1.ValueMember = "I_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inst = IAdapter.Insert(txtiname.Text, txtidetail.Text, Convert.ToInt32(txtiqnt.Text), Convert.ToDouble(txtiprice.Text), cmbdompany.Text, Convert.ToDateTime(dateexpire.Text), txtlocation.Text);
           
            double price=Convert.ToDouble(txtiqnt.Text) * Convert.ToDouble(txtiprice.Text);
            int addstock = SAdapter.Insert(txtiname.Text, Convert.ToDouble(txtiprice.Text), Convert.ToInt32(txtiqnt.Text), 0, Convert.ToInt32(txtiqnt.Text), price, 0, price, System.DateTime.Now.Date);

            MessageBox.Show("Item Added Successfully !!", "MEdical System");

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                CDT = CAdapter.SelectComapny();
                cmbdompany.DataSource = CDT;
                cmbdompany.DisplayMember = "Cname";
                cmbdompany.ValueMember = "Cid";
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                IDT = IAdapter.SelectItem();
                comboBox1.DataSource = IDT;
                comboBox1.DisplayMember = "I_name";
                comboBox1.ValueMember = "I_ID";
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                IDT = IAdapter.SelectItem();
                comboBox2.DataSource = IDT;
                comboBox2.DisplayMember = "I_name";
                comboBox2.ValueMember = "I_ID";
            
            }
            else if (tabControl1.SelectedIndex == 3)
            {

                IDT = IAdapter.SelectItem();
                dataGridView1.DataSource = IDT;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedText != "")
            //{
            //IDT = IAdapter.SelectBYID(Convert.ToInt32(comboBox1.SelectedValue));
           // txtcurentqnt.Text = IDT.Rows[0]["I_Quantity"].ToString();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure !! You want to Update Stock !!", "Medical system", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                IDT = IAdapter.SelectBYID(Convert.ToInt32(comboBox1.SelectedValue));
                //IAdapter.StockInMst_Updateitem(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(txtnewqnt.Text));
                int inst = IAdapter.Insert(comboBox1.Text, IDT.Rows[0]["I_Descrip"].ToString(), Convert.ToInt32(txtnewqnt.Text), Convert.ToDouble(IDT.Rows[0]["I_Price"].ToString()), IDT.Rows[0]["c_name"].ToString(), Convert.ToDateTime(IDT.Rows[0]["I_Ex_date"].ToString()), IDT.Rows[0]["I_location"].ToString());

                

                double tprice = Convert.ToDouble(txtnewqnt.Text) * Convert.ToDouble(IDT.Rows[0]["I_Price"].ToString());
                SAdapter.StockMst_ADD_Update_Quantity(Convert.ToInt32(txtnewqnt.Text), tprice, comboBox1.Text);

                MessageBox.Show("Quantity Updated Successfully !!", "MEdical System");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int del= IAdapter.Delete(Convert.ToInt32(comboBox2.SelectedValue));
           MessageBox.Show("Item Deleted Successfully !!", "Medical System");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IDT = IAdapter.SelectBYID(Convert.ToInt32(comboBox1.SelectedValue));
            txtcurentqnt.Text = IDT.Rows[0]["I_Quantity"].ToString();
        }
    }
}
