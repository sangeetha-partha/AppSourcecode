namespace MEDICAL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menulogout = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cHNAEGPASSWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblday = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.gplogin = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gplogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.mENUToolStripMenuItem,
            this.sELLToolStripMenuItem,
            this.cLIENTSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.mANAGEUSERToolStripMenuItem,
            this.cOMPANYToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menulogout,
            this.eXITToolStripMenuItem});
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // menulogout
            // 
            this.menulogout.Name = "menulogout";
            this.menulogout.Size = new System.Drawing.Size(126, 22);
            this.menulogout.Text = "LOGOUT";
            this.menulogout.Visible = false;
            this.menulogout.Click += new System.EventHandler(this.menulogout_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.updateStockToolStripMenuItem,
            this.deleteStockToolStripMenuItem,
            this.repotsToolStripMenuItem});
            this.mENUToolStripMenuItem.Enabled = false;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mENUToolStripMenuItem.Text = "STOCK";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nEWToolStripMenuItem.Text = "New Stock";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            // 
            // deleteStockToolStripMenuItem
            // 
            this.deleteStockToolStripMenuItem.Name = "deleteStockToolStripMenuItem";
            this.deleteStockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteStockToolStripMenuItem.Text = "Delete Stock";
            // 
            // repotsToolStripMenuItem
            // 
            this.repotsToolStripMenuItem.Name = "repotsToolStripMenuItem";
            this.repotsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.repotsToolStripMenuItem.Text = "Repots";
            // 
            // sELLToolStripMenuItem
            // 
            this.sELLToolStripMenuItem.Enabled = false;
            this.sELLToolStripMenuItem.Name = "sELLToolStripMenuItem";
            this.sELLToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.sELLToolStripMenuItem.Text = "SELL";
            this.sELLToolStripMenuItem.Click += new System.EventHandler(this.sELLToolStripMenuItem_Click);
            // 
            // cLIENTSToolStripMenuItem
            // 
            this.cLIENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem2,
            this.dELETEToolStripMenuItem2,
            this.vIEWToolStripMenuItem});
            this.cLIENTSToolStripMenuItem.Enabled = false;
            this.cLIENTSToolStripMenuItem.Name = "cLIENTSToolStripMenuItem";
            this.cLIENTSToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cLIENTSToolStripMenuItem.Text = "CLIENTS";
            // 
            // aDDNEWToolStripMenuItem2
            // 
            this.aDDNEWToolStripMenuItem2.Name = "aDDNEWToolStripMenuItem2";
            this.aDDNEWToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.aDDNEWToolStripMenuItem2.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem2.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem2_Click);
            // 
            // dELETEToolStripMenuItem2
            // 
            this.dELETEToolStripMenuItem2.Name = "dELETEToolStripMenuItem2";
            this.dELETEToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.dELETEToolStripMenuItem2.Text = "DELETE ";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.Enabled = false;
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // mANAGEUSERToolStripMenuItem
            // 
            this.mANAGEUSERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.rEPORTSToolStripMenuItem1,
            this.cHNAEGPASSWORDToolStripMenuItem});
            this.mANAGEUSERToolStripMenuItem.Enabled = false;
            this.mANAGEUSERToolStripMenuItem.Name = "mANAGEUSERToolStripMenuItem";
            this.mANAGEUSERToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.mANAGEUSERToolStripMenuItem.Text = "MANAGE USER";
            // 
            // aDDNEWToolStripMenuItem
            // 
            this.aDDNEWToolStripMenuItem.Name = "aDDNEWToolStripMenuItem";
            this.aDDNEWToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aDDNEWToolStripMenuItem.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            // 
            // rEPORTSToolStripMenuItem1
            // 
            this.rEPORTSToolStripMenuItem1.Name = "rEPORTSToolStripMenuItem1";
            this.rEPORTSToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.rEPORTSToolStripMenuItem1.Text = "REPORTS";
            // 
            // cHNAEGPASSWORDToolStripMenuItem
            // 
            this.cHNAEGPASSWORDToolStripMenuItem.Name = "cHNAEGPASSWORDToolStripMenuItem";
            this.cHNAEGPASSWORDToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cHNAEGPASSWORDToolStripMenuItem.Text = "CHNAEG PASSWORD";
            // 
            // cOMPANYToolStripMenuItem
            // 
            this.cOMPANYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem1,
            this.dELETEToolStripMenuItem1,
            this.rEPORTSToolStripMenuItem2});
            this.cOMPANYToolStripMenuItem.Enabled = false;
            this.cOMPANYToolStripMenuItem.Name = "cOMPANYToolStripMenuItem";
            this.cOMPANYToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.cOMPANYToolStripMenuItem.Text = "COMPANY";
            // 
            // aDDNEWToolStripMenuItem1
            // 
            this.aDDNEWToolStripMenuItem1.Name = "aDDNEWToolStripMenuItem1";
            this.aDDNEWToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.aDDNEWToolStripMenuItem1.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem1.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem1_Click);
            // 
            // dELETEToolStripMenuItem1
            // 
            this.dELETEToolStripMenuItem1.Name = "dELETEToolStripMenuItem1";
            this.dELETEToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.dELETEToolStripMenuItem1.Text = "DELETE";
            // 
            // rEPORTSToolStripMenuItem2
            // 
            this.rEPORTSToolStripMenuItem2.Name = "rEPORTSToolStripMenuItem2";
            this.rEPORTSToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.rEPORTSToolStripMenuItem2.Text = "REPORTS";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(1074, 61);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(46, 17);
            this.lblday.TabIndex = 15;
            this.lblday.Text = "label4";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(1073, 81);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(46, 17);
            this.lbltime.TabIndex = 14;
            this.lbltime.Text = "label3";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbltitle.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Honeydew;
            this.lbltitle.Location = new System.Drawing.Point(263, 33);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(759, 71);
            this.lbltitle.TabIndex = 13;
            this.lbltitle.Text = "MEDICAL STORE SYSTEM";
            // 
            // gplogin
            // 
            this.gplogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gplogin.Controls.Add(this.btnlogin);
            this.gplogin.Controls.Add(this.txtpass);
            this.gplogin.Controls.Add(this.txtname);
            this.gplogin.Controls.Add(this.label2);
            this.gplogin.Controls.Add(this.label1);
            this.gplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gplogin.Location = new System.Drawing.Point(477, 249);
            this.gplogin.Name = "gplogin";
            this.gplogin.Size = new System.Drawing.Size(331, 201);
            this.gplogin.TabIndex = 16;
            this.gplogin.TabStop = false;
            this.gplogin.Text = "Login";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Honeydew;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Location = new System.Drawing.Point(145, 130);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 30);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Honeydew;
            this.txtpass.Location = new System.Drawing.Point(145, 87);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 23);
            this.txtpass.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Honeydew;
            this.txtname.Location = new System.Drawing.Point(145, 41);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 23);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(59, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoginName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1228, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 67);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1012, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(1078, 119);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(26, 20);
            this.lblname.TabIndex = 23;
            this.lblname.Text = "lkl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 698);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gplogin);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gplogin.ResumeLayout(false);
            this.gplogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menulogout;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox gplogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cHNAEGPASSWORDToolStripMenuItem;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ToolStripMenuItem cOMPANYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
    }
}

