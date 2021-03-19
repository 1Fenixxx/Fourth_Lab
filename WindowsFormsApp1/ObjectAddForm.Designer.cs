namespace WindowsFormsApp1
{
    partial class ObjectAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TB_ObjectContext = new System.Windows.Forms.TextBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.CB_CPU = new System.Windows.Forms.ComboBox();
            this.CB_GPU = new System.Windows.Forms.ComboBox();
            this.CB_Motherboard = new System.Windows.Forms.ComboBox();
            this.CB_Drives = new System.Windows.Forms.ComboBox();
            this.CB_PowerSupply = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_ObjectContext
            // 
            this.TB_ObjectContext.Enabled = false;
            this.TB_ObjectContext.Location = new System.Drawing.Point(124, 12);
            this.TB_ObjectContext.Multiline = true;
            this.TB_ObjectContext.Name = "TB_ObjectContext";
            this.TB_ObjectContext.Size = new System.Drawing.Size(182, 129);
            this.TB_ObjectContext.TabIndex = 1;
            // 
            // B_Save
            // 
            this.B_Save.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.B_Save.Location = new System.Drawing.Point(9, 85);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(109, 56);
            this.B_Save.TabIndex = 2;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Cancel.ForeColor = System.Drawing.Color.Red;
            this.B_Cancel.Location = new System.Drawing.Point(9, 12);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(109, 57);
            this.B_Cancel.TabIndex = 3;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // CB_CPU
            // 
            this.CB_CPU.FormattingEnabled = true;
            this.CB_CPU.Location = new System.Drawing.Point(312, 39);
            this.CB_CPU.Name = "CB_CPU";
            this.CB_CPU.Size = new System.Drawing.Size(210, 21);
            this.CB_CPU.TabIndex = 4;
            this.CB_CPU.SelectedIndexChanged += new System.EventHandler(this.CB_Element_SelectedIndexChanged);
            // 
            // CB_GPU
            // 
            this.CB_GPU.FormattingEnabled = true;
            this.CB_GPU.Location = new System.Drawing.Point(312, 66);
            this.CB_GPU.Name = "CB_GPU";
            this.CB_GPU.Size = new System.Drawing.Size(210, 21);
            this.CB_GPU.TabIndex = 5;
            this.CB_GPU.SelectedIndexChanged += new System.EventHandler(this.CB_Element_SelectedIndexChanged);
            // 
            // CB_Motherboard
            // 
            this.CB_Motherboard.FormattingEnabled = true;
            this.CB_Motherboard.Location = new System.Drawing.Point(312, 12);
            this.CB_Motherboard.Name = "CB_Motherboard";
            this.CB_Motherboard.Size = new System.Drawing.Size(210, 21);
            this.CB_Motherboard.TabIndex = 6;
            this.CB_Motherboard.SelectedIndexChanged += new System.EventHandler(this.CB_Element_SelectedIndexChanged);
            // 
            // CB_Drives
            // 
            this.CB_Drives.FormattingEnabled = true;
            this.CB_Drives.Location = new System.Drawing.Point(312, 93);
            this.CB_Drives.Name = "CB_Drives";
            this.CB_Drives.Size = new System.Drawing.Size(210, 21);
            this.CB_Drives.TabIndex = 7;
            this.CB_Drives.SelectedIndexChanged += new System.EventHandler(this.CB_Element_SelectedIndexChanged);
            // 
            // CB_PowerSupply
            // 
            this.CB_PowerSupply.FormattingEnabled = true;
            this.CB_PowerSupply.Location = new System.Drawing.Point(312, 120);
            this.CB_PowerSupply.Name = "CB_PowerSupply";
            this.CB_PowerSupply.Size = new System.Drawing.Size(210, 21);
            this.CB_PowerSupply.TabIndex = 8;
            this.CB_PowerSupply.SelectedIndexChanged += new System.EventHandler(this.CB_Element_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(528, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(529, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "GPU";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(529, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Motherboard";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(529, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Drive";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(529, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Power source";
            // 
            // ObjectAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 151);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_PowerSupply);
            this.Controls.Add(this.CB_Drives);
            this.Controls.Add(this.CB_Motherboard);
            this.Controls.Add(this.CB_GPU);
            this.Controls.Add(this.CB_CPU);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.TB_ObjectContext);
            this.Name = "ObjectAddForm";
            this.Text = "ObjectAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_ObjectContext;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.ComboBox CB_CPU;
        private System.Windows.Forms.ComboBox CB_GPU;
        private System.Windows.Forms.ComboBox CB_Motherboard;
        private System.Windows.Forms.ComboBox CB_Drives;
        private System.Windows.Forms.ComboBox CB_PowerSupply;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}