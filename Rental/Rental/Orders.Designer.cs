namespace Rental
{
    partial class Orders
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
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label diskIDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label coastLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureLogU = new System.Windows.Forms.PictureBox();
            this.rentalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rentalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rentalDataGridView = new System.Windows.Forms.DataGridView();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.diskIDTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.coastTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ButDisks = new System.Windows.Forms.Button();
            this.pictureDisks = new System.Windows.Forms.PictureBox();
            this.ButCustomers = new System.Windows.Forms.Button();
            this.pictureCust = new System.Windows.Forms.PictureBox();
            this.pictureRent = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseRentalSet = new Rental.DatabaseRentalSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalTableAdapter = new Rental.DatabaseRentalSetTableAdapters.RentalTableAdapter();
            this.tableAdapterManager = new Rental.DatabaseRentalSetTableAdapters.TableAdapterManager();
            orderIDLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            diskIDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            coastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingNavigator)).BeginInit();
            this.rentalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(132, 171);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(58, 13);
            orderIDLabel.TabIndex = 38;
            orderIDLabel.Text = "ID Заказа";
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(132, 197);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(62, 13);
            customer_IDLabel.TabIndex = 40;
            customer_IDLabel.Text = "ID клиента";
            // 
            // diskIDLabel
            // 
            diskIDLabel.AutoSize = true;
            diskIDLabel.Location = new System.Drawing.Point(132, 223);
            diskIDLabel.Name = "diskIDLabel";
            diskIDLabel.Size = new System.Drawing.Size(54, 13);
            diskIDLabel.TabIndex = 42;
            diskIDLabel.Text = "ID Диска";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(132, 250);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(71, 13);
            startDateLabel.TabIndex = 44;
            startDateLabel.Text = "Дата начала";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(132, 276);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(66, 13);
            endDateLabel.TabIndex = 46;
            endDateLabel.Text = "Дата конца";
            // 
            // coastLabel
            // 
            coastLabel.AutoSize = true;
            coastLabel.Location = new System.Drawing.Point(132, 301);
            coastLabel.Name = "coastLabel";
            coastLabel.Size = new System.Drawing.Size(62, 13);
            coastLabel.TabIndex = 48;
            coastLabel.Text = "Стоимость";
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(447, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(45, 40);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 12;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureLogU
            // 
            this.pictureLogU.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogU.Image")));
            this.pictureLogU.Location = new System.Drawing.Point(7, 194);
            this.pictureLogU.Name = "pictureLogU";
            this.pictureLogU.Size = new System.Drawing.Size(48, 48);
            this.pictureLogU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogU.TabIndex = 20;
            this.pictureLogU.TabStop = false;
            this.pictureLogU.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // rentalBindingNavigator
            // 
            this.rentalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rentalBindingNavigator.BindingSource = this.rentalBindingSource;
            this.rentalBindingNavigator.CountItem = null;
            this.rentalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rentalBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.rentalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rentalBindingNavigatorSaveItem});
            this.rentalBindingNavigator.Location = new System.Drawing.Point(206, 111);
            this.rentalBindingNavigator.MoveFirstItem = null;
            this.rentalBindingNavigator.MoveLastItem = null;
            this.rentalBindingNavigator.MoveNextItem = null;
            this.rentalBindingNavigator.MovePreviousItem = null;
            this.rentalBindingNavigator.Name = "rentalBindingNavigator";
            this.rentalBindingNavigator.PositionItem = null;
            this.rentalBindingNavigator.Size = new System.Drawing.Size(81, 25);
            this.rentalBindingNavigator.TabIndex = 21;
            this.rentalBindingNavigator.Text = "bindingNavigator1";
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
            // rentalBindingNavigatorSaveItem
            // 
            this.rentalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rentalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rentalBindingNavigatorSaveItem.Image")));
            this.rentalBindingNavigatorSaveItem.Name = "rentalBindingNavigatorSaveItem";
            this.rentalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rentalBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rentalBindingNavigatorSaveItem.Click += new System.EventHandler(this.rentalBindingNavigatorSaveItem_Click);
            // 
            // rentalDataGridView
            // 
            this.rentalDataGridView.AutoGenerateColumns = false;
            this.rentalDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.rentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rentalDataGridView.DataSource = this.rentalBindingSource;
            this.rentalDataGridView.Location = new System.Drawing.Point(12, 341);
            this.rentalDataGridView.Name = "rentalDataGridView";
            this.rentalDataGridView.RowHeadersVisible = false;
            this.rentalDataGridView.Size = new System.Drawing.Size(584, 158);
            this.rentalDataGridView.TabIndex = 21;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(10, 341);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.Size = new System.Drawing.Size(584, 158);
            this.resultDataGridView.TabIndex = 38;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(206, 168);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderIDTextBox.TabIndex = 39;
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "Customer_ID", true));
            this.customer_IDTextBox.Location = new System.Drawing.Point(206, 194);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customer_IDTextBox.TabIndex = 41;
            // 
            // diskIDTextBox
            // 
            this.diskIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "DiskID", true));
            this.diskIDTextBox.Location = new System.Drawing.Point(206, 220);
            this.diskIDTextBox.Name = "diskIDTextBox";
            this.diskIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.diskIDTextBox.TabIndex = 43;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentalBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(206, 246);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 45;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentalBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(206, 272);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 47;
            // 
            // coastTextBox
            // 
            this.coastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "coast", true));
            this.coastTextBox.Location = new System.Drawing.Point(206, 298);
            this.coastTextBox.Name = "coastTextBox";
            this.coastTextBox.Size = new System.Drawing.Size(200, 20);
            this.coastTextBox.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Памятка\r\n1 День 30р";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(312, 139);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 52;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(206, 142);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 51;
            // 
            // ButDisks
            // 
            this.ButDisks.Location = new System.Drawing.Point(61, 30);
            this.ButDisks.Name = "ButDisks";
            this.ButDisks.Size = new System.Drawing.Size(60, 23);
            this.ButDisks.TabIndex = 53;
            this.ButDisks.Text = "Диски";
            this.ButDisks.UseVisualStyleBackColor = true;
            this.ButDisks.Click += new System.EventHandler(this.ButDisks_Click);
            // 
            // pictureDisks
            // 
            this.pictureDisks.Image = ((System.Drawing.Image)(resources.GetObject("pictureDisks.Image")));
            this.pictureDisks.Location = new System.Drawing.Point(5, 15);
            this.pictureDisks.Name = "pictureDisks";
            this.pictureDisks.Size = new System.Drawing.Size(45, 50);
            this.pictureDisks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDisks.TabIndex = 57;
            this.pictureDisks.TabStop = false;
            // 
            // ButCustomers
            // 
            this.ButCustomers.Location = new System.Drawing.Point(61, 89);
            this.ButCustomers.Name = "ButCustomers";
            this.ButCustomers.Size = new System.Drawing.Size(60, 23);
            this.ButCustomers.TabIndex = 54;
            this.ButCustomers.Text = "Клиенты";
            this.ButCustomers.UseVisualStyleBackColor = true;
            this.ButCustomers.Click += new System.EventHandler(this.ButCustomers_Click);
            // 
            // pictureCust
            // 
            this.pictureCust.Image = ((System.Drawing.Image)(resources.GetObject("pictureCust.Image")));
            this.pictureCust.Location = new System.Drawing.Point(5, 74);
            this.pictureCust.Name = "pictureCust";
            this.pictureCust.Size = new System.Drawing.Size(45, 50);
            this.pictureCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCust.TabIndex = 56;
            this.pictureCust.TabStop = false;
            // 
            // pictureRent
            // 
            this.pictureRent.Image = ((System.Drawing.Image)(resources.GetObject("pictureRent.Image")));
            this.pictureRent.Location = new System.Drawing.Point(12, 12);
            this.pictureRent.Name = "pictureRent";
            this.pictureRent.Size = new System.Drawing.Size(48, 48);
            this.pictureRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureRent.TabIndex = 55;
            this.pictureRent.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(223)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Location = new System.Drawing.Point(122, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 85);
            this.panel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.ButCustomers);
            this.panel2.Controls.Add(this.pictureLogU);
            this.panel2.Controls.Add(this.ButDisks);
            this.panel2.Controls.Add(this.pictureCust);
            this.panel2.Controls.Add(this.pictureDisks);
            this.panel2.Location = new System.Drawing.Point(5, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 253);
            this.panel2.TabIndex = 59;
            // 
            // rentalBindingSource
            // 
            this.rentalBindingSource.DataMember = "Rental";
            this.rentalBindingSource.DataSource = this.databaseRentalSet;
            // 
            // databaseRentalSet
            // 
            this.databaseRentalSet.DataSetName = "DatabaseRentalSet";
            this.databaseRentalSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID клиента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiskID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID диска";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата конца";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "coast";
            this.dataGridViewTextBoxColumn6.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // rentalTableAdapter
            // 
            this.rentalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DisksTableAdapter = null;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.RegisterTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = this.rentalTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rental.DatabaseRentalSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(616, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureRent);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(diskIDLabel);
            this.Controls.Add(this.diskIDTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(coastLabel);
            this.Controls.Add(this.coastTextBox);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.rentalDataGridView);
            this.Controls.Add(this.rentalBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingNavigator)).EndInit();
            this.rentalBindingNavigator.ResumeLayout(false);
            this.rentalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureLogU;
        private DatabaseRentalSet databaseRentalSet;
        private System.Windows.Forms.BindingSource rentalBindingSource;
        private DatabaseRentalSetTableAdapters.RentalTableAdapter rentalTableAdapter;
        private DatabaseRentalSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rentalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton rentalBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rentalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.TextBox diskIDTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox coastTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button ButDisks;
        private System.Windows.Forms.PictureBox pictureDisks;
        private System.Windows.Forms.Button ButCustomers;
        private System.Windows.Forms.PictureBox pictureCust;
        private System.Windows.Forms.PictureBox pictureRent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}