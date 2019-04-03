using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityClassifier
{
    public partial class academicInfo : Form
    {
        public academicInfo()
        {
            InitializeComponent();
        }

        private void btnAICancel_Click(object sender, EventArgs e)
        {
            textBoxAIGpa.Clear();
            textBoxAIGreScore.Clear();
            textBoxAIToeflScore.Clear();
            textBoxAISoPScore.Clear();
            textBoxAILoRScore.Clear();
            this.Close();
        }

        private void btnAISubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
