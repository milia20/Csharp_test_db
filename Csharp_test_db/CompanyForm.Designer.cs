namespace Csharp_test_db
{
    partial class CompanyForm
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
            Insert = new Button();
            dgvData = new DataGridView();
            NameBox = new TextBox();
            NameText = new Label();
            INN = new Label();
            INNBox = new TextBox();
            Update = new Button();
            UR_addres = new Label();
            URBox = new TextBox();
            Delete = new Button();
            FAC_addres = new Label();
            FACBox = new TextBox();
            LoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // Insert
            // 
            Insert.Location = new Point(294, 93);
            Insert.Name = "Insert";
            Insert.Size = new Size(130, 23);
            Insert.TabIndex = 0;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(72, 122);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(624, 249);
            dgvData.TabIndex = 1;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(72, 64);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(140, 23);
            NameBox.TabIndex = 2;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(72, 36);
            NameText.Name = "NameText";
            NameText.Size = new Size(91, 15);
            NameText.TabIndex = 3;
            NameText.Text = "CompanyName";
            // 
            // INN
            // 
            INN.AutoSize = true;
            INN.Location = new Point(218, 36);
            INN.Name = "INN";
            INN.Size = new Size(34, 15);
            INN.TabIndex = 6;
            INN.Text = "ИНН";
            // 
            // INNBox
            // 
            INNBox.Location = new Point(218, 64);
            INNBox.Name = "INNBox";
            INNBox.Size = new Size(140, 23);
            INNBox.TabIndex = 5;
            // 
            // Update
            // 
            Update.Location = new Point(430, 93);
            Update.Name = "Update";
            Update.Size = new Size(130, 23);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // UR_addres
            // 
            UR_addres.AutoSize = true;
            UR_addres.Location = new Point(364, 36);
            UR_addres.Name = "UR_addres";
            UR_addres.Size = new Size(61, 15);
            UR_addres.TabIndex = 9;
            UR_addres.Text = "юр. адрес";
            // 
            // URBox
            // 
            URBox.Location = new Point(364, 64);
            URBox.Name = "URBox";
            URBox.Size = new Size(140, 23);
            URBox.TabIndex = 8;
            // 
            // Delete
            // 
            Delete.Location = new Point(566, 93);
            Delete.Name = "Delete";
            Delete.Size = new Size(130, 23);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // FAC_addres
            // 
            FAC_addres.AutoSize = true;
            FAC_addres.Location = new Point(510, 36);
            FAC_addres.Name = "FAC_addres";
            FAC_addres.Size = new Size(70, 15);
            FAC_addres.TabIndex = 12;
            FAC_addres.Text = "факт. адрес";
            // 
            // FACBox
            // 
            FACBox.Location = new Point(510, 64);
            FACBox.Name = "FACBox";
            FACBox.Size = new Size(140, 23);
            FACBox.TabIndex = 11;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(566, 377);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(130, 23);
            LoadData.TabIndex = 13;
            LoadData.Text = "LoadData";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // CompanyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadData);
            Controls.Add(FAC_addres);
            Controls.Add(FACBox);
            Controls.Add(UR_addres);
            Controls.Add(URBox);
            Controls.Add(Delete);
            Controls.Add(INN);
            Controls.Add(INNBox);
            Controls.Add(Update);
            Controls.Add(NameText);
            Controls.Add(NameBox);
            Controls.Add(dgvData);
            Controls.Add(Insert);
            Name = "CompanyForm";
            Text = "CompanyForm";
            Load += CompanyForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Insert;
        private DataGridView dgvData;
        private TextBox NameBox;
        private Label NameText;
        private Label INN;
        private TextBox INNBox;
        private Button Update;
        private Label UR_addres;
        private TextBox URBox;
        private Button Delete;
        private Label FAC_addres;
        private TextBox FACBox;
        private Button LoadData;
    }
}