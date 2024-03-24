using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Lesson2.Classes;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UsersList users = new UsersList();

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string fio = textBoxFIO.Text;
            string dateOfBirth = dateTimePickerDateOfBirth.Text;
            string city = comboBoxCity.Text;
            string gender = "";
            if (radioButtonFemale.Checked)
            {
                gender = "Женский";
            }
            else if (radioButtonMale.Checked)
            {
                gender = "Мужской";
            }
            List<string> sections = new List<string>();
            foreach (object item in checkedListBoxSections.CheckedItems)
            {
                sections.Add(item.ToString());
            }
            if (fio == "" || dateOfBirth == "" || city == "" || gender == "" || sections.Count() == 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
            else
            {
                User user = new User(fio, dateOfBirth, city, gender, sections);
                users.addToList(user);
                richTextBoxResultWindow.Text = users.printInformationFromList();

                textBoxFIO.Text = "";
                dateTimePickerDateOfBirth.Text = "";
                comboBoxCity.Text = "";
                if (gender == "Женский")
                {
                    radioButtonFemale.Checked = false;
                }
                else if (gender == "Мужской")
                {
                    radioButtonMale.Checked = false;
                }
                for (int i = 0; i < checkedListBoxSections.Items.Count; i++)
                {
                    checkedListBoxSections.SetItemChecked(i, false);
                }
            }
        }

        private void buttonUnloadingToExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string filename = ofd.FileName;
            Microsoft.Office.Interop.Excel.Application excelObj = new Microsoft.Office.Interop.Excel.Application();
            excelObj.Visible = true;
            Workbook wb = excelObj.Workbooks.Open(filename, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet wsh = wb.Sheets[1];
            List<string> listInfo = new List<string> {"ФИО", "Дата рождения", "Город", "Пол", "Секции"};
            for (int i = 0; i < listInfo.Count; i++)
            {
                wsh.Cells[1, i + 1] = listInfo[i];
            }
            for (int i = 0; i < users.returnCount(); i++)
            {
                User user = users.returnUser(i);
                wsh.Cells[i + 2, 1] = user.returnFio();
                wsh.Cells[i + 2, 2] = user.returnDateOfBirth();
                wsh.Cells[i + 2, 3] = user.returnCity();
                wsh.Cells[i + 2, 4] = user.returnGender();
                wsh.Cells[i + 2, 5] = user.returnSections();
            }
            wb.Save();
        }
    }
}