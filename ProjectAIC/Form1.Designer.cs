namespace ProjectAIC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoPanel = new MetroFramework.Controls.MetroPanel();
            this.salaryText = new MetroFramework.Controls.MetroTextBox();
            this.positionText = new MetroFramework.Controls.MetroTextBox();
            this.ageText = new MetroFramework.Controls.MetroTextBox();
            this.pibText = new MetroFramework.Controls.MetroTextBox();
            this.salaryLabel = new MetroFramework.Controls.MetroLabel();
            this.positionLabel = new MetroFramework.Controls.MetroLabel();
            this.ageLabel = new MetroFramework.Controls.MetroLabel();
            this.pibLabel = new MetroFramework.Controls.MetroLabel();
            this.browseBtn = new MetroFramework.Controls.MetroButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.editBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.pIBDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.imageUrlDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(306, 288);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(ProjectAIC.Employee);
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.salaryText);
            this.infoPanel.Controls.Add(this.positionText);
            this.infoPanel.Controls.Add(this.ageText);
            this.infoPanel.Controls.Add(this.pibText);
            this.infoPanel.Controls.Add(this.salaryLabel);
            this.infoPanel.Controls.Add(this.positionLabel);
            this.infoPanel.Controls.Add(this.ageLabel);
            this.infoPanel.Controls.Add(this.pibLabel);
            this.infoPanel.Controls.Add(this.browseBtn);
            this.infoPanel.Controls.Add(this.pic);
            this.infoPanel.HorizontalScrollbarBarColor = true;
            this.infoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.infoPanel.HorizontalScrollbarSize = 10;
            this.infoPanel.Location = new System.Drawing.Point(335, 63);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(329, 287);
            this.infoPanel.TabIndex = 1;
            this.infoPanel.VerticalScrollbarBarColor = true;
            this.infoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.infoPanel.VerticalScrollbarSize = 10;
            // 
            // salaryText
            // 
            // 
            // 
            // 
            this.salaryText.CustomButton.Image = null;
            this.salaryText.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.salaryText.CustomButton.Name = "";
            this.salaryText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.salaryText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salaryText.CustomButton.TabIndex = 1;
            this.salaryText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salaryText.CustomButton.UseSelectable = true;
            this.salaryText.CustomButton.Visible = false;
            this.salaryText.Lines = new string[0];
            this.salaryText.Location = new System.Drawing.Point(183, 108);
            this.salaryText.MaxLength = 32767;
            this.salaryText.Name = "salaryText";
            this.salaryText.PasswordChar = '\0';
            this.salaryText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salaryText.SelectedText = "";
            this.salaryText.SelectionLength = 0;
            this.salaryText.SelectionStart = 0;
            this.salaryText.Size = new System.Drawing.Size(113, 23);
            this.salaryText.TabIndex = 11;
            this.salaryText.UseSelectable = true;
            this.salaryText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salaryText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // positionText
            // 
            // 
            // 
            // 
            this.positionText.CustomButton.Image = null;
            this.positionText.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.positionText.CustomButton.Name = "";
            this.positionText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.positionText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.positionText.CustomButton.TabIndex = 1;
            this.positionText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.positionText.CustomButton.UseSelectable = true;
            this.positionText.CustomButton.Visible = false;
            this.positionText.Lines = new string[0];
            this.positionText.Location = new System.Drawing.Point(183, 75);
            this.positionText.MaxLength = 32767;
            this.positionText.Name = "positionText";
            this.positionText.PasswordChar = '\0';
            this.positionText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.positionText.SelectedText = "";
            this.positionText.SelectionLength = 0;
            this.positionText.SelectionStart = 0;
            this.positionText.Size = new System.Drawing.Size(113, 23);
            this.positionText.TabIndex = 10;
            this.positionText.UseSelectable = true;
            this.positionText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.positionText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ageText
            // 
            // 
            // 
            // 
            this.ageText.CustomButton.Image = null;
            this.ageText.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.ageText.CustomButton.Name = "";
            this.ageText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ageText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ageText.CustomButton.TabIndex = 1;
            this.ageText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ageText.CustomButton.UseSelectable = true;
            this.ageText.CustomButton.Visible = false;
            this.ageText.Lines = new string[0];
            this.ageText.Location = new System.Drawing.Point(183, 46);
            this.ageText.MaxLength = 32767;
            this.ageText.Name = "ageText";
            this.ageText.PasswordChar = '\0';
            this.ageText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ageText.SelectedText = "";
            this.ageText.SelectionLength = 0;
            this.ageText.SelectionStart = 0;
            this.ageText.Size = new System.Drawing.Size(113, 23);
            this.ageText.TabIndex = 9;
            this.ageText.UseSelectable = true;
            this.ageText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ageText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pibText
            // 
            // 
            // 
            // 
            this.pibText.CustomButton.Image = null;
            this.pibText.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.pibText.CustomButton.Name = "";
            this.pibText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pibText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pibText.CustomButton.TabIndex = 1;
            this.pibText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pibText.CustomButton.UseSelectable = true;
            this.pibText.CustomButton.Visible = false;
            this.pibText.Lines = new string[0];
            this.pibText.Location = new System.Drawing.Point(183, 15);
            this.pibText.MaxLength = 32767;
            this.pibText.Name = "pibText";
            this.pibText.PasswordChar = '\0';
            this.pibText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pibText.SelectedText = "";
            this.pibText.SelectionLength = 0;
            this.pibText.SelectionStart = 0;
            this.pibText.Size = new System.Drawing.Size(113, 23);
            this.pibText.TabIndex = 8;
            this.pibText.UseSelectable = true;
            this.pibText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pibText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(118, 108);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(48, 19);
            this.salaryLabel.TabIndex = 7;
            this.salaryLabel.Text = "Salary:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(118, 75);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(57, 19);
            this.positionLabel.TabIndex = 6;
            this.positionLabel.Text = "Position:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(118, 46);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(36, 19);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age:";
            // 
            // pibLabel
            // 
            this.pibLabel.AutoSize = true;
            this.pibLabel.Location = new System.Drawing.Point(118, 15);
            this.pibLabel.Name = "pibLabel";
            this.pibLabel.Size = new System.Drawing.Size(31, 19);
            this.pibLabel.TabIndex = 4;
            this.pibLabel.Text = "PIB:";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(26, 137);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(72, 23);
            this.browseBtn.TabIndex = 3;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseSelectable = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(12, 15);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 116);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(335, 357);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(62, 24);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(403, 358);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(58, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.UseSelectable = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(467, 358);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(63, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(536, 358);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(62, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(604, 358);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(60, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseSelectable = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // pIBDataGridViewTextBoxColumn
            // 
            this.pIBDataGridViewTextBoxColumn.DataPropertyName = "PIB";
            this.pIBDataGridViewTextBoxColumn.HeaderText = "PIB";
            this.pIBDataGridViewTextBoxColumn.Name = "pIBDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // imageUrlDataGridViewTextBoxColumn
            // 
            this.imageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            this.imageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
            this.imageUrlDataGridViewTextBoxColumn.Name = "imageUrlDataGridViewTextBoxColumn";
            this.imageUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 435);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Form1";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel infoPanel;
        private System.Windows.Forms.PictureBox pic;
        private MetroFramework.Controls.MetroLabel salaryLabel;
        private MetroFramework.Controls.MetroLabel positionLabel;
        private MetroFramework.Controls.MetroLabel ageLabel;
        private MetroFramework.Controls.MetroLabel pibLabel;
        private MetroFramework.Controls.MetroButton browseBtn;
        private MetroFramework.Controls.MetroButton editBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroTextBox salaryText;
        private MetroFramework.Controls.MetroTextBox positionText;
        private MetroFramework.Controls.MetroTextBox ageText;
        private MetroFramework.Controls.MetroTextBox pibText;
        private MetroFramework.Controls.MetroButton addBtn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageUrlDataGridViewTextBoxColumn;
    }
}

