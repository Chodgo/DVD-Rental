namespace Rental
{
    partial class Genres
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
            System.Windows.Forms.Label genre_idLabel;
            System.Windows.Forms.Label genreNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genres));
            this.databaseRentalSet = new Rental.DatabaseRentalSet();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter = new Rental.DatabaseRentalSetTableAdapters.GenresTableAdapter();
            this.tableAdapterManager = new Rental.DatabaseRentalSetTableAdapters.TableAdapterManager();
            this.genresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.genresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.genresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_idTextBox = new System.Windows.Forms.TextBox();
            this.genreNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            genre_idLabel = new System.Windows.Forms.Label();
            genreNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingNavigator)).BeginInit();
            this.genresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // genre_idLabel
            // 
            genre_idLabel.AutoSize = true;
            genre_idLabel.Location = new System.Drawing.Point(11, 80);
            genre_idLabel.Name = "genre_idLabel";
            genre_idLabel.Size = new System.Drawing.Size(53, 13);
            genre_idLabel.TabIndex = 2;
            genre_idLabel.Text = "ID жанра";
            // 
            // genreNameLabel
            // 
            genreNameLabel.AutoSize = true;
            genreNameLabel.Location = new System.Drawing.Point(11, 106);
            genreNameLabel.Name = "genreNameLabel";
            genreNameLabel.Size = new System.Drawing.Size(60, 13);
            genreNameLabel.TabIndex = 4;
            genreNameLabel.Text = "Название:";
            // 
            // databaseRentalSet
            // 
            this.databaseRentalSet.DataSetName = "DatabaseRentalSet";
            this.databaseRentalSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.databaseRentalSet;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DisksTableAdapter = null;
            this.tableAdapterManager.GenresTableAdapter = this.genresTableAdapter;
            this.tableAdapterManager.RegisterTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rental.DatabaseRentalSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // genresBindingNavigator
            // 
            this.genresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.genresBindingNavigator.BindingSource = this.genresBindingSource;
            this.genresBindingNavigator.CountItem = null;
            this.genresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.genresBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.genresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.genresBindingNavigatorSaveItem});
            this.genresBindingNavigator.Location = new System.Drawing.Point(75, 43);
            this.genresBindingNavigator.MoveFirstItem = null;
            this.genresBindingNavigator.MoveLastItem = null;
            this.genresBindingNavigator.MoveNextItem = null;
            this.genresBindingNavigator.MovePreviousItem = null;
            this.genresBindingNavigator.Name = "genresBindingNavigator";
            this.genresBindingNavigator.PositionItem = null;
            this.genresBindingNavigator.Size = new System.Drawing.Size(81, 25);
            this.genresBindingNavigator.TabIndex = 0;
            this.genresBindingNavigator.Text = "bindingNavigator1";
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
            // genresBindingNavigatorSaveItem
            // 
            this.genresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.genresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("genresBindingNavigatorSaveItem.Image")));
            this.genresBindingNavigatorSaveItem.Name = "genresBindingNavigatorSaveItem";
            this.genresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.genresBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.genresBindingNavigatorSaveItem.Click += new System.EventHandler(this.genresBindingNavigatorSaveItem_Click);
            // 
            // genresDataGridView
            // 
            this.genresDataGridView.AutoGenerateColumns = false;
            this.genresDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.genresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.genresDataGridView.DataSource = this.genresBindingSource;
            this.genresDataGridView.Location = new System.Drawing.Point(12, 135);
            this.genresDataGridView.Name = "genresDataGridView";
            this.genresDataGridView.RowHeadersVisible = false;
            this.genresDataGridView.Size = new System.Drawing.Size(203, 220);
            this.genresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Genre_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID жанра";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GenreName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // genre_idTextBox
            // 
            this.genre_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genresBindingSource, "Genre_id", true));
            this.genre_idTextBox.Location = new System.Drawing.Point(87, 77);
            this.genre_idTextBox.Name = "genre_idTextBox";
            this.genre_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.genre_idTextBox.TabIndex = 3;
            // 
            // genreNameTextBox
            // 
            this.genreNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genresBindingSource, "GenreName", true));
            this.genreNameTextBox.Location = new System.Drawing.Point(87, 103);
            this.genreNameTextBox.Name = "genreNameTextBox";
            this.genreNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreNameTextBox.TabIndex = 5;
            // 
            // pictureBack
            // 
            this.pictureBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBack.Image")));
            this.pictureBack.Location = new System.Drawing.Point(12, 28);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(45, 40);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBack.TabIndex = 11;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(323, 367);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(genre_idLabel);
            this.Controls.Add(this.genre_idTextBox);
            this.Controls.Add(genreNameLabel);
            this.Controls.Add(this.genreNameTextBox);
            this.Controls.Add(this.genresDataGridView);
            this.Controls.Add(this.genresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Genres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genres";
            this.Load += new System.EventHandler(this.Genres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseRentalSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingNavigator)).EndInit();
            this.genresBindingNavigator.ResumeLayout(false);
            this.genresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseRentalSet databaseRentalSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private DatabaseRentalSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private DatabaseRentalSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator genresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton genresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView genresDataGridView;
        private System.Windows.Forms.TextBox genre_idTextBox;
        private System.Windows.Forms.TextBox genreNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.PictureBox pictureBack;
    }
}