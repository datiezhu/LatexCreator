namespace FolderBrowser
{
    partial class MainForm
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
            this.Create_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Oppgaver_Lbl = new System.Windows.Forms.Label();
            this.NumberPicker = new System.Windows.Forms.NumericUpDown();
            this.Status_Lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.preambleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(535, 66);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Button.TabIndex = 0;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(89, 9);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(440, 22);
            this.PathBox.TabIndex = 2;
            this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Oppgaver_Lbl
            // 
            this.Oppgaver_Lbl.AutoSize = true;
            this.Oppgaver_Lbl.Location = new System.Drawing.Point(12, 66);
            this.Oppgaver_Lbl.Name = "Oppgaver_Lbl";
            this.Oppgaver_Lbl.Size = new System.Drawing.Size(71, 17);
            this.Oppgaver_Lbl.TabIndex = 4;
            this.Oppgaver_Lbl.Text = "Oppgaver";
            // 
            // NumberPicker
            // 
            this.NumberPicker.Location = new System.Drawing.Point(89, 66);
            this.NumberPicker.Name = "NumberPicker";
            this.NumberPicker.Size = new System.Drawing.Size(120, 22);
            this.NumberPicker.TabIndex = 5;
            this.NumberPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberPicker.ValueChanged += new System.EventHandler(this.NumberPicker_ValueChanged);
            // 
            // Status_Lbl
            // 
            this.Status_Lbl.AutoSize = true;
            this.Status_Lbl.Location = new System.Drawing.Point(215, 71);
            this.Status_Lbl.Name = "Status_Lbl";
            this.Status_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Status_Lbl.Size = new System.Drawing.Size(0, 17);
            this.Status_Lbl.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Preamble_Click);
            // 
            // preambleBox
            // 
            this.preambleBox.Location = new System.Drawing.Point(89, 38);
            this.preambleBox.Name = "preambleBox";
            this.preambleBox.Size = new System.Drawing.Size(440, 22);
            this.preambleBox.TabIndex = 8;
            this.preambleBox.TextChanged += new System.EventHandler(this.PreambleBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preamble";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 98);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.preambleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Status_Lbl);
            this.Controls.Add(this.NumberPicker);
            this.Controls.Add(this.Oppgaver_Lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_Button);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "LatexCreator";
            ((System.ComponentModel.ISupportInitialize)(this.NumberPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Oppgaver_Lbl;
        private System.Windows.Forms.NumericUpDown NumberPicker;
        private System.Windows.Forms.Label Status_Lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox preambleBox;
        private System.Windows.Forms.Label label2;
    }
}

