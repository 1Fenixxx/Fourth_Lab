using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_NewObject_Click(object sender, EventArgs e)
        {
            ComputerObjectBuffer.BufferObject = new ObjectLib.Computer();
            ObjectAddForm newWindow = new ObjectAddForm();
            newWindow.ShowDialog();
            this.LB_Objects.Items.Add(ComputerObjectBuffer.BufferObject);
        }

        private void LB_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LB_Objects.SelectedItem != null)
                    TB_ParamData.Text = LB_Objects.SelectedItem.ToString();
            }
            catch { }
        }

        private void B_Edit_Click(object sender, EventArgs e)
        {
            if (LB_Objects.SelectedItem != null)
                ComputerObjectBuffer.BufferObject = (ObjectLib.Computer)LB_Objects.SelectedItem;
            ObjectAddForm newWindow = new ObjectAddForm();
            this.LB_Objects.Items.RemoveAt(this.LB_Objects.Items.IndexOf(ComputerObjectBuffer.BufferObject));
            newWindow.ShowDialog();
            this.LB_Objects.Items.Add(ComputerObjectBuffer.BufferObject);
        }

        private void B_DeleteObject_Click(object sender, EventArgs e)
        {
            if (LB_Objects.SelectedItem != null)
                this.LB_Objects.Items.RemoveAt(this.LB_Objects.Items.IndexOf(ComputerObjectBuffer.BufferObject));
        }

        private void B_ClearList_Click(object sender, EventArgs e)
        {
            this.LB_Objects.Items.Clear();
        }

        private void B_Export_Click(object sender, EventArgs e)
        {
            string data = string.Empty;
            foreach (ObjectLib.Computer comp in LB_Objects.Items)
            {
                data += (comp) + "\n";
            }

            if (!System.IO.Directory.Exists(".. /Exported"))
            {
                System.IO.Directory.CreateDirectory(".. /Exported");
            }
            System.IO.File.WriteAllText($@"../Exported/ExportedData.txt", data);
        }
    }
}
