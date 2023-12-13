using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIYU_SecureID
{
    public partial class ControlDashboard : UserControl
    {
        ClassInformation info = new ClassInformation();
        public ControlDashboard()
        {
            InitializeComponent();

            labelTotalTransaction.Text += info.LoadTotalTransaction().ToString();
        }
    }
}
