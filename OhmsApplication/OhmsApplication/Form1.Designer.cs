namespace OhmsApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentRadio = new System.Windows.Forms.RadioButton();
            this.VoltageRadio = new System.Windows.Forms.RadioButton();
            this.ResistanceRadio = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.computeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Input1 = new System.Windows.Forms.RichTextBox();
            this.Input2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Output1 = new System.Windows.Forms.RichTextBox();
            this.Output2 = new System.Windows.Forms.RichTextBox();
            this.OutputResult = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.ResistanceRadio);
            this.groupBox1.Controls.Add(this.VoltageRadio);
            this.groupBox1.Controls.Add(this.CurrentRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a computation=>";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CurrentRadio
            // 
            this.CurrentRadio.AutoSize = true;
            this.CurrentRadio.Location = new System.Drawing.Point(3, 31);
            this.CurrentRadio.Name = "CurrentRadio";
            this.CurrentRadio.Size = new System.Drawing.Size(59, 17);
            this.CurrentRadio.TabIndex = 0;
            this.CurrentRadio.TabStop = true;
            this.CurrentRadio.Text = "Current";
            this.CurrentRadio.UseVisualStyleBackColor = true;
            this.CurrentRadio.CheckedChanged += new System.EventHandler(this.CurrentRadio_CheckedChanged);
            // 
            // VoltageRadio
            // 
            this.VoltageRadio.AutoSize = true;
            this.VoltageRadio.Location = new System.Drawing.Point(3, 54);
            this.VoltageRadio.Name = "VoltageRadio";
            this.VoltageRadio.Size = new System.Drawing.Size(61, 17);
            this.VoltageRadio.TabIndex = 1;
            this.VoltageRadio.TabStop = true;
            this.VoltageRadio.Text = "Voltage";
            this.VoltageRadio.UseVisualStyleBackColor = true;
            this.VoltageRadio.CheckedChanged += new System.EventHandler(this.VoltageRadio_CheckedChanged);
            // 
            // ResistanceRadio
            // 
            this.ResistanceRadio.AutoSize = true;
            this.ResistanceRadio.Location = new System.Drawing.Point(3, 77);
            this.ResistanceRadio.Name = "ResistanceRadio";
            this.ResistanceRadio.Size = new System.Drawing.Size(78, 17);
            this.ResistanceRadio.TabIndex = 2;
            this.ResistanceRadio.TabStop = true;
            this.ResistanceRadio.Text = "Resistance";
            this.ResistanceRadio.UseVisualStyleBackColor = true;
            this.ResistanceRadio.CheckedChanged += new System.EventHandler(this.ResistanceRadio_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // computeToolStripMenuItem
            // 
            this.computeToolStripMenuItem.Name = "computeToolStripMenuItem";
            this.computeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.computeToolStripMenuItem.Text = "Compute";
            this.computeToolStripMenuItem.Click += new System.EventHandler(this.computeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(240, 87);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(94, 18);
            this.Input1.TabIndex = 2;
            this.Input1.Text = "";
            this.Input1.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(240, 111);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(94, 21);
            this.Input2.TabIndex = 3;
            this.Input2.Text = "";
            this.Input2.TextChanged += new System.EventHandler(this.Input2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Location = new System.Drawing.Point(240, 145);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(94, 21);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "Result = ";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // Output1
            // 
            this.Output1.Location = new System.Drawing.Point(355, 87);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(88, 17);
            this.Output1.TabIndex = 5;
            this.Output1.Text = "";
            this.Output1.TextChanged += new System.EventHandler(this.Output1_TextChanged);
            // 
            // Output2
            // 
            this.Output2.Location = new System.Drawing.Point(355, 113);
            this.Output2.Name = "Output2";
            this.Output2.Size = new System.Drawing.Size(88, 19);
            this.Output2.TabIndex = 6;
            this.Output2.Text = "";
            this.Output2.TextChanged += new System.EventHandler(this.Output2_TextChanged);
            // 
            // OutputResult
            // 
            this.OutputResult.Location = new System.Drawing.Point(355, 145);
            this.OutputResult.Name = "OutputResult";
            this.OutputResult.Size = new System.Drawing.Size(88, 17);
            this.OutputResult.TabIndex = 7;
            this.OutputResult.Text = "";
            this.OutputResult.TextChanged += new System.EventHandler(this.OutputResult_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(449, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(449, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(61, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 213);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OutputResult);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OhmsCalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ResistanceRadio;
        private System.Windows.Forms.RadioButton VoltageRadio;
        private System.Windows.Forms.RadioButton CurrentRadio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem computeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Input1;
        private System.Windows.Forms.RichTextBox Input2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox Output1;
        private System.Windows.Forms.RichTextBox Output2;
        private System.Windows.Forms.RichTextBox OutputResult;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

