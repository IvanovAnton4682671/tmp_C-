using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Classes
{
    class User
    {
        string fio, dateOfBirth, city, gender;
        List<string> sections;

        public User(string fio, string dateOfBirth, string city, string gender, List<string> sections)
        {
            this.fio = fio;
            this.dateOfBirth = dateOfBirth;
            this.city = city;
            this.gender = gender;
            this.sections = sections;
        }

        public string printUserInformation()
        {
            string tmp = "";
            foreach (string section in sections)
            {
                tmp += section + ", ";
            }
            if (tmp != "")
            {
                tmp = tmp.Substring(0, tmp.Length - 2);
            }
            string sOut = "Информация о пользователе:\nФИО: " + fio + "\nДата рождения: " + dateOfBirth + "\nГород: " + city + "\nПол: " + gender + "\nСекция(и): " + tmp + "\n\n";
            return sOut;
        }

        public string returnFio()
        {
            return this.fio;
        }

        public string returnDateOfBirth()
        {
            return this.dateOfBirth;
        }

        public string returnCity()
        {
            return this.city;
        }

        public string returnGender()
        {
            return this.gender;
        }

        public string returnSections()
        {
            string tmp = "";
            foreach (string section in sections)
            {
                tmp += section + ", ";
            }
            if (tmp != "")
            {
                tmp = tmp.Substring(0, tmp.Length - 2);
            }
            return tmp;
        }
    }
}
