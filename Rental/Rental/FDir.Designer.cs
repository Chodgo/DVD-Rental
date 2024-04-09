namespace Rental
{
    partial class FDir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDir));
            this.ButDisks = new System.Windows.Forms.Button();
            this.ButRental = new System.Windows.Forms.Button();
            this.ButCustomers = new System.Windows.Forms.Button();
            this.ButWorkers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureRent = new System.Windows.Forms.PictureBox();
            this.pictureCust = new System.Windows.Forms.PictureBox();
            this.pictureWork = new System.Windows.Forms.PictureBox();
            this.pictureLogU = new System.Windows.Forms.PictureBox();
            this.pictureDisk = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisk)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ButDisks
            // 
            this.ButDisks.Location = new System.Drawing.Point(66, 160);
            this.ButDisks.Name = "ButDisks";
            this.ButDisks.Size = new System.Drawing.Size(75, 23);
            this.ButDisks.TabIndex = 0;
            this.ButDisks.Text = "Диски";
            this.ButDisks.UseVisualStyleBackColor = true;
            this.ButDisks.Click += new System.EventHandler(this.ButDisks_Click);
            // 
            // ButRental
            // 
            this.ButRental.Location = new System.Drawing.Point(66, 216);
            this.ButRental.Name = "ButRental";
            this.ButRental.Size = new System.Drawing.Size(75, 23);
            this.ButRental.TabIndex = 1;
            this.ButRental.Text = "Заказы";
            this.ButRental.UseVisualStyleBackColor = true;
            this.ButRental.Click += new System.EventHandler(this.ButRental_Click);
            // 
            // ButCustomers
            // 
            this.ButCustomers.Location = new System.Drawing.Point(66, 272);
            this.ButCustomers.Name = "ButCustomers";
            this.ButCustomers.Size = new System.Drawing.Size(75, 23);
            this.ButCustomers.TabIndex = 2;
            this.ButCustomers.Text = "Клиенты";
            this.ButCustomers.UseVisualStyleBackColor = true;
            this.ButCustomers.Click += new System.EventHandler(this.ButCustomers_Click);
            // 
            // ButWorkers
            // 
            this.ButWorkers.Location = new System.Drawing.Point(66, 331);
            this.ButWorkers.Name = "ButWorkers";
            this.ButWorkers.Size = new System.Drawing.Size(75, 23);
            this.ButWorkers.TabIndex = 3;
            this.ButWorkers.Text = "Работники";
            this.ButWorkers.UseVisualStyleBackColor = true;
            this.ButWorkers.Click += new System.EventHandler(this.butWorkers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вы успешно вошли в систему как директор.";
            // 
            // pictureRent
            // 
            this.pictureRent.Image = ((System.Drawing.Image)(resources.GetObject("pictureRent.Image")));
            this.pictureRent.Location = new System.Drawing.Point(10, 201);
            this.pictureRent.Name = "pictureRent";
            this.pictureRent.Size = new System.Drawing.Size(50, 50);
            this.pictureRent.TabIndex = 6;
            this.pictureRent.TabStop = false;
            // 
            // pictureCust
            // 
            this.pictureCust.Image = ((System.Drawing.Image)(resources.GetObject("pictureCust.Image")));
            this.pictureCust.Location = new System.Drawing.Point(10, 257);
            this.pictureCust.Name = "pictureCust";
            this.pictureCust.Size = new System.Drawing.Size(50, 50);
            this.pictureCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCust.TabIndex = 7;
            this.pictureCust.TabStop = false;
            // 
            // pictureWork
            // 
            this.pictureWork.Image = ((System.Drawing.Image)(resources.GetObject("pictureWork.Image")));
            this.pictureWork.Location = new System.Drawing.Point(10, 316);
            this.pictureWork.Name = "pictureWork";
            this.pictureWork.Size = new System.Drawing.Size(50, 50);
            this.pictureWork.TabIndex = 8;
            this.pictureWork.TabStop = false;
            // 
            // pictureLogU
            // 
            this.pictureLogU.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogU.Image")));
            this.pictureLogU.Location = new System.Drawing.Point(48, 401);
            this.pictureLogU.Name = "pictureLogU";
            this.pictureLogU.Size = new System.Drawing.Size(48, 48);
            this.pictureLogU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogU.TabIndex = 9;
            this.pictureLogU.TabStop = false;
            this.pictureLogU.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureDisk
            // 
            this.pictureDisk.Image = ((System.Drawing.Image)(resources.GetObject("pictureDisk.Image")));
            this.pictureDisk.Location = new System.Drawing.Point(10, 145);
            this.pictureDisk.Name = "pictureDisk";
            this.pictureDisk.Size = new System.Drawing.Size(50, 50);
            this.pictureDisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDisk.TabIndex = 10;
            this.pictureDisk.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ButDisks);
            this.panel1.Controls.Add(this.pictureDisk);
            this.panel1.Controls.Add(this.ButRental);
            this.panel1.Controls.Add(this.pictureLogU);
            this.panel1.Controls.Add(this.ButCustomers);
            this.panel1.Controls.Add(this.pictureWork);
            this.panel1.Controls.Add(this.ButWorkers);
            this.panel1.Controls.Add(this.pictureCust);
            this.panel1.Controls.Add(this.pictureRent);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 501);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 112);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(223)))), ((int)(((byte)(189)))));
            this.panel3.Controls.Add(this.pictureClose);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(151, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 103);
            this.panel3.TabIndex = 12;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(383, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(45, 40);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 13;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // FDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButDisks;
        private System.Windows.Forms.Button ButRental;
        private System.Windows.Forms.Button ButCustomers;
        private System.Windows.Forms.Button ButWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureRent;
        private System.Windows.Forms.PictureBox pictureCust;
        private System.Windows.Forms.PictureBox pictureWork;
        private System.Windows.Forms.PictureBox pictureLogU;
        private System.Windows.Forms.PictureBox pictureDisk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureClose;
    }
}