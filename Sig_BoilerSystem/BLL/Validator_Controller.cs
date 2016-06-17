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
        public gvar validate(string value, int type, string control, int param1, int param2, string param3)
        {
            #region Types
            //1. INT
            //2. BOOL
            //3. DECIMAL
            //4. DATETIME
            //5. Required
            //6. Range
            //7. Lenght
            //8. Compare
            //9.
            //10.
            #endregion

            gvar returnValue = new gvar();
            returnValue.Value = value;
            returnValue.ValidationType = type;
            returnValue.Control = control;
            returnValue.Param1 = param1;
            returnValue.Param2 = param2;
            returnValue.Param3 = param3;
            returnValue.Validated = false;

            string error = "";

            //1. Generic Int Valdation
            #region Int   
            if (returnValue.ValidationType == 1)
            {
                error = "This field requires a number only.";
                int testValue;
                if (int.TryParse(returnValue.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //2. Generic Bool Valdation
            #region Bool
            if (returnValue.ValidationType == 2)
            {
                error = "This field requires a true or false only.";
                bool testValue;
                if (Boolean.TryParse(returnValue.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //3. Generic Decimal Valdation
            #region Decimal
            if (returnValue.ValidationType == 3)
            {
                error = "This field requires a number only.";
                decimal testValue;
                if (decimal.TryParse(returnValue.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //4. Generic DateTime Valdation
            #region DateTime
            if (returnValue.ValidationType == 4)
            {
                error = "This field requires a date time in the format mm/dd/yyyy.";
                DateTime testValue;
                if (DateTime.TryParse(returnValue.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //5. Generic Required Valdation
            #region Required
            if (returnValue.ValidationType == 5)
            {
                error = "This field is required.";
                if (!string.IsNullOrEmpty(returnValue.Value.ToString()))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //6. Generic Range Valdation
            #region Range
            if (returnValue.ValidationType == 6)
            {
                //Value must be INT
                //Param1: Small Value.
                //Parsm2: Big Value
                int val = int.Parse(returnValue.Value.ToString());
                error = string.Format("This field does not meet the range contraints. Must be between {0} and {1}.", returnValue.Param1, returnValue.Param2);
                if (val >= returnValue.Param1 && val <= returnValue.Param2)
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //7. Generic Lenght Valdation
            #region Lenght
            if (returnValue.ValidationType == 7)
            {
                //Param1: lenght.
                //Param2: type
                    //1: greater
                    //2: Less
                    //3: exatly
                string val = returnValue.Value.ToString();
                
                if (returnValue.Param2 == 1)
                {
                    error = string.Format("This field does not meet the lenght contraints. Must be at least {0} characters long.", returnValue.Param1);
                    if (val.Length >= returnValue.Param1)
                    {
                        returnValue.Validated = true;
                    }
                }
                if (returnValue.Param2 == 2)
                {
                    error = string.Format("This field does not meet the lenght contraints. Must be no more than {0} characters long.", returnValue.Param1);
                    if (val.Length <= returnValue.Param1)
                    {
                        returnValue.Validated = true;
                    }
                }
                if (returnValue.Param2 == 3)
                {
                    error = string.Format("This field does not meet the lenght contraints. Must be exactly {0} characters long.", returnValue.Param1);
                    if (val.Length == returnValue.Param1)
                    {
                        returnValue.Validated = true;
                    }
                }


            }
            #endregion
            //8. Generic Compare and Password Valdation
            #region Generic Compare and Password
            if (returnValue.ValidationType == 8)
            {
                //Value must be a string
                //Param3: The item to compare to
                //Param1: Type of Compare
                    //1: Generic
                    //2: Password
                if (returnValue.Value.ToString() == returnValue.Param3)
                {
                    returnValue.Validated = true;
                }
                if(returnValue.Param1 == 1)
                {
                    error = "The two values do not match";
                }
                if(returnValue.Param1 == 2)
                {
                    error = "The password and confirmation do not match.";
                }
            }
            #endregion

            //9. Not special characters
            if(returnValue.ValidationType == 9)
            {
                bool testBool = Regex.IsMatch(returnValue.Value.ToString(), "^[a-zA-Z]+$");
                error = "This field requires only letters";
                if (testBool == true)
                {
                    returnValue.Validated = true;
                }
            }
            //set Message if failed
            if (returnValue.Validated == false)
            {
                returnValue.Message = error;
            }

            return returnValue;
        }
    }
}
