namespace Rental
{
    partial class Disks
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
            System.Windows.Forms.Label movieNameLabel;
            System.Windows.Forms.Label year_of_releaseLabel;
            System.Windows.Forms.Label genre_idLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label durationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disks));
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureLogU = new System.Windows.Forms.PictureBox();
            this.disksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.disksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseRentalSet = new Rental.DatabaseRentalSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.disksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.disksTableAdapter = new Rental.DatabaseRentalSetTableAdapters.DisksTableAdapter();
            this.tableAdapterManager = new Rental.DatabaseRentalSetTableAdapters.TableAdapterManager();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.year_of_releaseTextBox = new System.Windows.Forms.TextBox();
            this.genre_idTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.disksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butGeners = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButRental = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureCust = new System.Windows.Forms.PictureBox();
            this.ButCustomers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            movieNameLabel = new System.Windows.Forms.Label();
            year_of_releaseLabel = new System.Windows.Forms.Label();
            genre_idLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disksBindingNavigator)).BeginInit();
            this.disksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disksDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCust)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new System.Drawing.Point(133, 180);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new System.Drawing.Size(100, 13);
            movieNameLabel.TabIndex = 39;
            movieNameLabel.Text = "Название фильма";
            // 
            // year_of_releaseLabel
            // 
            year_of_releaseLabel.AutoSize = true;
            year_of_releaseLabel.Location = new System.Drawing.Point(133, 206);
            year_of_releaseLabel.Name = "year_of_releaseLabel";
            year_of_releaseLabel.Size = new System.Drawing.Size(71, 13);
            year_of_releaseLabel.TabIndex = 41;
            year_of_releaseLabel.Text = "Год выпуска";
            // 
            // genre_idLabel
            // 
            genre_idLabel.AutoSize = true;
            genre_idLabel.Location = new System.Drawing.Point(133, 232);
            genre_idLabel.Name = "genre_idLabel";
            genre_idLabel.Size = new System.Drawing.Size(53, 13);
            genre_idLabel.TabIndex = 43;
            genre_idLabel.Text = "ID жанра";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(133, 258);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(48, 13);
            ratingLabel.TabIndex = 45;
            ratingLabel.Text = "Рейтинг";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(133, 284);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(80, 13);
            durationLabel.TabIndex = 47;
            durationLabel.Text = "Длительность";
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(421, 17);
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
            this.pictureLogU.Location = new System.Drawing.Point(3, 161);
            this.pictureLogU.Name = "pictureLogU";
            this.pictureLogU.Size = new System.Drawing.Size(48, 48);
            this.pictureLogU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogU.TabIndex = 20;
            this.pictureLogU.TabStop = false;
            this.pictureLogU.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // disksBindingNavigator
            // 
            this.disksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disksBindingNavigator.BindingSource = this.disksBindingSource;
            this.disksBindingNavigator.CountItem = null;
            this.disksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disksBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.disksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.disksBindingNavigatorSaveItem});
            this.disksBindingNavigator.Location = new System.Drawing.Point(136, 114);
            this.disksBindingNavigator.MoveFirstItem = null;
            this.disksBindingNavigator.MoveLastItem = null;
            this.disksBindingNavigator.MoveNextItem = null;
            this.disksBindingNavigator.MovePreviousItem = null;
            this.disksBindingNavigator.Name = "disksBindingNavigator";
            this.disksBindingNavigator.PositionItem = null;
            this.disksBindingNavigator.Size = new System.Drawing.Size(81, 25);
            this.disksBindingNavigator.TabIndex = 21;
            this.disksBindingNavigator.Text = "bindingNavigator1";
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
            // disksBindingSource
            // 
            this.disksBindingSource.DataMember = "Disks";
            this.disksBindingSource.DataSource = this.databaseRentalSet;
            // 
            // databaseRentalSet
            // 
            this.databaseRentalSet.DataSetName = "DatabaseRentalSet";
            this.databaseRentalSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // disksBindingNavigatorSaveItem
            // 
            this.disksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disksBindingNavigatorSaveItem.Image")));
            this.disksBindingNavigatorSaveItem.Name = "disksBindingNavigatorSaveItem";
            this.disksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.disksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.disksBindingNavigatorSaveItem.Click += new System.EventHandler(this.disksBindingNavigatorSaveItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(239, 145);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 35;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(136, 142);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 36;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(1, 310);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.Size = new System.Drawing.Size(597, 188);
            this.resultDataGridView.TabIndex = 37;
            // 
            // disksTableAdapter
            // 
            this.disksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DisksTableAdapter = this.disksTableAdapter;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.RegisterTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rental.DatabaseRentalSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disksBindingSource, "MovieName", true));
            this.movieNameTextBox.Location = new System.Drawing.Point(239, 177);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.movieNameTextBox.TabIndex = 40;
            // 
            // year_of_releaseTextBox
            // 
            this.year_of_releaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disksBindingSource, "year of release", true));
            this.year_of_releaseTextBox.Location = new System.Drawing.Point(239, 203);
            this.year_of_releaseTextBox.Name = "year_of_releaseTextBox";
            this.year_of_releaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.year_of_releaseTextBox.TabIndex = 42;
            // 
            // genre_idTextBox
            // 
            this.genre_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disksBindingSource, "Genre_id", true));
            this.genre_idTextBox.Location = new System.Drawing.Point(239, 229);
            this.genre_idTextBox.Name = "genre_idTextBox";
            this.genre_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.genre_idTextBox.TabIndex = 44;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disksBindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(239, 255);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 46;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disksBindingSource, "duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(239, 281);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 48;
            // 
            // disksDataGridView
            // 
            this.disksDataGridView.AutoGenerateColumns = false;
            this.disksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.disksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.disksDataGridView.DataSource = this.disksBindingSource;
            this.disksDataGridView.Location = new System.Drawing.Point(-3, 307);
            this.disksDataGridView.Name = "disksDataGridView";
            this.disksDataGridView.RowHeadersVisible = false;
            this.disksDataGridView.Size = new System.Drawing.Size(605, 188);
            this.disksDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DiskID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID диска";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MovieName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название фильма";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "year of release";
            this.dataGridViewTextBoxColumn3.HeaderText = "Год выпуска";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genre_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID жанра";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn5.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "duration";
            this.dataGridViewTextBoxColumn6.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // butGeners
            // 
            this.butGeners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.butGeners.Location = new System.Drawing.Point(345, 227);
            this.butGeners.Name = "butGeners";
            this.butGeners.Size = new System.Drawing.Size(161, 23);
            this.butGeners.TabIndex = 49;
            this.butGeners.Text = "Перейти в таблицу жанров";
            this.butGeners.UseVisualStyleBackColor = false;
            this.butGeners.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.ButRental);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureCust);
            this.panel1.Controls.Add(this.ButCustomers);
            this.panel1.Controls.Add(this.pictureLogU);
            this.panel1.Location = new System.Drawing.Point(1, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 212);
            this.panel1.TabIndex = 50;
            // 
            // ButRental
            // 
            this.ButRental.Location = new System.Drawing.Point(62, 40);
            this.ButRental.Name = "ButRental";
            this.ButRental.Size = new System.Drawing.Size(61, 23);
            this.ButRental.TabIndex = 24;
            this.ButRental.Text = "Заказы";
            this.ButRental.UseVisualStyleBackColor = true;
            this.ButRental.Click += new System.EventHandler(this.ButRental_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureCust
            // 
            this.pictureCust.Image = ((System.Drawing.Image)(resources.GetObject("pictureCust.Image")));
            this.pictureCust.Location = new System.Drawing.Point(6, 70);
            this.pictureCust.Name = "pictureCust";
            this.pictureCust.Size = new System.Drawing.Size(50, 50);
            this.pictureCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCust.TabIndex = 22;
            this.pictureCust.TabStop = false;
            // 
            // ButCustomers
            // 
            this.ButCustomers.Location = new System.Drawing.Point(60, 92);
            this.ButCustomers.Name = "ButCustomers";
            this.ButCustomers.Size = new System.Drawing.Size(63, 23);
            this.ButCustomers.TabIndex = 21;
            this.ButCustomers.Text = "Клиенты";
            this.ButCustomers.UseVisualStyleBackColor = true;
            this.ButCustomers.Click += new System.EventHandler(this.ButCustomers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(223)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.pictureClose);
            this.panel2.Location = new System.Drawing.Point(122, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 99);
            this.panel2.TabIndex = 51;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 52;
            this.pictureBox5.TabStop = false;
            // 
            // Disks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butGeners);
            this.Controls.Add(this.disksDataGridView);
            this.Controls.Add(movieNameLabel);
            this.Controls.Add(this.movieNameTextBox);
            this.Controls.Add(year_of_releaseLabel);
            this.Controls.Add(this.year_of_releaseTextBox);
            this.Controls.Add(genre_idLabel);
            this.Controls.Add(this.genre_idTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.disksBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Disks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disks";
            this.Load += new System.EventHandler(this.Disks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disksBindingNavigator)).EndInit();
            this.disksBindingNavigator.ResumeLayout(false);
            this.disksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disksDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCust)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureLogU;
        private DatabaseRentalSet databaseRentalSet;
        private System.Windows.Forms.BindingSource disksBindingSource;
        private DatabaseRentalSetTableAdapters.DisksTableAdapter disksTableAdapter;
        private DatabaseRentalSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton disksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.TextBox year_of_releaseTextBox;
        private System.Windows.Forms.TextBox genre_idTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.DataGridView disksDataGridView;
        private System.Windows.Forms.Button butGeners;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButCustomers;
        private System.Windows.Forms.PictureBox pictureCust;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButRental;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}