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
    public class UserManagement_Controller
    {
        public gvar AddNewUser(User newuser)
        {
            gvar returnValue = new gvar();
            try
            {
                using (var context = new BoilerContext())
                {
                    User newUser = null;
                    newUser = context.Users.Add(newuser);
                    
                    context.SaveChanges();
                }
                returnValue.Success = true;
            }
           catch(Exception e)
            {
                returnValue.Message = e.Message.ToString();
                returnValue.Success = false;
            }
            return returnValue;
        }
        public gvar UpdateUser(User user)
        {
            gvar returnValue = new gvar();
            try
            {
                using (var context = new BoilerContext())
                {
                    var find = context.Users.Find(user);
                    

                    var update = context.Entry(context.Users.Attach(find));
                    update.Property(x => x.FirstName).IsModified = true;

                    context.SaveChanges();
                }
                returnValue.Success = true;
            }
            catch (Exception e)
            {
                returnValue.Message = e.Message.ToString();
                returnValue.Success = false;
            }
            return returnValue;
        }
    }
}
