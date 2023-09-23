using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    class Administrator : Teacher
    {
        //      *****Administrator class*****
        //
        //
        //      ***Class description***
        //
        //
        // Administrator level users appear as objects of this type when
        // the program is running.It is a descendant of the Teacher class and,
        // with it, of the User class.
        //
        //
        //      ***Fields***
        //      (beyond the fields of the "User" class)
        //
        //
        // _ subjectsTaughtList: List<string> - it is used to store the subjects taught
        // by the administrator.

        public Administrator
            (int _sql_id, string _familyName, string _firstName, string _userIdentificationNumber, string _passwordHashCode, DateTime _registrationTime, string _authorizationLevel, string _subjectsTaught) : base ( _sql_id,  _familyName,  _firstName,  _userIdentificationNumber,  _passwordHashCode,  _registrationTime,  _authorizationLevel,  _subjectsTaught)
        {

        }
    }
}
