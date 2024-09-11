namespace CRUD_with_DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_show_alldata = new System.Windows.Forms.Button();
            this.textBox_search_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(96, 328);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(134, 28);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.Enter += new System.EventHandler(this.textBox_id_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(96, 392);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(134, 28);
            this.textBox_address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(345, 328);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(134, 28);
            this.textBox_name.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "PhoneNumber";
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(345, 392);
            this.textBox_phonenumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_phonenumber.Multiline = true;
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(134, 28);
            this.textBox_phonenumber.TabIndex = 9;
            this.textBox_phonenumber.Enter += new System.EventHandler(this.textBox_phonenumber_Enter);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(550, 325);
            this.button_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(83, 31);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(670, 322);
            this.button_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(83, 31);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(550, 386);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(83, 31);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_show_alldata
            // 
            this.button_show_alldata.Location = new System.Drawing.Point(670, 386);
            this.button_show_alldata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_show_alldata.Name = "button_show_alldata";
            this.button_show_alldata.Size = new System.Drawing.Size(83, 31);
            this.button_show_alldata.TabIndex = 16;
            this.button_show_alldata.Text = "ShowAllData";
            this.button_show_alldata.UseVisualStyleBackColor = true;
            this.button_show_alldata.Click += new System.EventHandler(this.button_show_alldata_Click);
            // 
            // textBox_search_id
            // 
            this.textBox_search_id.Location = new System.Drawing.Point(691, 37);
            this.textBox_search_id.Name = "textBox_search_id";
            this.textBox_search_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_search_id.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_search_id);
            this.Controls.Add(this.button_show_alldata);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_phonenumber);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_show_alldata;
        private System.Windows.Forms.TextBox textBox_search_id;
        private System.Windows.Forms.Button button1;
    }
}

