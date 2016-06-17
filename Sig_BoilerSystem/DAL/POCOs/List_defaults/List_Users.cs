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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Phone { get; set; }

        public string PassHash { get; set; }

        public string SecSal { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public bool Recovery { get; set; }
    }
}
