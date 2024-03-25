namespace Lesson3
{
    partial class FormProduct
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonProductShowAdd = new System.Windows.Forms.Button();
            this.buttonProductDel = new System.Windows.Forms.Button();
            this.buttonProductChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(758, 150);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // buttonProductShowAdd
            // 
            this.buttonProductShowAdd.AutoSize = true;
            this.buttonProductShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProductShowAdd.Location = new System.Drawing.Point(12, 278);
            this.buttonProductShowAdd.Name = "buttonProductShowAdd";
            this.buttonProductShowAdd.Size = new System.Drawing.Size(106, 33);
            this.buttonProductShowAdd.TabIndex = 1;
            this.buttonProductShowAdd.Text = "Добавить";
            this.buttonProductShowAdd.UseVisualStyleBackColor = true;
            this.buttonProductShowAdd.Click += new System.EventHandler(this.buttonProductShowAdd_Click);
            // 
            // buttonProductDel
            // 
            this.buttonProductDel.AutoSize = true;
            this.buttonProductDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProductDel.Location = new System.Drawing.Point(234, 278);
            this.buttonProductDel.Name = "buttonProductDel";
            this.buttonProductDel.Size = new System.Drawing.Size(92, 33);
            this.buttonProductDel.TabIndex = 2;
            this.buttonProductDel.Text = "Удалить";
            this.buttonProductDel.UseVisualStyleBackColor = true;
            this.buttonProductDel.Click += new System.EventHandler(this.buttonProductDel_Click);
            // 
            // buttonProductChange
            // 
            this.buttonProductChange.AutoSize = true;
            this.buttonProductChange.Location = new System.Drawing.Point(124, 278);
            this.buttonProductChange.Name = "buttonProductChange";
            this.buttonProductChange.Size = new System.Drawing.Size(104, 33);
            this.buttonProductChange.TabIndex = 3;
            this.buttonProductChange.Text = "Изменить";
            this.buttonProductChange.UseVisualStyleBackColor = true;
            this.buttonProductChange.Click += new System.EventHandler(this.buttonProductChange_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.buttonProductChange);
            this.Controls.Add(this.buttonProductDel);
            this.Controls.Add(this.buttonProductShowAdd);
            this.Controls.Add(this.dataGridViewProduct);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonProductShowAdd;
        private System.Windows.Forms.Button buttonProductDel;
        private System.Windows.Forms.Button buttonProductChange;
    }
}