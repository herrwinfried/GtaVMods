namespace GtaVMods
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.okButton = new DarkUI.Controls.DarkButton();
            this.modsfolder = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.gtafolder = new DarkUI.Controls.DarkTextBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.modsfolderbutton = new DarkUI.Controls.DarkButton();
            this.gtafolderbutton = new DarkUI.Controls.DarkButton();
            this.gtavalue = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.valuemod = new DarkUI.Controls.DarkRadioButton();
            this.valuegta = new DarkUI.Controls.DarkRadioButton();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.darkRadioButton1 = new DarkUI.Controls.DarkRadioButton();
            this.darkGroupBox1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // modsfolder
            // 
            this.modsfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.modsfolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modsfolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.modsfolder, "modsfolder");
            this.modsfolder.Name = "modsfolder";
            // 
            // darkLabel1
            // 
            resources.ApplyResources(this.darkLabel1, "darkLabel1");
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Name = "darkLabel1";
            // 
            // gtafolder
            // 
            this.gtafolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.gtafolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gtafolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.gtafolder, "gtafolder");
            this.gtafolder.Name = "gtafolder";
            // 
            // darkLabel2
            // 
            resources.ApplyResources(this.darkLabel2, "darkLabel2");
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Name = "darkLabel2";
            // 
            // modsfolderbutton
            // 
            resources.ApplyResources(this.modsfolderbutton, "modsfolderbutton");
            this.modsfolderbutton.Name = "modsfolderbutton";
            // 
            // gtafolderbutton
            // 
            resources.ApplyResources(this.gtafolderbutton, "gtafolderbutton");
            this.gtafolderbutton.Name = "gtafolderbutton";
            this.gtafolderbutton.Click += new System.EventHandler(this.gtafolderbutton_Click);
            // 
            // gtavalue
            // 
            resources.ApplyResources(this.gtavalue, "gtavalue");
            this.gtavalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gtavalue.Name = "gtavalue";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox1.Controls.Add(this.valuemod);
            this.darkGroupBox1.Controls.Add(this.valuegta);
            resources.ApplyResources(this.darkGroupBox1, "darkGroupBox1");
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.TabStop = false;
            // 
            // valuemod
            // 
            resources.ApplyResources(this.valuemod, "valuemod");
            this.valuemod.Name = "valuemod";
            this.valuemod.TabStop = true;
            this.valuemod.CheckedChanged += new System.EventHandler(this.valuemod_CheckedChanged);
            // 
            // valuegta
            // 
            resources.ApplyResources(this.valuegta, "valuegta");
            this.valuegta.Name = "valuegta";
            this.valuegta.TabStop = true;
            this.valuegta.CheckedChanged += new System.EventHandler(this.valuegta_CheckedChanged);
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox2.Controls.Add(this.darkRadioButton1);
            resources.ApplyResources(this.darkGroupBox2, "darkGroupBox2");
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.TabStop = false;
            // 
            // darkRadioButton1
            // 
            resources.ApplyResources(this.darkRadioButton1, "darkRadioButton1");
            this.darkRadioButton1.Checked = true;
            this.darkRadioButton1.Name = "darkRadioButton1";
            this.darkRadioButton1.TabStop = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.darkGroupBox1);
            this.Controls.Add(this.gtavalue);
            this.Controls.Add(this.gtafolderbutton);
            this.Controls.Add(this.modsfolderbutton);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.gtafolder);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.modsfolder);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton okButton;
        private DarkUI.Controls.DarkTextBox modsfolder;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox gtafolder;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton modsfolderbutton;
        private DarkUI.Controls.DarkButton gtafolderbutton;
        private DarkUI.Controls.DarkLabel gtavalue;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkRadioButton valuemod;
        private DarkUI.Controls.DarkRadioButton valuegta;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private DarkUI.Controls.DarkRadioButton darkRadioButton1;
    }
}