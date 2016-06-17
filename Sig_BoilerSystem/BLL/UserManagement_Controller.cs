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
        public bool AddNewUser(User newuser)
        {
            try
            {
                using (var context = new BoilerContext())
                {
                    User newUser = null;
                    newUser = context.Users.Add(newuser);
                    
                    context.SaveChanges();
                }
                return true;
            }
           catch(Exception e)
            {
                //ALERT ("e.innerMSG")
                return false;
            }
        }
        public bool UpdateUser(User user)
        {
            try
            {
                using (var context = new BoilerContext())
                {
                    var find = context.Users.Find(user);
                    

                    var update = context.Entry(context.Users.Attach(find));
                    update.Property(x => x.FirstName).IsModified = true;

                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                //ALERT ("e.innerMSG")
                return false;
            }
        }

    }
}
