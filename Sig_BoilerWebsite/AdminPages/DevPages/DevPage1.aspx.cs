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
using System.Web.Services;
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
            gvar lettersValue = new gvar();
            gvar phoneValue = new gvar();
            gvar emailValue = new gvar();
            gvar passwordValue = new gvar();
            gvar passwordConfirmationValue = new gvar();

            string test = txt_phone.Text;

            #region txt_int
            intValue = gval.Required(txt_int.Text, "txt_int"); // Control.Text, ControlID
            allVars.Add(intValue);
            if (intValue.Success == true)
            {
                intValue = gval.Int(txt_int.Text, "txt_int");
                allVars.Add(intValue);
            }
            #endregion

            #region txt_bool
            boolValue = gval.Bool(txt_bool.Text, "txt_bool");
            allVars.Add(boolValue);
            if (boolValue.Success == true)
            {
                boolValue = gval.Bool(txt_bool.Text, "txt_bool");
                allVars.Add(boolValue);
            }
            #endregion

            #region txt_decimal
            decimalValue = gval.Decimal(txt_decimal.Text, "txt_decimal");
            allVars.Add(decimalValue);
            if (decimalValue.Success == true)
            {
                decimalValue = gval.Decimal(txt_decimal.Text, "txt_decimal");
                allVars.Add(decimalValue);
            }
            #endregion

            #region txt_datetime
            datetimeValue = gval.Datetime(txt_datetime.Text, "txt_datetime");
            allVars.Add(datetimeValue);
            if (datetimeValue.Success == true)
            {
                datetimeValue = gval.Datetime(txt_datetime.Text, "txt_datetime");
                allVars.Add(datetimeValue);
            }
            #endregion

            #region txt_range
            rangeValue = gval.Required(txt_range.Text, "txt_range");
            allVars.Add(rangeValue);
            if (rangeValue.Success == true)
            {
                rangeValue = gval.Int(txt_range.Text, "txt_range");
                allVars.Add(rangeValue);
            }
            if (rangeValue.Success == true)
            {
                rangeValue = gval.RangeInt(txt_range.Text, "txt_range", 5, 10);
                allVars.Add(rangeValue);
            }
            #endregion

            #region txt_lenght
            //This one doesn't need to check if int.
            lenghtValue = gval.Required(txt_lenght.Text, "txt_lenght"); 
            allVars.Add(lenghtValue);
            if (lenghtValue.Success == true)
            {
                lenghtValue = gval.Lenght(txt_lenght.Text, "txt_lenght", 5, 1); 
                allVars.Add(lenghtValue);
            }
            #endregion

            #region txt_password
            //passwordValue = gval.validate(txt_password.Text, 5, "txt_password", 0, 0, "");
            //allVars.Add(passwordValue);
            //if(passwordValue.Success == true)
            //{
            //    passwordValue = gval.validate(txt_password_confrimation.Text, 5, "txt_password_confrimation", 0, 0, "");
            //    allVars.Add(passwordValue);
            //    if (passwordValue.Success == true)
            //    {
            //        passwordValue = gval.validate(txt_password.Text, 8, "txt_password", 2, 0, txt_password_confrimation.Text);
            //        allVars.Add(passwordValue);
            //    }
            //} 
            #endregion

            #region txt_letters
            lettersValue = gval.Special(txt_letters.Text, "txt_letters");
            allVars.Add(lettersValue);
            if (lettersValue.Success == true)
            {
                lettersValue = gval.Special(txt_letters.Text, "txt_letters");
                allVars.Add(lettersValue);
            }
            #endregion

            #region txt_phone
            phoneValue = gval.Required(txt_phone.Text, "txt_phone");
            allVars.Add(phoneValue);
            if (phoneValue.Success == true)
            {
                phoneValue = gval.Phone(txt_phone.Text, "txt_phone");
                allVars.Add(phoneValue);
            }
            #endregion

            #region txt_email
            emailValue = gval.Email(txt_email.Text, "txt_email");
            allVars.Add(emailValue);
            if (emailValue.Success == true)
            {
                emailValue = gval.Email(txt_email.Text, "txt_email");
                allVars.Add(emailValue);
            }
            #endregion

            #region txt_password
            passwordValue = gval.Required(txt_password.Text, "txt_password");//Password required
            allVars.Add(passwordValue);

            passwordConfirmationValue = gval.Required(txt_passwordconfirmation.Text, "txt_passwordconfirmation");//Password Confirmation required
            allVars.Add(passwordConfirmationValue);

            if (passwordValue.Success == true && passwordConfirmationValue.Success == true) //Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character
            {
                passwordValue = gval.PasswordCharacters(txt_password.Text, "txt_password");
                allVars.Add(passwordValue);
            }
            if (passwordValue.Success == true) // Password and Confirmation match
            {
                passwordValue = gval.PasswordCompare(txt_password.Text, "txt_password", txt_passwordconfirmation.Text);
                allVars.Add(passwordValue);
            }
            #endregion

            #region Check Validation
            bool failed = false;
            ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder");
            foreach (gvar item in allVars)
            {
                TextBox tb = (TextBox)cph.FindControl(item.Control);
                Label lb = (Label)cph.FindControl("val_" + item.Control);
                if (item.Success == false)
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
                int Int = int.Parse(intValue.Value.ToString());
                bool Bool = bool.Parse(boolValue.Value.ToString());
                decimal Decimal = decimal.Parse(decimalValue.Value.ToString());
                DateTime dateTime = DateTime.Parse(datetimeValue.Value.ToString());
                int Range = int.Parse(rangeValue.Value.ToString());
                string Lenght = lenghtValue.Value.ToString();
                //string Password = passwordValue.Value.ToString();
                string Letters = lettersValue.Value.ToString();

                lbl_int.Text = Int.ToString();
                lbl_bool.Text = Bool.ToString();
                lbl_decimal.Text = Decimal.ToString();
                lbl_datetime.Text = dateTime.ToString();
                lbl_range.Text = Range.ToString();
                lbl_lenght.Text = Lenght.ToString();
                //lbl_password.Text = Password.ToString();
                lbl_letters.Text = Letters.ToString();

                //success call your BLL from here
                //int invalue = int.parse(intValue);
                //bool update = Controller.update(intvalue);
                //and so on.
                alerts("SUCCESS: All values match the validation.", "success");
            }
            else
            {
                alerts("ERROR: One or more values does not match the required constraints.", "error");
                //failed
            }
        }
        catch
        {
            //catch
        }
    }
    protected void alerts(string msg, string alerttype)
    {
        hide_alertmsg.Text = msg; //msg will be Error + what ever you set this too.
        hide_alerttype.Text = alerttype; // notice(blue), warning(orange), success(Green) or error
        ScriptManager.RegisterStartupScript(this, GetType(), "noti", "noti();", true);       
    }
    [WebMethod]
    public static int CheckUsernameAvail(string uname)
    {
        UserManagement_Controller ctrl = new UserManagement_Controller();
        bool checkUser = ctrl.Check_Username_availability(uname);
        if (checkUser == true)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}