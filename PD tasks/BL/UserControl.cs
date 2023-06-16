using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PD_tasks.BL
{
    class UserControl
    {
        public void DataBind()
        {
            // Refresh the data grid view with the current DataList
            dataGridView.DataSource = DataList;
        }
    }
}
