namespace Lab3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grid1 = new Lab3.Grid();
            this.red_button1 = new Lab3.red_button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grid1
            // 
            this.grid1.CellSize = 50;
            this.grid1.ColumnCount = 8;
            this.grid1.DisplayMode = Lab3.Grid.GridDisplayMode.Numbers;
            this.grid1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grid1.Location = new System.Drawing.Point(24, 23);
            this.grid1.Name = "grid1";
            this.grid1.RowCount = 5;
            this.grid1.Size = new System.Drawing.Size(251, 202);
            this.grid1.TabIndex = 2;
            this.grid1.Text = "grid1";
            this.grid1.CellClick += new Lab3.Grid.CellHandler(this.grid1_CellClick);
            this.grid1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grid1_MouseMove);
            // 
            // red_button1
            // 
            this.red_button1.BackColor = System.Drawing.Color.Red;
            this.red_button1.Crossed = false;
            this.red_button1.Location = new System.Drawing.Point(281, 69);
            this.red_button1.Name = "red_button1";
            this.red_button1.Size = new System.Drawing.Size(121, 156);
            this.red_button1.TabIndex = 1;
            this.red_button1.Text = "random";
            this.red_button1.UseVisualStyleBackColor = false;
            this.red_button1.Click += new System.EventHandler(this.red_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 231);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.red_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private red_button red_button1;
        private Grid grid1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

