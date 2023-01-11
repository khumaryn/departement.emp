using System;
using System.Collections.Generic;
using System.Text;

namespace _11._01._23
{
    internal class Department<TKey, TValue>
    {
        public string Name;
        protected int _employeelimit;
        protected int _salarylimit;
      

        public int Employeelimit
        {
            get => _employeelimit;
            set
            {
                if (value >= 100)
                {
                    _employeelimit = value;
                }
                else
                {
                    throw new Exception(" deyer 100-dan kicik ola bilmez!");
                }
            }
        }
        public int Salarylimit
        {
            get => _salarylimit;
            set
            {
                if (value >= 250)
                {
                    _salarylimit = value;
                }
                else
                {
                    throw new Exception(" 250  kicik ola bilmez!");
                }
            }
        }


        string[] _employees;
        public void Add(string name, string  value)
        {

            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = value;


            
        }

    }
}
