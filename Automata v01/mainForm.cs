using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata_v01
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MockDataButton_Click(object sender, EventArgs e)
        {
            Automata a = new Automata();

            a.MockData();
            AutomataUtils.SaveToJson(Constants.defaultAutomata,a);

        }

        private void LoadAutomataButton_Click(object sender, EventArgs e)
        {
            Automata a = AutomataUtils.LoadFromJson(Constants.defaultAutomata);
        }
    }
}
