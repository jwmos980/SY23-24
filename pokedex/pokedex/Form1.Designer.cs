namespace pokedex
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
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.typetextBox = new System.Windows.Forms.TextBox();
            this.hpnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xpnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generationnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.legendarycheckBox = new System.Windows.Forms.CheckBox();
            this.shinycheckBox = new System.Windows.Forms.CheckBox();
            this.levelnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.attackcomboBox = new System.Windows.Forms.ComboBox();
            this.firstbutton = new System.Windows.Forms.Button();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.lastbutton = new System.Windows.Forms.Button();
            this.currentlabel = new System.Windows.Forms.Label();
            this.newbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hpnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(236, 33);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 0;
            // 
            // typetextBox
            // 
            this.typetextBox.Location = new System.Drawing.Point(236, 73);
            this.typetextBox.Name = "typetextBox";
            this.typetextBox.Size = new System.Drawing.Size(100, 22);
            this.typetextBox.TabIndex = 1;
            // 
            // hpnumericUpDown
            // 
            this.hpnumericUpDown.Location = new System.Drawing.Point(236, 187);
            this.hpnumericUpDown.Name = "hpnumericUpDown";
            this.hpnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.hpnumericUpDown.TabIndex = 3;
            // 
            // xpnumericUpDown
            // 
            this.xpnumericUpDown.Location = new System.Drawing.Point(236, 226);
            this.xpnumericUpDown.Name = "xpnumericUpDown";
            this.xpnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.xpnumericUpDown.TabIndex = 4;
            // 
            // generationnumericUpDown
            // 
            this.generationnumericUpDown.Location = new System.Drawing.Point(236, 339);
            this.generationnumericUpDown.Name = "generationnumericUpDown";
            this.generationnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.generationnumericUpDown.TabIndex = 5;
            // 
            // legendarycheckBox
            // 
            this.legendarycheckBox.AutoSize = true;
            this.legendarycheckBox.Location = new System.Drawing.Point(236, 266);
            this.legendarycheckBox.Name = "legendarycheckBox";
            this.legendarycheckBox.Size = new System.Drawing.Size(90, 20);
            this.legendarycheckBox.TabIndex = 6;
            this.legendarycheckBox.Text = "legendary";
            this.legendarycheckBox.UseVisualStyleBackColor = true;
            // 
            // shinycheckBox
            // 
            this.shinycheckBox.AutoSize = true;
            this.shinycheckBox.Location = new System.Drawing.Point(236, 304);
            this.shinycheckBox.Name = "shinycheckBox";
            this.shinycheckBox.Size = new System.Drawing.Size(60, 20);
            this.shinycheckBox.TabIndex = 7;
            this.shinycheckBox.Text = "shiny";
            this.shinycheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shinycheckBox.UseVisualStyleBackColor = true;
            // 
            // levelnumericUpDown
            // 
            this.levelnumericUpDown.Location = new System.Drawing.Point(236, 113);
            this.levelnumericUpDown.Name = "levelnumericUpDown";
            this.levelnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.levelnumericUpDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "attack:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "hp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "xp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "generation:";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(197, 393);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 18;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // attackcomboBox
            // 
            this.attackcomboBox.FormattingEnabled = true;
            this.attackcomboBox.Items.AddRange(new object[] {
            "special_attack",
            "special_defense"});
            this.attackcomboBox.Location = new System.Drawing.Point(236, 149);
            this.attackcomboBox.Name = "attackcomboBox";
            this.attackcomboBox.Size = new System.Drawing.Size(160, 24);
            this.attackcomboBox.TabIndex = 22;
            // 
            // firstbutton
            // 
            this.firstbutton.Location = new System.Drawing.Point(116, 495);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(75, 32);
            this.firstbutton.TabIndex = 23;
            this.firstbutton.Text = "<<";
            this.firstbutton.UseVisualStyleBackColor = true;
            this.firstbutton.Click += new System.EventHandler(this.firstbutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Location = new System.Drawing.Point(197, 495);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(75, 32);
            this.previousbutton.TabIndex = 24;
            this.previousbutton.Text = "<";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(278, 495);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 32);
            this.nextbutton.TabIndex = 25;
            this.nextbutton.Text = ">";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // lastbutton
            // 
            this.lastbutton.Location = new System.Drawing.Point(359, 495);
            this.lastbutton.Name = "lastbutton";
            this.lastbutton.Size = new System.Drawing.Size(75, 32);
            this.lastbutton.TabIndex = 26;
            this.lastbutton.Text = ">>";
            this.lastbutton.UseVisualStyleBackColor = true;
            this.lastbutton.Click += new System.EventHandler(this.lastbutton_Click);
            // 
            // currentlabel
            // 
            this.currentlabel.AutoSize = true;
            this.currentlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlabel.Location = new System.Drawing.Point(251, 435);
            this.currentlabel.Name = "currentlabel";
            this.currentlabel.Size = new System.Drawing.Size(2, 48);
            this.currentlabel.TabIndex = 27;
            // 
            // newbutton
            // 
            this.newbutton.Location = new System.Drawing.Point(294, 393);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(75, 23);
            this.newbutton.TabIndex = 28;
            this.newbutton.Text = "new";
            this.newbutton.UseVisualStyleBackColor = true;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 568);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.currentlabel);
            this.Controls.Add(this.lastbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.firstbutton);
            this.Controls.Add(this.attackcomboBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelnumericUpDown);
            this.Controls.Add(this.shinycheckBox);
            this.Controls.Add(this.legendarycheckBox);
            this.Controls.Add(this.generationnumericUpDown);
            this.Controls.Add(this.xpnumericUpDown);
            this.Controls.Add(this.hpnumericUpDown);
            this.Controls.Add(this.typetextBox);
            this.Controls.Add(this.nametextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hpnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox typetextBox;
        private System.Windows.Forms.NumericUpDown hpnumericUpDown;
        private System.Windows.Forms.NumericUpDown xpnumericUpDown;
        private System.Windows.Forms.NumericUpDown generationnumericUpDown;
        private System.Windows.Forms.CheckBox legendarycheckBox;
        private System.Windows.Forms.CheckBox shinycheckBox;
        private System.Windows.Forms.NumericUpDown levelnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ComboBox attackcomboBox;
        private System.Windows.Forms.Button firstbutton;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button lastbutton;
        private System.Windows.Forms.Label currentlabel;
        private System.Windows.Forms.Button newbutton;
    }
}

