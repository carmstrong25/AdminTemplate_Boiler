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
            Validator_Controller gval = new Validator_Controller();
            List<gvar> allVars = new List<gvar>();
            gvar intValue = new gvar();
            gvar boolValue = new gvar();
            gvar decimalValue = new gvar();
            gvar datetimeValue = new gvar();
            gvar rangeValue = new gvar();
            gvar lenghtValue = new gvar();

            #region txt_int
            intValue.Value = txt_int.Text;
            intValue.ValidationType = 5; // required
            intValue.Control = "txt_int";
            allVars.Add(gval.validate(intValue));
            if (intValue.Validated == true)
            {
                intValue.ValidationType = 1; // int 
                allVars.Add(gval.validate(intValue));
            }
            #endregion

            #region txt_bool
            boolValue.Value = txt_bool.Text;
            boolValue.ValidationType = 5; // required
            boolValue.Control = "txt_bool";
            allVars.Add(gval.validate(boolValue));
            if (boolValue.Validated == true)
            {
                boolValue.ValidationType = 2; // bool
                allVars.Add(gval.validate(boolValue));
            }
            #endregion

            #region txt_decimal
            decimalValue.Value = txt_decimal.Text;
            decimalValue.ValidationType = 5; // reqired
            decimalValue.Control = "txt_decimal";
            allVars.Add(gval.validate(decimalValue));
            if (decimalValue.Validated == true)
            {
                decimalValue.ValidationType = 3; // decimal
                allVars.Add(gval.validate(decimalValue));
            }
            #endregion

            #region txt_datetime
            datetimeValue.Value = txt_datetime.Text;
            datetimeValue.ValidationType = 5; // required
            datetimeValue.Control = "txt_datetime";
            allVars.Add(gval.validate(datetimeValue));
            if (datetimeValue.Validated == true)
            {
                datetimeValue.ValidationType = 4; // DateTime
                allVars.Add(gval.validate(datetimeValue));
            }
            #endregion

            #region txt_range
            rangeValue.Value = txt_range.Text;
            rangeValue.ValidationType = 5; // required
            rangeValue.Control = "txt_range";
            allVars.Add(gval.validate(rangeValue));
            if (rangeValue.Validated == true)
            {
                rangeValue.ValidationType = 1; // int check
                allVars.Add(gval.validate(rangeValue));
            }
            if (rangeValue.Validated == true)
            {
                rangeValue.ValidationType = 6; // range check
                rangeValue.Param1 = 5;
                rangeValue.Param2 = 10;
                allVars.Add(gval.validate(rangeValue));
            }
            #endregion

            #region txt_lenght
            //This one doesn't need to check if int.
            lenghtValue.Value = txt_lenght.Text;
            lenghtValue.ValidationType = 5; // required
            lenghtValue.Control = "txt_lenght";
            allVars.Add(gval.validate(lenghtValue));
            if (lenghtValue.Validated == true)
            {
                lenghtValue.ValidationType = 7; // lenght check
                lenghtValue.Param1 = 5;
                allVars.Add(gval.validate(lenghtValue));
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