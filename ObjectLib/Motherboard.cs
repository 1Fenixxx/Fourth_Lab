using System;

namespace ObjectLib
{
    public interface IMotherboard
    {
        ICPU CPU { get; set; } //CentralProcessingUnit
        IGPU GPU { get; set; } //GraphicProcessingUnit
        Sockets Socket { get; }
        Type[] CompatibleCPUs { get; }
        double Price { get; }
    }
    public class Lenovo_Unknown : IMotherboard
    {
        public ICPU CPU { get; set; } //CentralProcessingUnit
        public IGPU GPU { get; set; } //GraphicProcessingUnit
        public Sockets Socket { get; private set; }
        public Type[] CompatibleCPUs { get; private set; }
        public double Price { get; private set; }

        public Lenovo_Unknown(ICPU CPU, IGPU GPU)
        {
            this.Socket = Sockets.LGA1151;
            this.CompatibleCPUs = new Type[]
            {
                new IntelCore_I3_6100().GetType()
            };

            //CPU Compatible check
            if (CPU != null)
            {
                bool isCompatible = false;
                foreach (Type type in CompatibleCPUs)
                {
                    if (type == CPU.GetType())
                    {
                        isCompatible = true;
                        break;
                    }
                }
                if (isCompatible)
                {
                    this.CPU = CPU;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("CPU " + CPU.Name + " isn`t compatible with " + this.Socket + " motherboard socket. Cpu set`s by default to " + CompatibleCPUs[0].Name);
                    this.CPU = new IntelCore_I3_6100();
                }
            }
            else
            {
                this.CPU = new IntelCore_I3_6100();
            }

            if (GPU != null)
                this.GPU = GPU;
            else
                this.GPU = new GTX1050();
        }
        public override string ToString()
        {
            return "Lenovo Unknown motherboard";
        }
    }
    public class Aorus_X590 : IMotherboard
    {
        public ICPU CPU { get; set; } //CentralProcessingUnit
        public IGPU GPU { get; set; } //GraphicProcessingUnit
        public Sockets Socket { get; private set; }
        public Type[] CompatibleCPUs { get; private set; }
        public double Price { get; private set; }

        public Aorus_X590(ICPU CPU, IGPU GPU)
        {
            this.Socket = Sockets.AM4;
            this.CompatibleCPUs = new Type[]
            {
                new Ryzen5_5600X().GetType()
            };

            //CPU Compatible check
            if (CPU != null)
            {
                bool isCompatible = false;
                foreach (Type type in CompatibleCPUs)
                {
                    if (type == CPU.GetType())
                    {
                        isCompatible = true;
                        break;
                    }
                }
                if (isCompatible)
                {
                    this.CPU = CPU;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("CPU " + CPU.Name + " isn`t compatible with " + this.Socket + " motherboard socket. Cpu set`s by default to " + CompatibleCPUs[0].Name);
                    this.CPU = new Ryzen5_5600X();
                }
            }
            else
            {
                this.CPU = new Ryzen5_5600X();
            }

            if (GPU != null)
                this.GPU = GPU;
            else
                this.GPU = new GTX1050();
        }
        public override string ToString()
        {
            return "Gigabyte Aorus X590";
        }
    }
    public class Aorus_Z370 : IMotherboard
    {
        public ICPU CPU { get; set; } //CentralProcessingUnit
        public IGPU GPU { get; set; } //GraphicProcessingUnit
        public Sockets Socket { get; private set; }
        public Type[] CompatibleCPUs { get; private set; }
        public double Price { get; private set; }

        public Aorus_Z370(ICPU CPU, IGPU GPU)
        {
            this.Socket = Sockets.AM4;
            this.CompatibleCPUs = new Type[]
            {
                new IntelCore_I3_6100().GetType(),
                new IntelCore_I5_9300H().GetType()
            };

            //CPU Compatible check
            if (CPU != null)
            {
                bool isCompatible = false;
                foreach (Type type in CompatibleCPUs)
                {
                    if (type == CPU.GetType())
                    {
                        isCompatible = true;
                        break;
                    }
                }
                if (isCompatible)
                {
                    this.CPU = CPU;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("CPU " + CPU.Name + " isn`t compatible with " + this.Socket + " motherboard socket. Cpu set`s by default to " + CompatibleCPUs[0].Name);
                    this.CPU = new IntelCore_I3_6100();
                }
            }
            else
            {
                this.CPU = new IntelCore_I3_6100();
            }

            if (GPU != null)
                this.GPU = GPU;
            else
                this.GPU = new GTX1050();
        }
        public override string ToString()
        {
            return "Gigabyte Aorus Z370";
        }
    }
}
