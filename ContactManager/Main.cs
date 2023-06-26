using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Main : Form
    {
        public enum Tab
        {
            Create,
            Search,
            Edit,
            Delete
        }

        public Main()
        {
            InitializeComponent();
        }

        public Main(int selectedTab) : this()
        {
            Tab tab = (Tab)selectedTab;

            switch (tab)
            {
                case Tab.Create:
                    tabControl1.SelectedTab = tabPage2;
                    break;
                case Tab.Search:
                    tabControl1.SelectedTab = tabPage1;
                    break;
                case Tab.Edit:
                    tabControl1.SelectedTab = tabPage1;
                    break;
                case Tab.Delete:
                    tabControl1.SelectedTab = tabPage1;
                    break;
                default:
                    break;
            }
        }
    }
}
