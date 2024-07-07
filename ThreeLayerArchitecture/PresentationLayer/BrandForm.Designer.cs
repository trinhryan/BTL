namespace ThreeLayerArchitecture.PresentationLayer
{
    partial class BrandForm
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(26, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 188);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(581, 222);
            this.dataGridView.TabIndex = 2;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(146, 32);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "LoadData";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(146, 73);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(75, 23);
            this.btnAddData.TabIndex = 4;
            this.btnAddData.Text = "AddData";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAddData;

        private System.Windows.Forms.Button btnLoadData;

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;

        #endregion
    }
}