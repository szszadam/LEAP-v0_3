using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    //      *****User Identification class*****
    //
    // It stores the data of the user logged into the LEAP system.Furthermore,
    // its methods perform the generation of the identification number of newly registered users,
    // as well as the encryption of given passwords with a hash algorithm.
    //
    //      ***Fields***
    //
    // It is used to store a reference to a "user" type object containing the data of
    // the active user logged into the system.
    //
    //      ***Methods***
    //
    // UserIdentificationNumberGenerator() – When the administrator registers a new user
    // in the system, the new user will receive a user identification number with which he
    // will be able to log in to the system.Also, this identification number will also be
    // the user’s first password, which is need to be changed at the first login on the appropriate
    // interface. The generated user identification number consists of the following:    //
    // First character: character representing the user's authorization level.
    // 'S' - Student, 'T' - Teacher, 'A' - Administrator
    // Second character: the initial letter of the user's last name.
    // If it is a special (accented) character, it will be replaced by the character in
    // the English ABC that forms the basis of the accented character.
    // Third character: the initial letter of the user's first name. If it is a special (accented)
    // character, it will be replaced by the character in the English ABC that forms the basis of
    // the accented character.
    // Then comes a hyphen separator which is followed by a sequence of the last four numeric
    // characters.This is the value of the user's SQL ID, padded with '0's from the left to give
    // a four-character sequence.
    //
    // hashPassword() – It encrypts the password passed to the method as a parameter
    // using the SHA-256 algorithm.


    static class UserIdentification
    {
        static User _activeUser;
        public static User ActiveUser
        {
            get
            {
                if (_activeUser is Administrator)
                {
                    return _activeUser as Administrator;
                }
                else if (_activeUser is Teacher)
                {
                    return _activeUser as Teacher;
                }
                else
                {
                    return _activeUser as Student;
                }
            }
            set
            {
                _activeUser = value;
            }
        }
        public static string UserIdentificationNumberGenerator(User individualUser)
        {
            char Letter_1;
            if (individualUser is Student) Letter_1 = 'S';
            else if (individualUser is Administrator) Letter_1 = 'A';
            else if (individualUser is Teacher) Letter_1 = 'T';
            else throw new Exception("Not appropriate or not properly defined authorization level!");
            char Letter_2 = individualUser.FamilyName[0];
            if (Letter_2 == 'á' || Letter_2 == 'Á') Letter_2 = 'A';
            if (Letter_2 == 'é' || Letter_2 == 'É') Letter_2 = 'E';
            if (Letter_2 == 'ó' || Letter_2 == 'Ó' || Letter_2 == 'ö' || Letter_2 == 'Ö' || Letter_2 == 'ő' || Letter_2 == 'Ő') Letter_2 = 'O';
            if (Letter_2 == 'ú' || Letter_2 == 'Ú' || Letter_2 == 'ü' || Letter_2 == 'Ü' || Letter_2 == 'ű' || Letter_2 == 'Ű') Letter_2 = 'U';

            char Letter_3 = individualUser.FirstName[0];
            if (Letter_3 == 'á' || Letter_3 == 'Á') Letter_3 = 'A';
            if (Letter_3 == 'é' || Letter_3 == 'É') Letter_3 = 'E';
            if (Letter_3 == 'ó' || Letter_3 == 'Ó' || Letter_3 == 'ö' || Letter_3 == 'Ö' || Letter_3 == 'ő' || Letter_3 == 'Ő') Letter_3 = 'O';
            if (Letter_3 == 'ú' || Letter_3 == 'Ú' || Letter_3 == 'ü' || Letter_3 == 'Ü' || Letter_3 == 'ű' || Letter_3 == 'Ű') Letter_3 = 'U';

            StringBuilder UserIdentificationNumber = new StringBuilder();
            UserIdentificationNumber.Append(char.ToUpper(Letter_1));
            UserIdentificationNumber.Append(char.ToUpper(Letter_2));
            UserIdentificationNumber.Append(char.ToUpper(Letter_3));
            UserIdentificationNumber.Append("-");
            UserIdentificationNumber.Append((Convert.ToString(individualUser.SQL_ID)).PadLeft(4, '0'));
            return UserIdentificationNumber.ToString();
        }
        public static string hashPassword(string password)
        {
            SHA256Managed HashGenerator = new SHA256Managed();
            StringBuilder Hash = new StringBuilder();
            byte[] HashedBytesArray = HashGenerator.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < HashedBytesArray.Length; i++)
            {
                Hash.Append(HashedBytesArray[i].ToString("x2"));
            }
            return Hash.ToString();
        }
    }
}
