using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    [Flags]
    public enum SecurityLevel
    {
        guest = 1, Developer = 2, secretary = 4, DBA = 8, SecurityOfficer = 15
    }
    public enum Gender { male, female }
    public struct Employee
    {
        int id;
        decimal salary;
        SecurityLevel securitylevel;
        Gender gender;
        HireDate hiredate;
        public int Id { get { return id; } set { id = value; } }
        public decimal Salary { get { return salary; } set { salary = value; } }
        public SecurityLevel Securitylevelprop
        {
            get { return securitylevel; }
            set
            {

                if (value.ToString().ToLower() == "guest")
                {
                    securitylevel = SecurityLevel.guest;
                }
                else if (value.ToString().ToLower() == "developer")
                {
                    securitylevel = SecurityLevel.Developer;
                }
                else if (value.ToString().ToLower() == "dba")
                {
                    securitylevel = SecurityLevel.DBA;
                }
                else if (value.ToString().ToLower() == "secretary")
                {
                    securitylevel = SecurityLevel.secretary;
                }
                else if (value.ToString().ToLower() == "securityofficer")
                {
                    securitylevel = SecurityLevel.guest | SecurityLevel.Developer | SecurityLevel.DBA | SecurityLevel.secretary;
                }
                else
                {
                    securitylevel = SecurityLevel.guest;
                }
            }
        }
        public Gender GenderProp
        {
            get { return gender; }
            set
            {
                if (value.ToString().ToLower() == "male")
                {
                    gender = Gender.male;
                }
                else if (value.ToString().ToLower() == "female")
                {
                    gender = Gender.female;
                }
                else
                {
                    gender = Gender.male;
                }
            }
        }
        public HireDate Hiredate { get { return hiredate; } set { hiredate = value; }}

        public Employee()
        {
            id = 0;
            salary = 2000;
            securitylevel = 0;
            gender = 0;
            hiredate = new HireDate();
        }
        public Employee(int _id, decimal _salary, SecurityLevel _securityLevel, Gender _gender, HireDate _hiredate)
        {
            id = _id;
            salary = _salary;
            securitylevel = _securityLevel;
            gender = _gender;
            hiredate = _hiredate;

        }

        public override string ToString()
        {
            return $"Employee Id: {id}\nSecurityLevel: {securitylevel}\nSalary: {salary}\nHiringDate: {hiredate}\nGender: {gender}";
        }


        #region struct HireDate
        public struct HireDate
        {
            int year;
            int month;
            int day;
            public int Year { get { return year; } set { year = value; } }
            public int Month { get { return month; } set { month = value; } }
            public int Day { get { return day; } set { day = value; } }
            public HireDate()
            {
                year = 1998; month = 11; day = 4;
            }
            public HireDate(int _day, int _month, int _year)
            {
                if (_day < 0 || _day > 31) { day = 0; }
                else { day = _day; }
                if (_month < 0 || _month > 13) { month = 0; }
                else { month = _month; }
                if (_year < 0 || _year > DateTime.Now.Year) { year = 0; }
                else { year = _year; }
            }
            public override string ToString()
            {
                return $"{day}/{month}/{year}";
            }
        }
        #endregion
    }
}
