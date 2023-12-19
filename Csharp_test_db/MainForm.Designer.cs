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
            ShowCompany = new Button();
            ShowWorker = new Button();
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
            AddCompanyButton.Location = new Point(428, 51);
            AddCompanyButton.Name = "AddCompanyButton";
            AddCompanyButton.Size = new Size(226, 50);
            AddCompanyButton.TabIndex = 1;
            AddCompanyButton.Text = "Add Company";
            AddCompanyButton.UseVisualStyleBackColor = true;
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
            // 
            // AddWorkerButton
            // 
            AddWorkerButton.Cursor = Cursors.Hand;
            AddWorkerButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddWorkerButton.Location = new Point(428, 133);
            AddWorkerButton.Name = "AddWorkerButton";
            AddWorkerButton.Size = new Size(226, 50);
            AddWorkerButton.TabIndex = 4;
            AddWorkerButton.Text = "Add Worker";
            AddWorkerButton.UseVisualStyleBackColor = true;
            // 
            // ShowCompany
            // 
            ShowCompany.Cursor = Cursors.Hand;
            ShowCompany.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowCompany.Location = new Point(138, 51);
            ShowCompany.Name = "ShowCompany";
            ShowCompany.Size = new Size(226, 50);
            ShowCompany.TabIndex = 7;
            ShowCompany.Text = "Show Company";
            ShowCompany.UseVisualStyleBackColor = true;
            // 
            // ShowWorker
            // 
            ShowWorker.Cursor = Cursors.Hand;
            ShowWorker.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowWorker.Location = new Point(138, 133);
            ShowWorker.Name = "ShowWorker";
            ShowWorker.Size = new Size(226, 50);
            ShowWorker.TabIndex = 8;
            ShowWorker.Text = "Show Worker";
            ShowWorker.UseVisualStyleBackColor = true;
            // 
            // UPpanel
            // 
            UPpanel.BackColor = SystemColors.ControlLight;
            UPpanel.Controls.Add(ShowCompany);
            UPpanel.Controls.Add(ShowWorker);
            UPpanel.Controls.Add(AddCompanyButton);
            UPpanel.Controls.Add(AddWorkerButton);
            UPpanel.Dock = DockStyle.Top;
            UPpanel.Location = new Point(0, 0);
            UPpanel.Name = "UPpanel";
            UPpanel.Size = new Size(800, 211);
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
        private Button ShowCompany;
        private Button ShowWorker;
        private Panel UPpanel;
        private Panel panel1;
    }
}