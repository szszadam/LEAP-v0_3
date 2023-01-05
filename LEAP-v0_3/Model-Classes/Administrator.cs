using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    class Administrator : Teacher
    {
        /*fifth comment section*/
        public Administrator
            (int _sql_id, string _familyName, string _firstName, string _userIdentificationNumber, string _passwordHashCode, DateTime _registrationTime, string _authorizationLevel, string _subjectsTaught) : base ( _sql_id,  _familyName,  _firstName,  _userIdentificationNumber,  _passwordHashCode,  _registrationTime,  _authorizationLevel,  _subjectsTaught)
        {

        }
    }
}
