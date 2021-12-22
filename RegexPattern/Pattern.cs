 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Raj

        //Method for first name 
        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, REGEX_FIRSTNAME);
        }


        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; //Roy

        // method for last name
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LAST_NAME_REGEX);

        }
        public static string REGEX_EMAIL = "^[a-zA-Z0-9.]+@[A-Za-z0-9]+.[A-Za-z]{2,4}$"; //alam41976@gmail.com

        //Method for email address
        public bool valiadtaeEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public static string REGEX_MOBILENUMBER = "^+[1-9]{2}|: :| |0-9|{10}$";


        // method for valid phone number
        public bool validateMobileNumber(string mnumber)
        {
            return Regex.IsMatch(mnumber, REGEX_MOBILENUMBER);
        }

        public static string REGEX_PASSWORDRULE1 = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";
        //method for paasword 
        public bool validatePaswordRule1(string prule1)
        {
            return Regex.IsMatch(prule1, REGEX_PASSWORDRULE1);
        }

        // method for passwordrule2
        public static string REGEX_PASSWORDRULE2 = "^([A-Z])*[!@#$%^&*]{1}([a-zA-Z0-9])*$"; //A@123af
        
        public bool validatePaswordRule2(string prule2)
        {
            return Regex.IsMatch(prule2, REGEX_PASSWORDRULE2);
        }

        //Method For Paasword Rule-3

        public static string PASSWORD_RULE3_REGEX = "^([a-zA-Z0-9])[!@#$%^&]{1}([a-zA-Z0-9])*$"; // At least 1 Numeric Number And All Rules Must Be Passed
        public bool validatePaswordRule3(string prule3)
        {
            return Regex.IsMatch(prule3, PASSWORD_RULE3_REGEX);
        }
        //Method For Paasword Rule-4




        public static string PASSWORD_RULE4_REGEX = "^([a-zA-Z0-9])[!@#$%^&]{1}([a-zA-Z0-9])*$"; // Has Exactly 1 Special Characters And All Rules Must Be Passed
        public bool validatePaswordRule4(string prule4)
        {
            return Regex.IsMatch(prule4, PASSWORD_RULE4_REGEX);
        }

    }
}
