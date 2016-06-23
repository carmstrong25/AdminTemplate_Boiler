using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sig_BoilerSystem.BLL;
using Sig_BoilerSystem.DAL;

public partial class AdminPages_Users_UserManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        try
        {
         #region Validation
            Validator_Controller gval = new Validator_Controller();
            List<gvar> allVars = new List<gvar>();
            gvar lastNameValue = new gvar();
            gvar firstNameValue = new gvar();
            gvar usernameValue = new gvar();
            gvar emailValue = new gvar();
            gvar phoneNumberValue = new gvar();
            gvar passwordValue = new gvar();
            //gvar passwordValue = new gvar();
            gvar lettersValue = new gvar();
         #endregion

        #region check first name
            firstNameValue = gval.Required(txt_FirstName.Text, "txt_FirstName");
            allVars.Add(firstNameValue);
            if (firstNameValue.Success == true)
        {
            firstNameValue = gval.RangeString(txt_FirstName.Text, "txt_FirstName", 2, 20);
            allVars.Add(firstNameValue);
        }
            #endregion

        #region check last name
            lastNameValue = gval.Required(txt_LastName.Text, "txt_LastName");
            allVars.Add(lastNameValue);

            if (lastNameValue.Success == true)
        {
            lastNameValue = gval.RangeString(txt_LastName.Text, "txt_LastName", 2, 20);
            allVars.Add(lastNameValue);
        }
        #endregion

        #region check username
            usernameValue = gval.Required(txt_Username.Text, "txt_Username");
            allVars.Add(usernameValue);
        if (usernameValue.Success == true)
        {
            usernameValue = gval.RangeString(txt_Username.Text, "txt_Username", 2, 15);
            allVars.Add(usernameValue);
        }
        #endregion

        #region check email
        emailValue = gval.Required(txt_Email.Text, "txt_Email");
        allVars.Add(emailValue);
        if (emailValue.Success == true)
        {
            emailValue = gval.RangeString(txt_Email.Text, "txt_Email", 2, 40);
            allVars.Add(emailValue);
        }
        #endregion

        #region check phone number
        phoneNumberValue = gval.Required(txt_phone.Text, "txt_phone");
        allVars.Add(phoneNumberValue);
        if (phoneNumberValue.Success == true)
        {
            phoneNumberValue = gval.RangeString(txt_phone.Text, "txt_phone", 10, 10);
            allVars.Add(phoneNumberValue);
        }
        #endregion

        #region check password
        passwordValue = gval.Required(txt_Password.Text, "txt_Password");
        allVars.Add(passwordValue);
        if (passwordValue.Success == true)
        {
            passwordValue = gval.Int(txt_Password.Text, "txt_Password");
            allVars.Add(passwordValue);
        }
        if (passwordValue.Success == true)
        {
            passwordValue = gval.RangeString(txt_Password.Text, "txt_Password", 2, 20);
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

      if (failed != true)
            {
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