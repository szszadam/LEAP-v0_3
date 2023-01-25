using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    //      *****User class*****
    //
    // A parent class for uniting users' data. The "Student", "Teacher" and "Administrator" classes
    // also descend from this class.
    //
    //      ***Fields***
    //
    // _SQL_ID: int – it is used to store the primary key(ID/serial number) of the users
    // stored in the SQL database.
    //
    // _familyName: string – It is used to store the user's last name. Maximum of 25 characters.
    //
    // _firstName: string – It is used to store the user's first name. Maximum of 25 characters.
    //
    // _userIdentificationNumber: string- It is used to store the user's identification number.
    //
    // _passwordHashCode: string – It is used to store hash code of the user's password
    // which is encrypted by using SHA256 algorithm.
    //
    // _registrationTime: DateTime – It is used to store the user's registration time.
    //
    // _authorizationLevel: char – Used to store the user's authorization level.

    class User
    {
        /*third comment section*/
        protected int _SQL_ID;
        protected string _familyName;
        protected string _firstName;
        protected string _userIdentificationNumber;
        protected string _passwordHashCode;
        protected DateTime _registrationTime;
        protected char _authorizationLevel;
        public int SQL_ID
        {
            get { return _SQL_ID; }
            set { _SQL_ID = value; }
        }
        public string FamilyName
        {
            get
            {
                return this._familyName;
            }
            set
            {
                if (value.Length <= 25) _familyName = value;
                else throw new FormatException("The family name can be a maximum of 25 characters long!");
            }
        }
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                if (value.Length <= 25) _firstName = value;
                else throw new FormatException("The first name can be a maximum of 25 characters long!");
            }
        }
        public string UserIdentificationNumber
        {
            get { return _userIdentificationNumber; }
            set { _userIdentificationNumber = value; }
        }

        public string PasswordHashCode
        {
            get { return _passwordHashCode; }
            set { _passwordHashCode = value; }
        }
        public char AuthorizationLevel
        {
            get { return _authorizationLevel; }
            set { _authorizationLevel = value; }
        }
        public DateTime RegistrationTime
        {
            get { return _registrationTime; }
            set { _registrationTime = value; }
        }
    }
}
