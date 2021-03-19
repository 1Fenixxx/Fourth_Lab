using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ObjectAddForm : Form
    {
        ObjectLib.Computer BufferObject;
        ObjectLib.Computer ExportObject;
        ObjectLib.Computer.DeviceDesc BufferDesc;
        public ObjectAddForm()
        {
            InitializeComponent();
            if (ComputerObjectBuffer.BufferObject != null) 
            { 
                BufferObject = ComputerObjectBuffer.BufferObject;
                BufferDesc = BufferObject.GetDesc();
            }
            else
            {
                BufferObject = new ObjectLib.Computer();
                BufferDesc = BufferObject.GetDesc();
            }

            ExportObject = new ObjectLib.Computer();

            CB_CPU.Items.Add(new ObjectLib.IntelCore_I3_6100());
            CB_CPU.Items.Add(new ObjectLib.IntelCore_I5_9300H());
            CB_CPU.Items.Add(new ObjectLib.Ryzen5_5600X());

            CB_GPU.Items.Add(new ObjectLib.GTX1050());
            CB_GPU.Items.Add(new ObjectLib.GTX1660());

            CB_Motherboard.Items.Add(new ObjectLib.Lenovo_Unknown(null, null));
            CB_Motherboard.Items.Add(new ObjectLib.Aorus_Z370(null, null));
            CB_Motherboard.Items.Add(new ObjectLib.Aorus_X590(null, null));

            CB_PowerSupply.Items.Add(new ObjectLib.PowerSupply_Germany550());
            CB_PowerSupply.Items.Add(new ObjectLib.PowerSupply_Polish950());

            CB_Drives.Items.Add(new ObjectLib.WD_Blue());
            CB_Drives.Items.Add(new ObjectLib.Samsung_EVO970());

            this.timer1.Start();
        }

        private void B_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void B_Save_Click(object sender, System.EventArgs e)
        {
            ExportObject = new ObjectLib.Computer(this.BufferDesc);
            ComputerObjectBuffer.BufferObject = ExportObject;
            this.Close();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                BufferObject = new ObjectLib.Computer(BufferDesc);
            }
            catch { }
            this.TB_ObjectContext.Text = BufferObject.ToString();
        }

        private void CB_Element_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (CB_Motherboard.SelectedItem!=null)
                    BufferDesc.Motherboard = ((ObjectLib.IMotherboard)CB_Motherboard.SelectedItem);
                if (CB_CPU.SelectedItem != null)
                    BufferDesc.Motherboard.CPU = ((ObjectLib.ICPU)CB_CPU.SelectedItem);
                if (CB_GPU.SelectedItem != null)
                    BufferDesc.Motherboard.GPU = ((ObjectLib.IGPU)CB_GPU.SelectedItem);
                if (CB_Drives.SelectedItem != null)
                    BufferDesc.Drives[0] = ((ObjectLib.I_SSD_HDD)CB_Drives.SelectedItem);
                if (CB_PowerSupply.SelectedItem != null)
                    BufferDesc.PS = ((ObjectLib.IPowerSupply)CB_PowerSupply.SelectedItem);
            }
            catch { }
        }
    }
}
