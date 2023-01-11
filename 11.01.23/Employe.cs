using System;
using System.Collections.Generic;
using System.Text;

namespace _11._01._23
{
    internal class Employe
    {
        Dictionary<string, int> _names = new Dictionary<string, int>();
        public List<string> Employeesname
        {
            get
            {
                List<string> list = new List<string>();
                foreach (var item in _names)
                    list.Add(item.Key);

                return list;
            }
        }
        public string Name;
        public string Surname;
        protected int _salary;
        public int Salary
        {
            get => _salary;
            set
            {
                if (value > 250)
                {
                    _salary = value;
                }
                else
                {
                    throw new Exception("salary deyeri 250-den asagi ola bilmez");
                }
            }
        }
        static bool ForLetter(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
        static bool IsCapatalized(string str)
        {
            if (!char.IsUpper(str[0]))
                return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLower(str[i]))
                    return false;
            }
            return true;
        }
        string[] _employee;
        public void Add(string name)
        {

            Array.Resize(ref _employee, _employee.Length + 1);
            _employee[_employee.Length - 1] = name;



        }










    }   

}
