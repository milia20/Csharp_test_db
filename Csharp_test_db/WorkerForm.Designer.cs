namespace Csharp_test_db
{
    partial class WorkerForm
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
            FAC_addres = new Label();
            UR_addres = new Label();
            Delete = new Button();
            INN = new Label();
            Update = new Button();
            NameText = new Label();
            dgvData = new DataGridView();
            Insert = new Button();
            label2 = new Label();
            label3 = new Label();
            MidName = new TextBox();
            FirstName = new TextBox();
            LastName = new TextBox();
            PasNumber = new TextBox();
            PasSer = new TextBox();
            LoadData = new Button();
            BirthDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // FAC_addres
            // 
            FAC_addres.AutoSize = true;
            FAC_addres.Location = new Point(330, 38);
            FAC_addres.Name = "FAC_addres";
            FAC_addres.Size = new Size(88, 15);
            FAC_addres.TabIndex = 25;
            FAC_addres.Text = "дата рождения";
            // 
            // UR_addres
            // 
            UR_addres.AutoSize = true;
            UR_addres.Location = new Point(224, 38);
            UR_addres.Name = "UR_addres";
            UR_addres.Size = new Size(58, 15);
            UR_addres.TabIndex = 23;
            UR_addres.Text = "Отчество";
            // 
            // Delete
            // 
            Delete.Location = new Point(595, 104);
            Delete.Name = "Delete";
            Delete.Size = new Size(130, 23);
            Delete.TabIndex = 21;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // INN
            // 
            INN.AutoSize = true;
            INN.Location = new Point(118, 38);
            INN.Name = "INN";
            INN.Size = new Size(31, 15);
            INN.TabIndex = 20;
            INN.Text = "Имя";
            // 
            // Update
            // 
            Update.Location = new Point(459, 104);
            Update.Name = "Update";
            Update.Size = new Size(130, 23);
            Update.TabIndex = 18;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(12, 38);
            NameText.Name = "NameText";
            NameText.Size = new Size(58, 15);
            NameText.TabIndex = 17;
            NameText.Text = "Фамилия";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(101, 142);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(624, 249);
            dgvData.TabIndex = 15;
            // 
            // Insert
            // 
            Insert.Location = new Point(323, 104);
            Insert.Name = "Insert";
            Insert.Size = new Size(130, 23);
            Insert.TabIndex = 14;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 38);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 30;
            label2.Text = "Паспорт Серия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 38);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 32;
            label3.Text = "Паспорт Номер";
            // 
            // MidName
            // 
            MidName.Location = new Point(12, 56);
            MidName.Name = "MidName";
            MidName.Size = new Size(100, 23);
            MidName.TabIndex = 33;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(118, 56);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(100, 23);
            FirstName.TabIndex = 34;
            // 
            // LastName
            // 
            LastName.Location = new Point(224, 56);
            LastName.Name = "LastName";
            LastName.Size = new Size(100, 23);
            LastName.TabIndex = 35;
            // 
            // PasNumber
            // 
            PasNumber.Location = new Point(642, 56);
            PasNumber.Name = "PasNumber";
            PasNumber.Size = new Size(100, 23);
            PasNumber.TabIndex = 37;
            // 
            // PasSer
            // 
            PasSer.Location = new Point(536, 56);
            PasSer.Name = "PasSer";
            PasSer.Size = new Size(100, 23);
            PasSer.TabIndex = 36;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(612, 415);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(113, 23);
            LoadData.TabIndex = 39;
            LoadData.Text = "Load Data";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // BirthDate
            // 
            BirthDate.Location = new Point(330, 56);
            BirthDate.Name = "BirthDate";
            BirthDate.Size = new Size(200, 23);
            BirthDate.TabIndex = 40;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BirthDate);
            Controls.Add(LoadData);
            Controls.Add(PasNumber);
            Controls.Add(PasSer);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(MidName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FAC_addres);
            Controls.Add(UR_addres);
            Controls.Add(Delete);
            Controls.Add(INN);
            Controls.Add(Update);
            Controls.Add(NameText);
            Controls.Add(dgvData);
            Controls.Add(Insert);
            Name = "WorkerForm";
            Text = "WorkerForm";
            Load += WorkerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FAC_addres;
        private Label UR_addres;
        private Button Delete;
        private Label INN;
        private Button Update;
        private Label NameText;
        private DataGridView dgvData;
        private Button Insert;
        private Label label2;
        private Label label3;
        private TextBox MidName;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox PasNumber;
        private TextBox PasSer;
        private Button LoadData;
        private DateTimePicker BirthDate;
    }
}