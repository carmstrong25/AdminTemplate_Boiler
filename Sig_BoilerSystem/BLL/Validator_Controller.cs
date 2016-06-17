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
#endregion

namespace Sig_BoilerSystem.BLL
{
    public class Validator_Controller
    {
        public gvar validate(gvar item)
        {
            #region Types
            //1. INT
            //2. BOOL
            //3. DECIMAL
            //4. DATETIME
            //5. Required
            //6. Range
            //7. Lenght
            //8.
            //9.
            //10.
            #endregion

            gvar returnValue = new gvar();
            returnValue = item;
            returnValue.Validated = false;
            returnValue.Control = item.Control;
            string error = "";

            //Generic Int Valdation
            #region INT            
            if (item.ValidationType == 1)
            {
                error = "This field requires a number only.";
                int testValue;
                if (int.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //Generic Bool Valdation
            #region Bool
            if (item.ValidationType == 2)
            {
                error = "This field requires a true or false only.";
                bool testValue;
                if (Boolean.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //Generic Decimal Valdation
            #region Decimal
            if (item.ValidationType == 3)
            {
                error = "This field requires a number only.";
                decimal testValue;
                if (decimal.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //Generic DateTime Valdation
            #region DateTime
            if (item.ValidationType == 4)
            {
                error = "This field requires a date time in the format mm/dd/yyyy.";
                DateTime testValue;
                if (DateTime.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //Generic Required Valdation
            #region Required
            if (item.ValidationType == 5)
            {
                error = "This field is required.";
                if (!string.IsNullOrEmpty(item.Value.ToString()))
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //Generic Range Valdation
            #region Range
            if (item.ValidationType == 6)
            {
                //Must come in as int.
                //Param1: Small Value.
                //Parsm2: Big Value
                int val = int.Parse(item.Value.ToString());
                error = "This field does not meet the range contraints.";
                if (val >= item.Param1 && val <= item.Param2)
                {
                    returnValue.Validated = true;
                }
            }
            #endregion
            //Generic Lenght Valdation
            #region Lenght
            if (item.ValidationType == 7)
            {
                //Param1: lenght.
                string val = item.Value.ToString();
                error = "This field does not meet the lenght contraints.";
                if (val.Length <= item.Param1)
                {
                    returnValue.Validated = true;
                }
            }
            #endregion

            //set Message if failed
            if (returnValue.Validated == false)
            {
                returnValue.Message = error;
            }

            return returnValue;
        }
    }
}
