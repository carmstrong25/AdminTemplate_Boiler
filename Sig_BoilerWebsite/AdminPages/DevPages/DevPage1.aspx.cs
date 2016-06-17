using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additonal Namespaces
using Sig_BoilerSystem.DAL.Entities;
using Sig_BoilerSystem.DAL.POCOs;
using Sig_BoilerSystem.DAL.DTOs;
using Sig_BoilerSystem.DAL;
using Sig_BoilerSystem.BLL;
#endregion

public partial class AdminPages_DevPages_DevPage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        try
        {
            #region Validation
            Validator_Controller gval = new Validator_Controller();
            List<gvar> allVars = new List<gvar>();
            gvar intValue = new gvar();
            gvar boolValue = new gvar();
            gvar decimalValue = new gvar();
            gvar datetimeValue = new gvar();
            gvar rangeValue = new gvar();
            gvar lenghtValue = new gvar();
            gvar passwordValue = new gvar();
            gvar lettersValue = new gvar();

            #region txt_int
            intValue = gval.validate(txt_int.Text, 5, "txt_int", 0, 0, ""); // Control.Text, ValidationType, ControlID, Param1(int), Param2(int), Param3(string)
            allVars.Add(intValue);
            if (intValue.Validated == true)
            {
                intValue = gval.validate(txt_int.Text, 1, "txt_int", 0, 0, "");
                allVars.Add(intValue);
            }
            #endregion

            #region txt_bool
            boolValue = gval.validate(txt_bool.Text, 5, "txt_bool", 0, 0, "");
            allVars.Add(boolValue);
            if (boolValue.Validated == true)
            {
                boolValue = gval.validate(txt_bool.Text, 2, "txt_bool", 0, 0, "");
                allVars.Add(boolValue);
            }
            #endregion

            #region txt_decimal
            decimalValue = gval.validate(txt_decimal.Text, 5, "txt_decimal", 0, 0, "");
            allVars.Add(decimalValue);
            if (decimalValue.Validated == true)
            {
                decimalValue = gval.validate(txt_decimal.Text, 3, "txt_decimal", 0, 0, "");
                allVars.Add(decimalValue);
            }
            #endregion

            #region txt_datetime
            datetimeValue = gval.validate(txt_datetime.Text, 5, "txt_datetime", 0, 0, "");
            allVars.Add(datetimeValue);
            if (datetimeValue.Validated == true)
            {
                datetimeValue = gval.validate(txt_datetime.Text, 4, "txt_datetime", 0, 0, "");
                allVars.Add(datetimeValue);
            }
            #endregion

            #region txt_range
            rangeValue = gval.validate(txt_range.Text, 5, "txt_range", 0, 0, "");
            allVars.Add(rangeValue);
            if (rangeValue.Validated == true)
            {
                rangeValue = gval.validate(txt_range.Text, 1, "txt_range", 0, 0, "");
                allVars.Add(rangeValue);
            }
            if (rangeValue.Validated == true)
            {
                rangeValue = gval.validate(txt_range.Text, 6, "txt_range", 5, 10, "");
                allVars.Add(rangeValue);
            }
            #endregion

            #region txt_lenght
            //This one doesn't need to check if int.
            lenghtValue = gval.validate(txt_lenght.Text, 5, "txt_lenght", 0, 0, ""); 
            allVars.Add(lenghtValue);
            if (lenghtValue.Validated == true)
            {
                lenghtValue = gval.validate(txt_lenght.Text, 7, "txt_lenght", 5, 2, "");
                allVars.Add(lenghtValue);
            }
            #endregion

            #region txt_password
            passwordValue = gval.validate(txt_password.Text, 5, "txt_password", 0, 0, "");
            allVars.Add(passwordValue);
            if(passwordValue.Validated == true)
            {
                passwordValue = gval.validate(txt_password_confrimation.Text, 5, "txt_password_confrimation", 0, 0, "");
                allVars.Add(passwordValue);
                if (passwordValue.Validated == true)
                {
                    passwordValue = gval.validate(txt_password.Text, 8, "txt_password", 2, 0, txt_password_confrimation.Text);
                    allVars.Add(passwordValue);
                }
            }

           
            #endregion

            #region txt_letters
            lettersValue = gval.validate(txt_letters.Text, 5, "txt_letters", 0, 0, "");
            allVars.Add(lettersValue);
            if (lettersValue.Validated == true)
            {
                lettersValue = gval.validate(txt_letters.Text, 9, "txt_letters", 0, 0, "");
                allVars.Add(lettersValue);
            }
            #endregion

            #region Check Validation
            bool failed = false;
            ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder");
            foreach (gvar item in allVars)
            {
                TextBox tb = (TextBox)cph.FindControl(item.Control);
                Label lb = (Label)cph.FindControl("val_" + item.Control);
                if (item.Validated == false)
                {
                    tb.CssClass = "form-control error";
                    lb.Text = item.Message;
                    failed = true;
                }
                else
                {
                    tb.CssClass = "form-control";
                    lb.Text = "";
                }
            }
            #endregion
            #endregion

            if (failed != true)
            {
                //success call your BLL from here
                //int invalue = int.parse(intValue);
                //bool update = Controller.update(intvalue);
                //and so on.
            }
            else
            {
                //failed
            }
        }
        catch
        {
            //catch
        }
    }
}