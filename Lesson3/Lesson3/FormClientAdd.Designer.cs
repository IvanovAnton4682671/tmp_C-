namespace Lesson3
{
    partial class FormClientAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.buttonClientAddYes = new System.Windows.Forms.Button();
            this.buttonClientAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(12, 35);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(222, 29);
            this.textBoxClientName.TabIndex = 3;
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(12, 93);
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(222, 29);
            this.textBoxClientAddress.TabIndex = 4;
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Location = new System.Drawing.Point(12, 151);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(222, 29);
            this.textBoxClientPhone.TabIndex = 5;
            // 
            // buttonClientAddYes
            // 
            this.buttonClientAddYes.AutoSize = true;
            this.buttonClientAddYes.Location = new System.Drawing.Point(12, 186);
            this.buttonClientAddYes.Name = "buttonClientAddYes";
            this.buttonClientAddYes.Size = new System.Drawing.Size(131, 33);
            this.buttonClientAddYes.TabIndex = 6;
            this.buttonClientAddYes.Text = "Подтвердить";
            this.buttonClientAddYes.UseVisualStyleBackColor = true;
            this.buttonClientAddYes.Click += new System.EventHandler(this.buttonClientAddYes_Click);
            // 
            // buttonClientAddCancel
            // 
            this.buttonClientAddCancel.AutoSize = true;
            this.buttonClientAddCancel.Location = new System.Drawing.Point(149, 186);
            this.buttonClientAddCancel.Name = "buttonClientAddCancel";
            this.buttonClientAddCancel.Size = new System.Drawing.Size(85, 33);
            this.buttonClientAddCancel.TabIndex = 7;
            this.buttonClientAddCancel.Text = "Отмена";
            this.buttonClientAddCancel.UseVisualStyleBackColor = true;
            this.buttonClientAddCancel.Click += new System.EventHandler(this.buttonClientAddCancel_Click);
            // 
            // FormClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.buttonClientAddCancel);
            this.Controls.Add(this.buttonClientAddYes);
            this.Controls.Add(this.textBoxClientPhone);
            this.Controls.Add(this.textBoxClientAddress);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientAdd";
            this.Text = "FormClientAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientAddress;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.Button buttonClientAddYes;
        private System.Windows.Forms.Button buttonClientAddCancel;
    }
}