namespace Raznice
{
    partial class frmRaznice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaznice));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMark = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReconnect = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkReady = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSarze = new System.Windows.Forms.MaskedTextBox();
            this.lblSarze = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDozimetr = new System.Windows.Forms.TextBox();
            this.txtOddeleni = new System.Windows.Forms.TextBox();
            this.txtPodnik = new System.Windows.Forms.TextBox();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.txtMesic = new System.Windows.Forms.TextBox();
            this.txtObdobi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStarN = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtTyp = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblMark,
            this.btnReconnect,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(703, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblMark
            // 
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(0, 17);
            // 
            // btnReconnect
            // 
            this.btnReconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnReconnect.Image")));
            this.btnReconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.ShowDropDownArrow = false;
            this.btnReconnect.Size = new System.Drawing.Size(20, 20);
            this.btnReconnect.Text = "Reconnect";
            this.btnReconnect.Visible = false;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_ButtonClick);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // chkReady
            // 
            this.chkReady.AutoSize = true;
            this.chkReady.Enabled = false;
            this.chkReady.Location = new System.Drawing.Point(6, 19);
            this.chkReady.Name = "chkReady";
            this.chkReady.Size = new System.Drawing.Size(115, 17);
            this.chkReady.TabIndex = 17;
            this.chkReady.Text = "připraveno k ražbě";
            this.chkReady.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkReady);
            this.groupBox1.Location = new System.Drawing.Point(546, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 48);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stav raznice";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTyp);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtSarze);
            this.groupBox4.Controls.Add(this.lblSarze);
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Location = new System.Drawing.Point(0, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(699, 477);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ražba";
            // 
            // txtSarze
            // 
            this.txtSarze.Location = new System.Drawing.Point(66, 16);
            this.txtSarze.Mask = "?";
            this.txtSarze.Name = "txtSarze";
            this.txtSarze.Size = new System.Drawing.Size(21, 20);
            this.txtSarze.TabIndex = 55;
            this.txtSarze.Text = "A";
            this.txtSarze.LostFocus += new System.EventHandler(this.txtSarze_LostFocus);
            // 
            // lblSarze
            // 
            this.lblSarze.AutoSize = true;
            this.lblSarze.Location = new System.Drawing.Point(8, 20);
            this.lblSarze.Name = "lblSarze";
            this.lblSarze.Size = new System.Drawing.Size(61, 13);
            this.lblSarze.TabIndex = 54;
            this.lblSarze.Text = "Šarže filmu:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 419);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.btnStarN);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.txtCount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Test ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Počet dozimetrů:";
            this.label5.Visible = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.txtDozimetr);
            this.groupBox10.Controls.Add(this.txtOddeleni);
            this.groupBox10.Controls.Add(this.txtPodnik);
            this.groupBox10.Controls.Add(this.txtRok);
            this.groupBox10.Controls.Add(this.txtMesic);
            this.groupBox10.Controls.Add(this.txtObdobi);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.txtJmeno);
            this.groupBox10.Location = new System.Drawing.Point(6, 122);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(667, 100);
            this.groupBox10.TabIndex = 61;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Na štítku dozimetru";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(387, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 73;
            this.label28.Text = "Jméno";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(268, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(111, 13);
            this.label27.TabIndex = 72;
            this.label27.Text = "Podnik/Odd/Dozimetr";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(194, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 71;
            this.label26.Text = "Měsíc/Rok";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(154, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "Období";
            // 
            // txtDozimetr
            // 
            this.txtDozimetr.Location = new System.Drawing.Point(336, 45);
            this.txtDozimetr.Name = "txtDozimetr";
            this.txtDozimetr.Size = new System.Drawing.Size(37, 20);
            this.txtDozimetr.TabIndex = 70;
            this.txtDozimetr.Text = "320";
            // 
            // txtOddeleni
            // 
            this.txtOddeleni.Location = new System.Drawing.Point(313, 45);
            this.txtOddeleni.Name = "txtOddeleni";
            this.txtOddeleni.Size = new System.Drawing.Size(18, 20);
            this.txtOddeleni.TabIndex = 69;
            this.txtOddeleni.Text = "9";
            // 
            // txtPodnik
            // 
            this.txtPodnik.Location = new System.Drawing.Point(271, 45);
            this.txtPodnik.Name = "txtPodnik";
            this.txtPodnik.Size = new System.Drawing.Size(37, 20);
            this.txtPodnik.TabIndex = 68;
            this.txtPodnik.Text = "320";
            // 
            // txtRok
            // 
            this.txtRok.Location = new System.Drawing.Point(230, 45);
            this.txtRok.Name = "txtRok";
            this.txtRok.Size = new System.Drawing.Size(27, 20);
            this.txtRok.TabIndex = 67;
            this.txtRok.Text = "16";
            // 
            // txtMesic
            // 
            this.txtMesic.Location = new System.Drawing.Point(197, 45);
            this.txtMesic.Name = "txtMesic";
            this.txtMesic.Size = new System.Drawing.Size(27, 20);
            this.txtMesic.TabIndex = 66;
            this.txtMesic.Text = "05";
            // 
            // txtObdobi
            // 
            this.txtObdobi.Location = new System.Drawing.Point(157, 45);
            this.txtObdobi.Name = "txtObdobi";
            this.txtObdobi.Size = new System.Drawing.Size(18, 20);
            this.txtObdobi.TabIndex = 65;
            this.txtObdobi.Text = "3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Text na štítek dozimetru:";
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(388, 44);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(100, 20);
            this.txtJmeno.TabIndex = 63;
            this.txtJmeno.Text = "Vejsada";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(65, 247);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 24);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Vyrazit dozimetr";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // btnStarN
            // 
            this.btnStarN.Location = new System.Drawing.Point(65, 344);
            this.btnStarN.Name = "btnStarN";
            this.btnStarN.Size = new System.Drawing.Size(112, 24);
            this.btnStarN.TabIndex = 37;
            this.btnStarN.Text = "Vyrazit N dozimetrů";
            this.btnStarN.UseVisualStyleBackColor = true;
            this.btnStarN.Visible = false;
            this.btnStarN.Click += new System.EventHandler(this.btnStarN_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtText);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(667, 99);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ražení dozimetru";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(156, 42);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 35;
            this.txtText.Text = "05019002";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Číslo dozimetru:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(283, 348);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(42, 20);
            this.txtCount.TabIndex = 38;
            this.txtCount.Text = "1";
            this.txtCount.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vyraženo:";
            this.label2.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(391, 350);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 40;
            this.lblCount.Text = "0";
            this.lblCount.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(5, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 42);
            this.label6.TabIndex = 30;
            this.label6.Text = "Raznice na dozimetry";
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(182, 16);
            this.txtTyp.Mask = "0";
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(21, 20);
            this.txtTyp.TabIndex = 57;
            this.txtTyp.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Typ filmu:";
            // 
            // frmRaznice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 546);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRaznice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEST Ovládání raznice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox chkReady;
        private System.Windows.Forms.ToolStripStatusLabel lblMark;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripDropDownButton btnReconnect;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnStarN;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSarze;
        private System.Windows.Forms.MaskedTextBox txtSarze;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDozimetr;
        private System.Windows.Forms.TextBox txtOddeleni;
        private System.Windows.Forms.TextBox txtPodnik;
        private System.Windows.Forms.TextBox txtRok;
        private System.Windows.Forms.TextBox txtMesic;
        private System.Windows.Forms.TextBox txtObdobi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.MaskedTextBox txtTyp;
        private System.Windows.Forms.Label label3;
    }
}

