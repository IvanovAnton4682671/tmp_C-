namespace Lesson3
{
    partial class FormAllFutura
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
            this.menuAllFutura = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuAllFuturaAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAllFuturaProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAllFuturaNewFutura = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewFutura = new System.Windows.Forms.DataGridView();
            this.labelFutura = new System.Windows.Forms.Label();
            this.dataGridViewFuturaInfo = new System.Windows.Forms.DataGridView();
            this.labelFuturaInfo = new System.Windows.Forms.Label();
            this.menuAllFutura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuturaInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAllFutura
            // 
            this.menuAllFutura.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAllFutura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAllFuturaAdd});
            this.menuAllFutura.Location = new System.Drawing.Point(0, 0);
            this.menuAllFutura.Name = "menuAllFutura";
            this.menuAllFutura.Size = new System.Drawing.Size(1182, 31);
            this.menuAllFutura.TabIndex = 0;
            this.menuAllFutura.Text = "menuStrip1";
            // 
            // toolStripMenuAllFuturaAdd
            // 
            this.toolStripMenuAllFuturaAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAllFuturaProduct,
            this.toolStripMenuAllFuturaNewFutura});
            this.toolStripMenuAllFuturaAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuAllFuturaAdd.Name = "toolStripMenuAllFuturaAdd";
            this.toolStripMenuAllFuturaAdd.Size = new System.Drawing.Size(106, 27);
            this.toolStripMenuAllFuturaAdd.Text = "Добавить";
            // 
            // toolStripMenuAllFuturaProduct
            // 
            this.toolStripMenuAllFuturaProduct.Name = "toolStripMenuAllFuturaProduct";
            this.toolStripMenuAllFuturaProduct.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuAllFuturaProduct.Text = "Товар";
            // 
            // toolStripMenuAllFuturaNewFutura
            // 
            this.toolStripMenuAllFuturaNewFutura.Name = "toolStripMenuAllFuturaNewFutura";
            this.toolStripMenuAllFuturaNewFutura.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuAllFuturaNewFutura.Text = "Накладная";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(12, 34);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(214, 31);
            this.comboBoxUsers.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dataGridViewFutura
            // 
            this.dataGridViewFutura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFutura.Location = new System.Drawing.Point(12, 136);
            this.dataGridViewFutura.Name = "dataGridViewFutura";
            this.dataGridViewFutura.RowHeadersWidth = 51;
            this.dataGridViewFutura.RowTemplate.Height = 24;
            this.dataGridViewFutura.Size = new System.Drawing.Size(1158, 200);
            this.dataGridViewFutura.TabIndex = 3;
            // 
            // labelFutura
            // 
            this.labelFutura.AutoSize = true;
            this.labelFutura.Location = new System.Drawing.Point(12, 110);
            this.labelFutura.Name = "labelFutura";
            this.labelFutura.Size = new System.Drawing.Size(99, 23);
            this.labelFutura.TabIndex = 4;
            this.labelFutura.Text = "Накладная";
            // 
            // dataGridViewFuturaInfo
            // 
            this.dataGridViewFuturaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuturaInfo.Location = new System.Drawing.Point(12, 365);
            this.dataGridViewFuturaInfo.Name = "dataGridViewFuturaInfo";
            this.dataGridViewFuturaInfo.RowHeadersWidth = 51;
            this.dataGridViewFuturaInfo.RowTemplate.Height = 24;
            this.dataGridViewFuturaInfo.Size = new System.Drawing.Size(1158, 200);
            this.dataGridViewFuturaInfo.TabIndex = 5;
            // 
            // labelFuturaInfo
            // 
            this.labelFuturaInfo.AutoSize = true;
            this.labelFuturaInfo.Location = new System.Drawing.Point(12, 339);
            this.labelFuturaInfo.Name = "labelFuturaInfo";
            this.labelFuturaInfo.Size = new System.Drawing.Size(235, 23);
            this.labelFuturaInfo.TabIndex = 6;
            this.labelFuturaInfo.Text = "Информация о накладной";
            // 
            // FormAllFutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.labelFuturaInfo);
            this.Controls.Add(this.dataGridViewFuturaInfo);
            this.Controls.Add(this.labelFutura);
            this.Controls.Add(this.dataGridViewFutura);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.menuAllFutura);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAllFutura";
            this.Text = "FormAllFutura";
            this.menuAllFutura.ResumeLayout(false);
            this.menuAllFutura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuturaInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAllFutura;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAllFuturaAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAllFuturaProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAllFuturaNewFutura;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewFutura;
        private System.Windows.Forms.Label labelFutura;
        private System.Windows.Forms.DataGridView dataGridViewFuturaInfo;
        private System.Windows.Forms.Label labelFuturaInfo;
    }
}