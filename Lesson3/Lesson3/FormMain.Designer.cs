namespace Lesson3
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonAllFutura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProduct
            // 
            this.buttonProduct.AutoSize = true;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduct.Location = new System.Drawing.Point(13, 13);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(108, 32);
            this.buttonProduct.TabIndex = 0;
            this.buttonProduct.Text = "Продукты";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.AutoSize = true;
            this.buttonClient.Location = new System.Drawing.Point(128, 12);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(94, 33);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиенты";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonAllFutura
            // 
            this.buttonAllFutura.AutoSize = true;
            this.buttonAllFutura.Location = new System.Drawing.Point(228, 12);
            this.buttonAllFutura.Name = "buttonAllFutura";
            this.buttonAllFutura.Size = new System.Drawing.Size(114, 33);
            this.buttonAllFutura.TabIndex = 2;
            this.buttonAllFutura.Text = "Накладные";
            this.buttonAllFutura.UseVisualStyleBackColor = true;
            this.buttonAllFutura.Click += new System.EventHandler(this.buttonAllFutura_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.buttonAllFutura);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonProduct);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAllFutura;
    }
}

