using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ContactManager
{
    public partial class FormSearchAdvanced : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        public List<object> searchParams = new List<object>();

        public FormSearchAdvanced()
        {
            if (Program.Auth)
            {
                InitializeComponent();

                manager.AddFormToManage(this);

                Font fontCurrent = LblSearchHeadlineGeneral.Font;
                Font newFont = new Font(fontCurrent.FontFamily, fontCurrent.Size + 1, FontStyle.Bold);
                LblSearchHeadlineGeneral.Font = newFont;
                LblSearchHeadlineCustomer.Font = newFont;
                LblSearchHeadlineTrainee.Font = newFont;
                LblSearchHeadlineEmployee.Font = newFont;
            }
            else
            {
                MessageBox.Show(this, "Error: authentication required");
                Application.Exit();
            }
        }

        private void FormSearchAdvanced_Load(object sender, EventArgs e)
        {

        }
    }
}
