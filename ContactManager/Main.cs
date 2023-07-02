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
                    TCtrlMain.SelectedTab = TabCreateEdit;
                    break;
                case Tab.Search:
                    TCtrlMain.SelectedTab = TabSearch;
                    break;
                case Tab.Edit:
                    TCtrlMain.SelectedTab = TabSearch;
                    break;
                case Tab.Delete:
                    TCtrlMain.SelectedTab = TabSearch;
                    break;
                default:
                    break;
            }
        }
    }
}