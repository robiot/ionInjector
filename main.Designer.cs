
namespace ionInjector
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.injectBtn = new System.Windows.Forms.Button();
            this.procList = new System.Windows.Forms.ComboBox();
            this.selectDLLBTN = new System.Windows.Forms.Button();
            this.selectedDLLlbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // injectBtn
            // 
            this.injectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(203)))));
            this.injectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectBtn.Location = new System.Drawing.Point(13, 107);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(268, 52);
            this.injectBtn.TabIndex = 0;
            this.injectBtn.TabStop = false;
            this.injectBtn.Text = "Inject Dll";
            this.injectBtn.UseVisualStyleBackColor = false;
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // procList
            // 
            this.procList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procList.FormattingEnabled = true;
            this.procList.Location = new System.Drawing.Point(13, 22);
            this.procList.Name = "procList";
            this.procList.Size = new System.Drawing.Size(199, 24);
            this.procList.TabIndex = 1;
            this.procList.TabStop = false;
            this.procList.Text = "Choose Process";
            // 
            // selectDLLBTN
            // 
            this.selectDLLBTN.BackColor = System.Drawing.Color.Gray;
            this.selectDLLBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDLLBTN.Location = new System.Drawing.Point(13, 52);
            this.selectDLLBTN.Name = "selectDLLBTN";
            this.selectDLLBTN.Size = new System.Drawing.Size(133, 37);
            this.selectDLLBTN.TabIndex = 2;
            this.selectDLLBTN.TabStop = false;
            this.selectDLLBTN.Text = "Select DLL";
            this.selectDLLBTN.UseVisualStyleBackColor = false;
            this.selectDLLBTN.Click += new System.EventHandler(this.selectDLLBTN_Click);
            // 
            // selectedDLLlbl
            // 
            this.selectedDLLlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectedDLLlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.selectedDLLlbl.Location = new System.Drawing.Point(152, 55);
            this.selectedDLLlbl.Name = "selectedDLLlbl";
            this.selectedDLLlbl.Size = new System.Drawing.Size(114, 42);
            this.selectedDLLlbl.TabIndex = 3;
            this.selectedDLLlbl.Text = "Selected DLL: None";
            this.selectedDLLlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Gray;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.refreshBtn.Location = new System.Drawing.Point(218, 22);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(63, 24);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(295, 177);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.selectedDLLlbl);
            this.Controls.Add(this.selectDLLBTN);
            this.Controls.Add(this.procList);
            this.Controls.Add(this.injectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "ionInjector x86";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button injectBtn;
        private System.Windows.Forms.ComboBox procList;
        private System.Windows.Forms.Button selectDLLBTN;
        private System.Windows.Forms.Label selectedDLLlbl;
        private System.Windows.Forms.Button refreshBtn;
    }
}

