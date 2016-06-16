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
            //6.
            //7.
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
            if (item.ValidationType == 1)
            {
                error = "This field requires a number only.";
                int testValue;
                if (int.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            //Generic Bool Valdation
            if (item.ValidationType == 2)
            {
                error = "This field requires a true or false only.";
                bool testValue;
                if (Boolean.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            //Generic Decimal Valdation
            if (item.ValidationType == 3)
            {
                error = "This field requires a number only.";
                decimal testValue;
                if (decimal.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            //Generic DateTime Valdation
            if (item.ValidationType == 4)
            {
                error = "This field requires a date time in the format mm/dd/yyyy.";
                DateTime testValue;
                if (DateTime.TryParse(item.Value.ToString(), out testValue))
                {
                    returnValue.Validated = true;
                }
            }
            //Generic DateTime Valdation
            if (item.ValidationType == 5)
            {
                error = "This field is required.";
                if (!string.IsNullOrEmpty(item.Value.ToString()))
                {
                    returnValue.Validated = true;
                }
            }

            if(returnValue.Validated == false)
            {
                returnValue.Message = error;
            }

            return returnValue;
        }
    }
}
