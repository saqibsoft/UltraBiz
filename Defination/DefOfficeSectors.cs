using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Defination
{
    public partial class DefOfficeSectors : Form
    {
        DAL.OfficeSectors objDAL = new DAL.OfficeSectors();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

       
        public DefOfficeSectors()
        {
            InitializeComponent();
        }

        private void DefOfficeSectors_Load(object sender, EventArgs e)
        {
            
        }
       
        
    }
}
