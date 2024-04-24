namespace Lesson3
{
    partial class FormClient
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonClientShowAdd = new System.Windows.Forms.Button();
            this.buttonClientChange = new System.Windows.Forms.Button();
            this.buttonClientDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(758, 150);
            this.dataGridViewClient.TabIndex = 0;
            // 
            // buttonClientShowAdd
            // 
            this.buttonClientShowAdd.AutoSize = true;
            this.buttonClientShowAdd.Location = new System.Drawing.Point(12, 278);
            this.buttonClientShowAdd.Name = "buttonClientShowAdd";
            this.buttonClientShowAdd.Size = new System.Drawing.Size(102, 33);
            this.buttonClientShowAdd.TabIndex = 1;
            this.buttonClientShowAdd.Text = "Добавить";
            this.buttonClientShowAdd.UseVisualStyleBackColor = true;
            this.buttonClientShowAdd.Click += new System.EventHandler(this.buttonClientShowAdd_Click);
            // 
            // buttonClientChange
            // 
            this.buttonClientChange.AutoSize = true;
            this.buttonClientChange.Location = new System.Drawing.Point(120, 278);
            this.buttonClientChange.Name = "buttonClientChange";
            this.buttonClientChange.Size = new System.Drawing.Size(104, 33);
            this.buttonClientChange.TabIndex = 2;
            this.buttonClientChange.Text = "Изменить";
            this.buttonClientChange.UseVisualStyleBackColor = true;
            this.buttonClientChange.Click += new System.EventHandler(this.buttonClientChange_Click);
            // 
            // buttonClientDel
            // 
            this.buttonClientDel.AutoSize = true;
            this.buttonClientDel.Location = new System.Drawing.Point(230, 278);
            this.buttonClientDel.Name = "buttonClientDel";
            this.buttonClientDel.Size = new System.Drawing.Size(88, 33);
            this.buttonClientDel.TabIndex = 3;
            this.buttonClientDel.Text = "Удалить";
            this.buttonClientDel.UseVisualStyleBackColor = true;
            this.buttonClientDel.Click += new System.EventHandler(this.buttonClientDel_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.buttonClientDel);
            this.Controls.Add(this.buttonClientChange);
            this.Controls.Add(this.buttonClientShowAdd);
            this.Controls.Add(this.dataGridViewClient);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonClientShowAdd;
        private System.Windows.Forms.Button buttonClientChange;
        private System.Windows.Forms.Button buttonClientDel;
    }
}