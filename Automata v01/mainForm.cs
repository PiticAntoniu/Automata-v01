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
            AutomataUtils.SaveToJson(Constants.defaultAutomata, a);

        }

        private void LoadAutomataButton_Click(object sender, EventArgs e)
        {
            AutomataProvider.A = AutomataUtils.LoadFromJson(Constants.defaultAutomata);
            automataRichTextBox.Text = AutomataConvertor.GetAutomataAsString(AutomataProvider.A);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            AutomataProvider.A = AutomataUtils.LoadFromJson(Constants.defaultAutomata);
            automataRichTextBox.Text = AutomataConvertor.GetAutomataAsString(AutomataProvider.A);
        }
        private void wordTextBox_TextChanged(object sender, EventArgs e)
        {
            bool validWord = AutomataUtils.CheckWord(AutomataProvider.A, wordTextBox.Text);
            if (validWord) 
            {
                wordTextBox.ForeColor = Constants.ValidWordColor;
            }
            else
            {
                wordTextBox.ForeColor = Constants.InvalidWordColor;
            }
            StepByStepRichTextBox.Text = AutomataUtils.stepByStepTranzitions;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
        }
    }
}
