namespace Csharp_test_db
{
    partial class MainForm
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
            AddCompanyButton = new Button();
            CreateCSV = new Button();
            UploadCSV = new Button();
            AddWorkerButton = new Button();
            UPpanel = new Panel();
            panel1 = new Panel();
            UPpanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddCompanyButton
            // 
            AddCompanyButton.Cursor = Cursors.Hand;
            AddCompanyButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddCompanyButton.Location = new Point(138, 68);
            AddCompanyButton.Name = "AddCompanyButton";
            AddCompanyButton.Size = new Size(226, 50);
            AddCompanyButton.TabIndex = 1;
            AddCompanyButton.Text = "Companies";
            AddCompanyButton.UseVisualStyleBackColor = true;
            AddCompanyButton.Click += AddCompanyButton_Click;
            // 
            // CreateCSV
            // 
            CreateCSV.Cursor = Cursors.Hand;
            CreateCSV.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateCSV.Location = new Point(138, 85);
            CreateCSV.Name = "CreateCSV";
            CreateCSV.Size = new Size(226, 50);
            CreateCSV.TabIndex = 6;
            CreateCSV.Text = "Create CSV";
            CreateCSV.UseVisualStyleBackColor = true;
            CreateCSV.Click += CreateCSV_Click;
            // 
            // UploadCSV
            // 
            UploadCSV.Cursor = Cursors.Hand;
            UploadCSV.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UploadCSV.Location = new Point(428, 85);
            UploadCSV.Name = "UploadCSV";
            UploadCSV.Size = new Size(226, 50);
            UploadCSV.TabIndex = 5;
            UploadCSV.Text = "From CSV";
            UploadCSV.UseVisualStyleBackColor = true;
            UploadCSV.Click += UploadCSV_Click;
            // 
            // AddWorkerButton
            // 
            AddWorkerButton.Cursor = Cursors.Hand;
            AddWorkerButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddWorkerButton.Location = new Point(428, 68);
            AddWorkerButton.Name = "AddWorkerButton";
            AddWorkerButton.Size = new Size(226, 50);
            AddWorkerButton.TabIndex = 4;
            AddWorkerButton.Text = "Workers";
            AddWorkerButton.UseVisualStyleBackColor = true;
            AddWorkerButton.Click += AddWorkerButton_Click;
            // 
            // UPpanel
            // 
            UPpanel.BackColor = SystemColors.ControlLight;
            UPpanel.Controls.Add(AddCompanyButton);
            UPpanel.Controls.Add(AddWorkerButton);
            UPpanel.Dock = DockStyle.Top;
            UPpanel.Location = new Point(0, 0);
            UPpanel.Name = "UPpanel";
            UPpanel.Size = new Size(800, 218);
            UPpanel.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(CreateCSV);
            panel1.Controls.Add(UploadCSV);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 233);
            panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(UPpanel);
            Name = "MainForm";
            Text = "MainForm";
            UPpanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddCompanyButton;
        private Button CreateCSV;
        private Button UploadCSV;
        private Button AddWorkerButton;
        private Panel UPpanel;
        private Panel panel1;
    }
}