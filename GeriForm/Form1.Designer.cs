namespace GeriForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.db,
            this.iz});
            this.DGV.Location = new System.Drawing.Point(12, 12);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(590, 167);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // db
            // 
            this.db.HeaderText = "DB";
            this.db.Name = "db";
            // 
            // iz
            // 
            this.iz.HeaderText = "ÍZ";
            this.iz.Name = "iz";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(428, 262);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(174, 50);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 324);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn db;
        private System.Windows.Forms.DataGridViewTextBoxColumn iz;
        private System.Windows.Forms.Button bt_exit;
    }
}

