namespace HotelAPP
{
    partial class Food_New_Entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.rs = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.fa = new System.Windows.Forms.ComboBox();
            this.V = new System.Windows.Forms.RadioButton();
            this.ft = new System.Windows.Forms.GroupBox();
            this.N = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rs)).BeginInit();
            this.ft.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(247, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOOD NEW ENTRY";
            // 
            // fn
            // 
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.Location = new System.Drawing.Point(253, 113);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(230, 26);
            this.fn.TabIndex = 1;
            // 
            // rs
            // 
            this.rs.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.rs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rs.GridColor = System.Drawing.SystemColors.Control;
            this.rs.Location = new System.Drawing.Point(519, 108);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(424, 257);
            this.rs.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(77, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fa
            // 
            this.fa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fa.FormattingEnabled = true;
            this.fa.Items.AddRange(new object[] {
            "M",
            "A",
            "E",
            "N"});
            this.fa.Location = new System.Drawing.Point(253, 337);
            this.fa.Name = "fa";
            this.fa.Size = new System.Drawing.Size(230, 28);
            this.fa.TabIndex = 5;
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.V.ForeColor = System.Drawing.Color.Black;
            this.V.Location = new System.Drawing.Point(0, 1);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(68, 28);
            this.V.TabIndex = 6;
            this.V.TabStop = true;
            this.V.Text = "Veg ";
            this.V.UseVisualStyleBackColor = true;
            this.V.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ft
            // 
            this.ft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ft.Controls.Add(this.N);
            this.ft.Controls.Add(this.V);
            this.ft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ft.ForeColor = System.Drawing.Color.Teal;
            this.ft.Location = new System.Drawing.Point(253, 187);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(172, 29);
            this.ft.TabIndex = 7;
            this.ft.TabStop = false;
            this.ft.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.N.ForeColor = System.Drawing.Color.Black;
            this.N.Location = new System.Drawing.Point(63, 2);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(109, 28);
            this.N.TabIndex = 7;
            this.N.TabStop = true;
            this.N.Text = "Non Veg ";
            this.N.UseVisualStyleBackColor = true;
            this.N.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Food Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Food Availability";
            // 
            // fp
            // 
            this.fp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp.Location = new System.Drawing.Point(253, 258);
            this.fp.Name = "fp";
            this.fp.Size = new System.Drawing.Size(230, 26);
            this.fp.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Food Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Food Type";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(276, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(476, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(672, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 46);
            this.button4.TabIndex = 17;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(858, 441);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 46);
            this.button5.TabIndex = 18;
            this.button5.Text = "View";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(25, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 44);
            this.button6.TabIndex = 19;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Food_New_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1014, 566);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ft);
            this.Name = "Food_New_Entry";
            this.Text = "Food_New_Entry";
            this.Load += new System.EventHandler(this.Food_New_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rs)).EndInit();
            this.ft.ResumeLayout(false);
            this.ft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.DataGridView rs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.GroupBox ft;
        public System.Windows.Forms.RadioButton V;
        public System.Windows.Forms.RadioButton N;
        private System.Windows.Forms.Button button6;
    }
}