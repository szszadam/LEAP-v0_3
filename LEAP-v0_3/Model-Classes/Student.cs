using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    //      *****Student class*****
    //
    //      ***Description***
    //
    // Users with the student authorization level appear as objects of
    // this type when the program is running.Descendant of the User class. 
    //
    //      *****Fields*****
    //      (beyond the fields of the "User" class):
    //
    // _grade: int – it is used to store the student's grade.
    //
    // _class: string – it is used to store the student's class.

    class Student : User
    {
        int _grade;
        string _class;
        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public Student(int _sql_id, string _familyName, string _firstName, string _userIdentificationNumber, string _passwordHashCode, DateTime _registrationTime, string _authorizationLevel, int _grade, string _class)
        {
            this.SQL_ID = _sql_id;
            this.FamilyName = _familyName;
            this.FirstName = _firstName;
            this.UserIdentificationNumber = _userIdentificationNumber;
            this.PasswordHashCode = _passwordHashCode;
            this.RegistrationTime = _registrationTime;
            this.AuthorizationLevel = Convert.ToChar(_authorizationLevel);
            this.Grade = _grade;
            this.Class = _class;
        }
    }
}
