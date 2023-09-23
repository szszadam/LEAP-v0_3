using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    //      *****Teacher class*****
    //
    //
    // Users with the teacher authorization level appear as objects of this type when
    // the program is running.Teacher class is descendant of the “User” class.
    //
    //
    //      ***Fields***
    //      (beyond the fields of the "User" class)
    //
    //
    // _subjectsTaughtList: List<string> - it is used to store the subjects taught by the teacher.

    class Teacher : User
    {
        List<string> _subjectsTaughtList = new List<string>();
        public List<string> SubjectsTaughtList
        {
            get { return _subjectsTaughtList; }
            set { _subjectsTaughtList = value; }
        }
        public Teacher( int _sql_id, string _familyName, string _firstName, string _userIdentificationNumber, string _passwordHashCode, DateTime _registrationTime, string _authorizationLevel, string _subjectsTaught)
        {
            this.SQL_ID = _sql_id;
            this.FamilyName = _familyName;
            this.FirstName = _firstName;
            this.UserIdentificationNumber = _userIdentificationNumber;
            this.PasswordHashCode = _passwordHashCode;
            this.RegistrationTime = _registrationTime;
            this.AuthorizationLevel = Convert.ToChar(_authorizationLevel);
            if ((_subjectsTaught != null) && (_subjectsTaught.ToLower() != "null"))
            {
                string[] subjectsTaughtArrayAuxiliary = _subjectsTaught.Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < subjectsTaughtArrayAuxiliary.Length; i++)
                {
                    this.SubjectsTaughtList.Add(subjectsTaughtArrayAuxiliary[i]);
                }
            }
        }
    }
}
