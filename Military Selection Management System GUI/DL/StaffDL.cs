using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.UI;

namespace Military_Selection_Management_System.DL
{
    class StaffDL
    {
        private static List<Staff> authorizedStaff = new List<Staff>();
        public static List<Staff> GetAuthorizedStaffList()
        {
            return authorizedStaff;
        }
    }
}
