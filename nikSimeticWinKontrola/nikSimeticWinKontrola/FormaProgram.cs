using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikSimeticWinKontrola
{
    public partial class FormaProgram : Form
    {
        public FormaProgram()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string odabir = cmbRunProgram.SelectedItem.ToString();
            if(odabir == "Paint")
            {
                Process.Start("mspaint.exe");
            }
            if(odabir=="Notepad")
            {
                Process.Start("notepad.exe");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(grbProgramControl.Visible == false)
            {
                grbProgramControl.Visible = true;
            }else
            {
                grbProgramControl.Visible = false;
            }
        }
            private void btnClear_Click(object sender, EventArgs e)
            {
            txtProgramDescription.Clear();
            txtProgramName.Clear(); 
            }
        private void messageToo1StripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite drugi batun.", "Obaveštenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        private void textToo1StripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText form = new FormaText();
            form.Show();
        }
        private void exitToo1StripMenuItem_Click(Object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li ste sigurni da zelite zatvoriti aplikaciju?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(odgovor == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
