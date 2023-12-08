using System;

namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.MemoryAdd = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.MemoryRead = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.MemorySubstract = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy,
            this.paste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(152, 22);
            this.copy.Text = "Copy";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(152, 22);
            this.paste.Text = "Paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerNameToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // developerNameToolStripMenuItem
            // 
            this.developerNameToolStripMenuItem.Name = "developerNameToolStripMenuItem";
            this.developerNameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.developerNameToolStripMenuItem.Text = "Developer Name";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(267, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(218, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(169, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(121, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "+/-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.White;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.zero.Location = new System.Drawing.Point(71, 276);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(45, 45);
            this.zero.TabIndex = 6;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // MemoryAdd
            // 
            this.MemoryAdd.BackColor = System.Drawing.Color.White;
            this.MemoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryAdd.ForeColor = System.Drawing.Color.Crimson;
            this.MemoryAdd.Location = new System.Drawing.Point(12, 276);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Size = new System.Drawing.Size(45, 45);
            this.MemoryAdd.TabIndex = 7;
            this.MemoryAdd.Text = "M+";
            this.MemoryAdd.UseVisualStyleBackColor = false;
            this.MemoryAdd.Click += new System.EventHandler(this.MemoryAdd_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button7.Location = new System.Drawing.Point(267, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "1/x";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Crimson;
            this.button8.Location = new System.Drawing.Point(218, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 9;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.White;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.Highlight;
            this.three.Location = new System.Drawing.Point(169, 225);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 45);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.White;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.Highlight;
            this.two.Location = new System.Drawing.Point(121, 225);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 45);
            this.two.TabIndex = 11;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.White;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.SystemColors.Highlight;
            this.one.Location = new System.Drawing.Point(71, 225);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 45);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.BackColor = System.Drawing.Color.White;
            this.MemorySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySave.ForeColor = System.Drawing.Color.Crimson;
            this.MemorySave.Location = new System.Drawing.Point(12, 225);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(45, 45);
            this.MemorySave.TabIndex = 13;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = false;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // Modulo
            // 
            this.Modulo.BackColor = System.Drawing.Color.White;
            this.Modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Modulo.Location = new System.Drawing.Point(267, 174);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(45, 45);
            this.Modulo.TabIndex = 14;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = false;
            this.Modulo.Click += new System.EventHandler(this.Modulo_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Crimson;
            this.button14.Location = new System.Drawing.Point(218, 174);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 15;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.White;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.Highlight;
            this.six.Location = new System.Drawing.Point(169, 174);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 45);
            this.six.TabIndex = 16;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.White;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.Highlight;
            this.five.Location = new System.Drawing.Point(120, 174);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 45);
            this.five.TabIndex = 17;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.White;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.Highlight;
            this.four.Location = new System.Drawing.Point(71, 174);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 45);
            this.four.TabIndex = 18;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // MemoryRead
            // 
            this.MemoryRead.BackColor = System.Drawing.Color.White;
            this.MemoryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryRead.ForeColor = System.Drawing.Color.Crimson;
            this.MemoryRead.Location = new System.Drawing.Point(12, 174);
            this.MemoryRead.Name = "MemoryRead";
            this.MemoryRead.Size = new System.Drawing.Size(45, 45);
            this.MemoryRead.TabIndex = 19;
            this.MemoryRead.Text = "MR";
            this.MemoryRead.UseVisualStyleBackColor = false;
            this.MemoryRead.Click += new System.EventHandler(this.MemoryRead_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.BackColor = System.Drawing.Color.White;
            this.MemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryClear.ForeColor = System.Drawing.Color.Crimson;
            this.MemoryClear.Location = new System.Drawing.Point(12, 123);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(45, 45);
            this.MemoryClear.TabIndex = 20;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = false;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.White;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.Highlight;
            this.seven.Location = new System.Drawing.Point(71, 123);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 45);
            this.seven.TabIndex = 21;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.White;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.eight.Location = new System.Drawing.Point(120, 123);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 45);
            this.eight.TabIndex = 22;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.White;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nine.Location = new System.Drawing.Point(169, 123);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(45, 45);
            this.nine.TabIndex = 23;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.Crimson;
            this.button23.Location = new System.Drawing.Point(218, 123);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(45, 45);
            this.button23.TabIndex = 24;
            this.button23.Text = "/";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button24.Location = new System.Drawing.Point(268, 123);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(45, 45);
            this.button24.TabIndex = 25;
            this.button24.Text = "sqrt";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // MemorySubstract
            // 
            this.MemorySubstract.BackColor = System.Drawing.Color.White;
            this.MemorySubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySubstract.ForeColor = System.Drawing.Color.Crimson;
            this.MemorySubstract.Location = new System.Drawing.Point(12, 67);
            this.MemorySubstract.Name = "MemorySubstract";
            this.MemorySubstract.Size = new System.Drawing.Size(45, 45);
            this.MemorySubstract.TabIndex = 26;
            this.MemorySubstract.Text = "M-";
            this.MemorySubstract.UseVisualStyleBackColor = false;
            this.MemorySubstract.Click += new System.EventHandler(this.MemorySubstract_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.White;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.ForeColor = System.Drawing.Color.Crimson;
            this.backspace.Location = new System.Drawing.Point(71, 67);
            this.backspace.Margin = new System.Windows.Forms.Padding(0);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(104, 45);
            this.backspace.TabIndex = 27;
            this.backspace.Text = "Backspace";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // ClearEntry
            // 
            this.ClearEntry.BackColor = System.Drawing.Color.White;
            this.ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntry.ForeColor = System.Drawing.Color.Crimson;
            this.ClearEntry.Location = new System.Drawing.Point(181, 67);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(60, 45);
            this.ClearEntry.TabIndex = 28;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = false;
            this.ClearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Crimson;
            this.Clear.Location = new System.Drawing.Point(247, 67);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(64, 45);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(320, 329);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.MemorySubstract);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.MemoryClear);
            this.Controls.Add(this.MemoryRead);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.MemorySave);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.MemoryAdd);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button MemoryAdd;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button MemorySave;
        private System.Windows.Forms.Button Modulo;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button MemoryRead;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button MemorySubstract;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ToolStripMenuItem developerNameToolStripMenuItem;
    }
}


