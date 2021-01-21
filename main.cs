using System;
using System.Diagnostics;
using System.Windows.Forms;
using ionInjectorZ;

namespace ionInjector
{
    public partial class main : Form
    {
        public Module _module = new Module();

        public string selectedDLL;

        public main()
        {
            InitializeComponent();
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (procList.GetItemText(procList.SelectedItem) != "")
                {
                    if(selectedDLL != null)
                    {
                        string _new = procList.SelectedItem.ToString().Substring(0, procList.SelectedItem.ToString().Length - 4);
                        _module.InjectDLL(_new, selectedDLL);
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Dll", "Error: No Dll Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select A Process From The List", "Error: No Process Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some error rip", "lol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            procList.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.ProcessName))
                {
                    procList.Items.Add(p.ProcessName+".exe");
                }
            }
        }

        private void selectDLLBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Dynamic Linc Library File (*.dll)|*.dll";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    selectedDLL = opendialogfile.FileName;
                    selectedDLLlbl.Text = "Selected DLL: "+ opendialogfile.SafeFileName;
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            procList.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.ProcessName))
                {
                    procList.Items.Add(p.ProcessName + ".exe");
                }
            }
        }
    }
}
