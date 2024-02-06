namespace moviedex
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
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titletextBox = new System.Windows.Forms.TextBox();
            this.directortextBox = new System.Windows.Forms.TextBox();
            this.actortextBox = new System.Windows.Forms.TextBox();
            this.genrecomboBox = new System.Windows.Forms.ComboBox();
            this.ratingcomboBox = new System.Windows.Forms.ComboBox();
            this.scoreUpDown = new System.Windows.Forms.NumericUpDown();
            this.posterpictureBox = new System.Windows.Forms.PictureBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.newbutton = new System.Windows.Forms.Button();
            this.currentlabel = new System.Windows.Forms.Label();
            this.lastbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.previousbutton = new System.Windows.Forms.Button();
            this.firstbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.revenuetextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "revenue:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "director:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "lead actor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "critic score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "rating:";
            // 
            // titletextBox
            // 
            this.titletextBox.Location = new System.Drawing.Point(92, 77);
            this.titletextBox.Name = "titletextBox";
            this.titletextBox.Size = new System.Drawing.Size(248, 22);
            this.titletextBox.TabIndex = 53;
            // 
            // directortextBox
            // 
            this.directortextBox.Location = new System.Drawing.Point(92, 111);
            this.directortextBox.Name = "directortextBox";
            this.directortextBox.Size = new System.Drawing.Size(182, 22);
            this.directortextBox.TabIndex = 54;
            // 
            // actortextBox
            // 
            this.actortextBox.Location = new System.Drawing.Point(92, 145);
            this.actortextBox.Name = "actortextBox";
            this.actortextBox.Size = new System.Drawing.Size(231, 22);
            this.actortextBox.TabIndex = 55;
            // 
            // genrecomboBox
            // 
            this.genrecomboBox.FormattingEnabled = true;
            this.genrecomboBox.Items.AddRange(new object[] {
            "Horror ",
            "Action ",
            "Comedy ",
            "Thriller",
            "Drama ",
            "Romance"});
            this.genrecomboBox.Location = new System.Drawing.Point(91, 179);
            this.genrecomboBox.Name = "genrecomboBox";
            this.genrecomboBox.Size = new System.Drawing.Size(102, 24);
            this.genrecomboBox.TabIndex = 56;
            // 
            // ratingcomboBox
            // 
            this.ratingcomboBox.FormattingEnabled = true;
            this.ratingcomboBox.Items.AddRange(new object[] {
            "G",
            "PG",
            "pg13",
            "tv14",
            "R"});
            this.ratingcomboBox.Location = new System.Drawing.Point(91, 215);
            this.ratingcomboBox.Name = "ratingcomboBox";
            this.ratingcomboBox.Size = new System.Drawing.Size(102, 24);
            this.ratingcomboBox.TabIndex = 57;
            // 
            // scoreUpDown
            // 
            this.scoreUpDown.Location = new System.Drawing.Point(92, 251);
            this.scoreUpDown.Name = "scoreUpDown";
            this.scoreUpDown.Size = new System.Drawing.Size(66, 22);
            this.scoreUpDown.TabIndex = 58;
            // 
            // posterpictureBox
            // 
            this.posterpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posterpictureBox.Location = new System.Drawing.Point(382, 30);
            this.posterpictureBox.Name = "posterpictureBox";
            this.posterpictureBox.Size = new System.Drawing.Size(290, 397);
            this.posterpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterpictureBox.TabIndex = 60;
            this.posterpictureBox.TabStop = false;
            this.posterpictureBox.Click += new System.EventHandler(this.posterpictureBox_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(265, 312);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 61;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // newbutton
            // 
            this.newbutton.Location = new System.Drawing.Point(50, 312);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(75, 23);
            this.newbutton.TabIndex = 62;
            this.newbutton.Text = "new";
            this.newbutton.UseVisualStyleBackColor = true;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // currentlabel
            // 
            this.currentlabel.AutoSize = true;
            this.currentlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlabel.Location = new System.Drawing.Point(169, 312);
            this.currentlabel.Name = "currentlabel";
            this.currentlabel.Size = new System.Drawing.Size(60, 24);
            this.currentlabel.TabIndex = 63;
            this.currentlabel.Text = "label7";
            this.currentlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastbutton
            // 
            this.lastbutton.Location = new System.Drawing.Point(280, 346);
            this.lastbutton.Name = "lastbutton";
            this.lastbutton.Size = new System.Drawing.Size(75, 32);
            this.lastbutton.TabIndex = 67;
            this.lastbutton.Text = ">>";
            this.lastbutton.UseVisualStyleBackColor = true;
            this.lastbutton.Click += new System.EventHandler(this.lastbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(199, 346);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 32);
            this.nextbutton.TabIndex = 66;
            this.nextbutton.Text = ">";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Location = new System.Drawing.Point(118, 346);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(75, 32);
            this.previousbutton.TabIndex = 65;
            this.previousbutton.Text = "<";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // firstbutton
            // 
            this.firstbutton.Location = new System.Drawing.Point(37, 346);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(75, 32);
            this.firstbutton.TabIndex = 64;
            this.firstbutton.Text = "<<";
            this.firstbutton.UseVisualStyleBackColor = true;
            this.firstbutton.Click += new System.EventHandler(this.firstbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // revenuetextBox
            // 
            this.revenuetextBox.Location = new System.Drawing.Point(92, 284);
            this.revenuetextBox.Name = "revenuetextBox";
            this.revenuetextBox.Size = new System.Drawing.Size(119, 22);
            this.revenuetextBox.TabIndex = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 477);
            this.Controls.Add(this.revenuetextBox);
            this.Controls.Add(this.lastbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.firstbutton);
            this.Controls.Add(this.currentlabel);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.posterpictureBox);
            this.Controls.Add(this.scoreUpDown);
            this.Controls.Add(this.ratingcomboBox);
            this.Controls.Add(this.genrecomboBox);
            this.Controls.Add(this.actortextBox);
            this.Controls.Add(this.directortextBox);
            this.Controls.Add(this.titletextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titletextBox;
        private System.Windows.Forms.TextBox directortextBox;
        private System.Windows.Forms.TextBox actortextBox;
        private System.Windows.Forms.ComboBox genrecomboBox;
        private System.Windows.Forms.ComboBox ratingcomboBox;
        private System.Windows.Forms.NumericUpDown scoreUpDown;
        private System.Windows.Forms.PictureBox posterpictureBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button newbutton;
        private System.Windows.Forms.Label currentlabel;
        private System.Windows.Forms.Button lastbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button firstbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox revenuetextBox;
    }
}

