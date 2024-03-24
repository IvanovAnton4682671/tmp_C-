namespace Lesson2
{
    partial class Form1
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelCity = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelSections = new System.Windows.Forms.Label();
            this.richTextBoxResultWindow = new System.Windows.Forms.RichTextBox();
            this.checkedListBoxSections = new System.Windows.Forms.CheckedListBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelResultWindow = new System.Windows.Forms.Label();
            this.buttonUnloadingToExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIO.Location = new System.Drawing.Point(12, 9);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(130, 24);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "Введите ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFIO.Location = new System.Drawing.Point(16, 36);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(359, 30);
            this.textBoxFIO.TabIndex = 1;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(12, 69);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(221, 24);
            this.labelDateOfBirth.TabIndex = 2;
            this.labelDateOfBirth.Text = "Введите дату рождения";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(16, 96);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(359, 30);
            this.dateTimePickerDateOfBirth.TabIndex = 3;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(12, 129);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(155, 24);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "Выберите город";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Краснодар",
            "Москва",
            "Санкт-Петербург"});
            this.comboBoxCity.Location = new System.Drawing.Point(16, 156);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(359, 32);
            this.comboBoxCity.TabIndex = 5;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(12, 191);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(134, 24);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Выберите пол";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(16, 218);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(110, 28);
            this.radioButtonFemale.TabIndex = 7;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(154, 218);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(115, 28);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelSections
            // 
            this.labelSections.AutoSize = true;
            this.labelSections.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSections.Location = new System.Drawing.Point(12, 249);
            this.labelSections.Name = "labelSections";
            this.labelSections.Size = new System.Drawing.Size(193, 24);
            this.labelSections.TabIndex = 9;
            this.labelSections.Text = "Выберите секцию(и)";
            // 
            // richTextBoxResultWindow
            // 
            this.richTextBoxResultWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResultWindow.Location = new System.Drawing.Point(432, 36);
            this.richTextBoxResultWindow.Name = "richTextBoxResultWindow";
            this.richTextBoxResultWindow.ReadOnly = true;
            this.richTextBoxResultWindow.Size = new System.Drawing.Size(496, 424);
            this.richTextBoxResultWindow.TabIndex = 10;
            this.richTextBoxResultWindow.Text = "";
            // 
            // checkedListBoxSections
            // 
            this.checkedListBoxSections.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxSections.FormattingEnabled = true;
            this.checkedListBoxSections.Items.AddRange(new object[] {
            "Программирование на Python",
            "Программирование на C#",
            "Программирование на Java"});
            this.checkedListBoxSections.Location = new System.Drawing.Point(16, 276);
            this.checkedListBoxSections.Name = "checkedListBoxSections";
            this.checkedListBoxSections.Size = new System.Drawing.Size(359, 104);
            this.checkedListBoxSections.TabIndex = 11;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(12, 386);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(363, 34);
            this.buttonConfirm.TabIndex = 12;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelResultWindow
            // 
            this.labelResultWindow.AutoSize = true;
            this.labelResultWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultWindow.Location = new System.Drawing.Point(428, 9);
            this.labelResultWindow.Name = "labelResultWindow";
            this.labelResultWindow.Size = new System.Drawing.Size(170, 24);
            this.labelResultWindow.TabIndex = 13;
            this.labelResultWindow.Text = "Окно результатов";
            // 
            // buttonUnloadingToExcel
            // 
            this.buttonUnloadingToExcel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.buttonUnloadingToExcel.Location = new System.Drawing.Point(16, 426);
            this.buttonUnloadingToExcel.Name = "buttonUnloadingToExcel";
            this.buttonUnloadingToExcel.Size = new System.Drawing.Size(363, 34);
            this.buttonUnloadingToExcel.TabIndex = 14;
            this.buttonUnloadingToExcel.Text = "Выгрузить данные в Excel";
            this.buttonUnloadingToExcel.UseVisualStyleBackColor = true;
            this.buttonUnloadingToExcel.Click += new System.EventHandler(this.buttonUnloadingToExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 473);
            this.Controls.Add(this.buttonUnloadingToExcel);
            this.Controls.Add(this.labelResultWindow);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkedListBoxSections);
            this.Controls.Add(this.richTextBoxResultWindow);
            this.Controls.Add(this.labelSections);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelSections;
        private System.Windows.Forms.RichTextBox richTextBoxResultWindow;
        private System.Windows.Forms.CheckedListBox checkedListBoxSections;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelResultWindow;
        private System.Windows.Forms.Button buttonUnloadingToExcel;
    }
}

