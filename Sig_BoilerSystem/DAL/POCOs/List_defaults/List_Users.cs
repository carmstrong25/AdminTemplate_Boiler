using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sig_BoilerSystem.DAL.POCOs
{
    public class List_Users
    {
        public int UserID { get; set; }

        public string AccountType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public string Passhash { get; set; }

        public string SecSalt { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedByID { get; set; }
    }
}
