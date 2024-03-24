namespace Lesson3
{
    partial class FormProductAdd
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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductMeasurementUnits = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductMeasurementUnits = new System.Windows.Forms.Label();
            this.buttonProductAddYes = new System.Windows.Forms.Button();
            this.buttonProductAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(13, 36);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(229, 29);
            this.textBoxProductName.TabIndex = 0;
            // 
            // textBoxProductMeasurementUnits
            // 
            this.textBoxProductMeasurementUnits.Location = new System.Drawing.Point(13, 96);
            this.textBoxProductMeasurementUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProductMeasurementUnits.Name = "textBoxProductMeasurementUnits";
            this.textBoxProductMeasurementUnits.Size = new System.Drawing.Size(229, 29);
            this.textBoxProductMeasurementUnits.TabIndex = 1;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(13, 9);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(139, 23);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Наименование";
            // 
            // labelProductMeasurementUnits
            // 
            this.labelProductMeasurementUnits.AutoSize = true;
            this.labelProductMeasurementUnits.Location = new System.Drawing.Point(13, 69);
            this.labelProductMeasurementUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductMeasurementUnits.Name = "labelProductMeasurementUnits";
            this.labelProductMeasurementUnits.Size = new System.Drawing.Size(185, 23);
            this.labelProductMeasurementUnits.TabIndex = 3;
            this.labelProductMeasurementUnits.Text = "Единицы измерения";
            // 
            // buttonProductAddYes
            // 
            this.buttonProductAddYes.AutoSize = true;
            this.buttonProductAddYes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProductAddYes.Location = new System.Drawing.Point(12, 132);
            this.buttonProductAddYes.Name = "buttonProductAddYes";
            this.buttonProductAddYes.Size = new System.Drawing.Size(135, 33);
            this.buttonProductAddYes.TabIndex = 4;
            this.buttonProductAddYes.Text = "Подтвердить";
            this.buttonProductAddYes.UseVisualStyleBackColor = true;
            this.buttonProductAddYes.Click += new System.EventHandler(this.buttonProductAddYes_Click);
            // 
            // buttonProductAddCancel
            // 
            this.buttonProductAddCancel.AutoSize = true;
            this.buttonProductAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProductAddCancel.Location = new System.Drawing.Point(153, 132);
            this.buttonProductAddCancel.Name = "buttonProductAddCancel";
            this.buttonProductAddCancel.Size = new System.Drawing.Size(89, 33);
            this.buttonProductAddCancel.TabIndex = 5;
            this.buttonProductAddCancel.Text = "Отмена";
            this.buttonProductAddCancel.UseVisualStyleBackColor = true;
            this.buttonProductAddCancel.Click += new System.EventHandler(this.buttonProductAddCancel_Click);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.buttonProductAddCancel);
            this.Controls.Add(this.buttonProductAddYes);
            this.Controls.Add(this.labelProductMeasurementUnits);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxProductMeasurementUnits);
            this.Controls.Add(this.textBoxProductName);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProductAdd";
            this.Text = "FormProductAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductMeasurementUnits;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductMeasurementUnits;
        private System.Windows.Forms.Button buttonProductAddYes;
        private System.Windows.Forms.Button buttonProductAddCancel;
    }
}