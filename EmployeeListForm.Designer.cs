namespace WindowsFormsApp5
{
    partial class EmployeeListForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bDelEmp = new System.Windows.Forms.Button();
            this.bSaveChang = new System.Windows.Forms.Button();
            this.bBackMA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 107);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(475, 330);
            this.dataGridView.TabIndex = 0;
            // 
            // bDelEmp
            // 
            this.bDelEmp.BackColor = System.Drawing.Color.Beige;
            this.bDelEmp.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelEmp.Location = new System.Drawing.Point(555, 128);
            this.bDelEmp.Name = "bDelEmp";
            this.bDelEmp.Size = new System.Drawing.Size(198, 65);
            this.bDelEmp.TabIndex = 1;
            this.bDelEmp.Text = "Delete employee";
            this.bDelEmp.UseVisualStyleBackColor = false;
            this.bDelEmp.Click += new System.EventHandler(this.bDelEmp_Click);
            // 
            // bSaveChang
            // 
            this.bSaveChang.BackColor = System.Drawing.Color.Beige;
            this.bSaveChang.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSaveChang.Location = new System.Drawing.Point(555, 241);
            this.bSaveChang.Name = "bSaveChang";
            this.bSaveChang.Size = new System.Drawing.Size(198, 65);
            this.bSaveChang.TabIndex = 2;
            this.bSaveChang.Text = "Save Changes";
            this.bSaveChang.UseVisualStyleBackColor = false;
            this.bSaveChang.Click += new System.EventHandler(this.bSaveChang_Click);
            // 
            // bBackMA
            // 
            this.bBackMA.BackColor = System.Drawing.Color.Beige;
            this.bBackMA.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBackMA.Location = new System.Drawing.Point(555, 349);
            this.bBackMA.Name = "bBackMA";
            this.bBackMA.Size = new System.Drawing.Size(198, 65);
            this.bBackMA.TabIndex = 3;
            this.bBackMA.Text = "Back";
            this.bBackMA.UseVisualStyleBackColor = false;
            this.bBackMA.Click += new System.EventHandler(this.bBackMA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(263, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Principal Staff";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBackMA);
            this.Controls.Add(this.bSaveChang);
            this.Controls.Add(this.bDelEmp);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bDelEmp;
        private System.Windows.Forms.Button bSaveChang;
        private System.Windows.Forms.Button bBackMA;
        private System.Windows.Forms.Label label1;
    }
}