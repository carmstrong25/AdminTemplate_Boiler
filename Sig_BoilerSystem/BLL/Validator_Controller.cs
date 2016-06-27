using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additonal Namespaces
using Sig_BoilerSystem.DAL.Entities;
using Sig_BoilerSystem.DAL.POCOs;
using Sig_BoilerSystem.DAL.DTOs;
using Sig_BoilerSystem.DAL;
using System.ComponentModel;
using System.Data.Entity;
using System.Text.RegularExpressions;
#endregion

namespace Sig_BoilerSystem.BLL
{
    public class Validator_Controller
    {
        public gvar fillgvar (string value, string control)
        {
            //Fills the Gvar and returns.
            gvar returnValue = new gvar();
            returnValue.Value = value;
            returnValue.Control = control;
            returnValue.Success = false;     
            return returnValue;
        }
        public gvar Int(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "This field requires a number only.";
            int testValue;
            if (int.TryParse(returnValue.Value.ToString(), out testValue))
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Bool(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "This field requires a true or false only.";
            bool testValue;
            if (Boolean.TryParse(returnValue.Value.ToString(), out testValue))
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Decimal(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "This field requires a number only.";
            decimal testValue;
            if (decimal.TryParse(returnValue.Value.ToString(), out testValue))
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Datetime(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "This field requires a date time in the format mm/dd/yyyy.";
            DateTime testValue;
            if (DateTime.TryParse(returnValue.Value.ToString(), out testValue))
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Required(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "This field is required.";
            if (!string.IsNullOrEmpty(returnValue.Value.ToString()))
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar RangeString(string value, string control, int smallValue, int bigValue)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            int val = value.Count();
            string error = string.Format("This field does not meet the range contraints. Must be between {0} and {1} characters long.", smallValue, bigValue);
            if (val >= smallValue && val <= bigValue)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar RangeInt(string value, string control, int smallValue, int bigValue)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            int val = int.Parse(returnValue.Value.ToString());
            string error = string.Format("This field does not meet the range contraints. Must be between {0} and {1}.", smallValue, bigValue);
            if (val >= smallValue && val <= bigValue)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Lenght(string value, string control, int lenght, int type)
        {
            //type:
                //1: greater
                //2: Less
                //3: exatly
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "";
            string val = returnValue.Value.ToString();

            if (type == 1)
            {
                error = string.Format("This field does not meet the lenght contraints. Must be at least {0} characters long.", lenght);
                if (val.Length >= lenght)
                {
                    returnValue.Success = true;
                }
            }
            if (type == 2)
            {
                error = string.Format("This field does not meet the lenght contraints. Must be no more than {0} characters long.", lenght);
                if (val.Length <= lenght)
                {
                    returnValue.Success = true;
                }
            }
            if (type == 3)
            {
                error = string.Format("This field does not meet the lenght contraints. Must be exactly {0} characters long.", lenght);
                if (val.Length == lenght)
                {
                    returnValue.Success = true;
                }
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Compare(string value, string control, string compareValue)
        {
            //compareValue: The item to compare to
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "The two values do not match";
            if (returnValue.Value.ToString() == compareValue)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Special(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            bool testBool = Regex.IsMatch(returnValue.Value.ToString(), "^[a-zA-Z]+$");
            string error = "This field requires only letters";
            if (testBool == true)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar PasswordCharacters(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            Regex regexPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}");
            bool testBool = regexPassword.IsMatch(returnValue.Value.ToString());
            string error = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character";
            if (testBool == true)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar PasswordCompare(string value, string control, string compareValue)
        {
            //compareValue: The item to compare to
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            string error = "The password and the confirmation do no match.";
            if (returnValue.Value.ToString() == compareValue)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Phone(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);

            Regex regexPhoneNumber = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            bool testBool = regexPhoneNumber.IsMatch(returnValue.Value.ToString());
            string error = "Phone Numbers must match: (123) 123-1234";
            if (testBool == true)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
        public gvar Email(string value, string control)
        {
            gvar returnValue = new gvar();
            returnValue = fillgvar(value, control);
            Regex regexEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            bool testBool = regexEmail.IsMatch(returnValue.Value.ToString());
            string error = "Emails must match: john.doe@jdoe.com";
            if (testBool == true)
            {
                returnValue.Success = true;
            }
            if (returnValue.Success == false)
            {
                returnValue.Message = error;
            }
            return returnValue;
        }
    }
}
