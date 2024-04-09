namespace Rental
{
    partial class Register
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label postLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.databaseRentalSet = new Rental.DatabaseRentalSet();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerTableAdapter = new Rental.DatabaseRentalSetTableAdapters.RegisterTableAdapter();
            this.tableAdapterManager = new Rental.DatabaseRentalSetTableAdapters.TableAdapterManager();
            this.registerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.registerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.registerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureWork = new System.Windows.Forms.PictureBox();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingNavigator)).BeginInit();
            this.registerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWork)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(137, 139);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(38, 13);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(137, 165);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(45, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Пароль";
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.Location = new System.Drawing.Point(137, 191);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(65, 13);
            postLabel.TabIndex = 7;
            postLabel.Text = "Должность";
            // 
            // databaseRentalSet
            // 
            this.databaseRentalSet.DataSetName = "DatabaseRentalSet";
            this.databaseRentalSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "Register";
            this.registerBindingSource.DataSource = this.databaseRentalSet;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DisksTableAdapter = null;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.RegisterTableAdapter = this.registerTableAdapter;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rental.DatabaseRentalSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registerBindingNavigator
            // 
            this.registerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registerBindingNavigator.BindingSource = this.registerBindingSource;
            this.registerBindingNavigator.CountItem = null;
            this.registerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.registerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.registerBindingNavigatorSaveItem});
            this.registerBindingNavigator.Location = new System.Drawing.Point(140, 108);
            this.registerBindingNavigator.MoveFirstItem = null;
            this.registerBindingNavigator.MoveLastItem = null;
            this.registerBindingNavigator.MoveNextItem = null;
            this.registerBindingNavigator.MovePreviousItem = null;
            this.registerBindingNavigator.Name = "registerBindingNavigator";
            this.registerBindingNavigator.PositionItem = null;
            this.registerBindingNavigator.Size = new System.Drawing.Size(81, 25);
            this.registerBindingNavigator.TabIndex = 0;
            this.registerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // registerBindingNavigatorSaveItem
            // 
            this.registerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registerBindingNavigatorSaveItem.Image")));
            this.registerBindingNavigatorSaveItem.Name = "registerBindingNavigatorSaveItem";
            this.registerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.registerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.registerBindingNavigatorSaveItem.Click += new System.EventHandler(this.registerBindingNavigatorSaveItem_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(211, 136);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(211, 162);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // postTextBox
            // 
            this.postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "Post", true));
            this.postTextBox.Location = new System.Drawing.Point(211, 188);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(100, 20);
            this.postTextBox.TabIndex = 8;
            // 
            // registerDataGridView
            // 
            this.registerDataGridView.AutoGenerateColumns = false;
            this.registerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.registerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.registerDataGridView.DataSource = this.registerBindingSource;
            this.registerDataGridView.Location = new System.Drawing.Point(140, 229);
            this.registerDataGridView.Name = "registerDataGridView";
            this.registerDataGridView.RowHeadersVisible = false;
            this.registerDataGridView.Size = new System.Drawing.Size(399, 220);
            this.registerDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "reg_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID работника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Post";
            this.dataGridViewTextBoxColumn4.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // pictureBack
            // 
            this.pictureBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBack.Image")));
            this.pictureBack.Location = new System.Drawing.Point(371, 13);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(45, 40);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBack.TabIndex = 10;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(155)))));
            this.panel1.Location = new System.Drawing.Point(-4, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 403);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(223)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.pictureClose);
            this.panel2.Controls.Add(this.pictureBack);
            this.panel2.Location = new System.Drawing.Point(134, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 100);
            this.panel2.TabIndex = 12;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(422, 13);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(45, 40);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 11;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.panel3.Controls.Add(this.pictureWork);
            this.panel3.Location = new System.Drawing.Point(-4, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 100);
            this.panel3.TabIndex = 13;
            // 
            // pictureWork
            // 
            this.pictureWork.Image = ((System.Drawing.Image)(resources.GetObject("pictureWork.Image")));
            this.pictureWork.Location = new System.Drawing.Point(16, 13);
            this.pictureWork.Name = "pictureWork";
            this.pictureWork.Size = new System.Drawing.Size(116, 80);
            this.pictureWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWork.TabIndex = 0;
            this.pictureWork.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerDataGridView);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(postLabel);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.registerBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingNavigator)).EndInit();
            this.registerBindingNavigator.ResumeLayout(false);
            this.registerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseRentalSet databaseRentalSet;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private DatabaseRentalSetTableAdapters.RegisterTableAdapter registerTableAdapter;
        private DatabaseRentalSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton registerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.DataGridView registerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureWork;
    }
}