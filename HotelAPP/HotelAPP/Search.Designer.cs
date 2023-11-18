namespace HotelAPP
{
    partial class Search
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radioFoodItems = new System.Windows.Forms.RadioButton();
            this.radioBillingEntries = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search Keyword";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(865, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(64, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(886, 395);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rs_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(438, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "SEARCH";
            // 
            // radioFoodItems
            // 
            this.radioFoodItems.AutoSize = true;
            this.radioFoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioFoodItems.ForeColor = System.Drawing.Color.Black;
            this.radioFoodItems.Location = new System.Drawing.Point(653, 36);
            this.radioFoodItems.Name = "radioFoodItems";
            this.radioFoodItems.Size = new System.Drawing.Size(163, 24);
            this.radioFoodItems.TabIndex = 7;
            this.radioFoodItems.TabStop = true;
            this.radioFoodItems.Text = "Search Food Items";
            this.radioFoodItems.UseVisualStyleBackColor = true;
            this.radioFoodItems.CheckedChanged += new System.EventHandler(this.radioFoodItems_CheckedChanged);
            // 
            // radioBillingEntries
            // 
            this.radioBillingEntries.AutoSize = true;
            this.radioBillingEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBillingEntries.ForeColor = System.Drawing.Color.Black;
            this.radioBillingEntries.Location = new System.Drawing.Point(653, 70);
            this.radioBillingEntries.Name = "radioBillingEntries";
            this.radioBillingEntries.Size = new System.Drawing.Size(177, 24);
            this.radioBillingEntries.TabIndex = 6;
            this.radioBillingEntries.TabStop = true;
            this.radioBillingEntries.Text = "Search Billing Entries";
            this.radioBillingEntries.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 44);
            this.button6.TabIndex = 20;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyword.Location = new System.Drawing.Point(223, 66);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(179, 26);
            this.txtSearchKeyword.TabIndex = 21;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1010, 529);
            this.Controls.Add(this.txtSearchKeyword);
            this.Controls.Add(this.radioFoodItems);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.radioBillingEntries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioFoodItems;
        public System.Windows.Forms.RadioButton radioBillingEntries;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSearchKeyword;
    }
}