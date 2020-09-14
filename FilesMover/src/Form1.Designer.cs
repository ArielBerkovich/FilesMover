namespace FilesMover
{
    partial class FilesMoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesMoverForm));
            this.presCombobox = new System.Windows.Forms.ComboBox();
            this.docsComboBox = new System.Windows.Forms.ComboBox();
            this.movPresButton = new System.Windows.Forms.Button();
            this.moveDocButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.diskOnKeyStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.movePdfButton = new System.Windows.Forms.Button();
            this.pdfComboBox = new System.Windows.Forms.ComboBox();
            this.openDiskOnKeyButton = new System.Windows.Forms.Button();
            this.mp4Icon = new System.Windows.Forms.PictureBox();
            this.mp4ComboBox = new System.Windows.Forms.ComboBox();
            this.mp4Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp4Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // presCombobox
            // 
            this.presCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.presCombobox.FormattingEnabled = true;
            this.presCombobox.Location = new System.Drawing.Point(229, 186);
            this.presCombobox.Name = "presCombobox";
            this.presCombobox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.presCombobox.Size = new System.Drawing.Size(506, 38);
            this.presCombobox.TabIndex = 0;
            // 
            // docsComboBox
            // 
            this.docsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.docsComboBox.FormattingEnabled = true;
            this.docsComboBox.Location = new System.Drawing.Point(229, 301);
            this.docsComboBox.Name = "docsComboBox";
            this.docsComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.docsComboBox.Size = new System.Drawing.Size(506, 38);
            this.docsComboBox.TabIndex = 1;
            // 
            // movPresButton
            // 
            this.movPresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.movPresButton.Location = new System.Drawing.Point(48, 178);
            this.movPresButton.Name = "movPresButton";
            this.movPresButton.Size = new System.Drawing.Size(158, 60);
            this.movPresButton.TabIndex = 2;
            this.movPresButton.Text = "העבר מצגת";
            this.movPresButton.UseVisualStyleBackColor = true;
            this.movPresButton.Click += new System.EventHandler(this.MovePresButton_Click);
            // 
            // moveDocButton
            // 
            this.moveDocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.moveDocButton.Location = new System.Drawing.Point(48, 293);
            this.moveDocButton.Name = "moveDocButton";
            this.moveDocButton.Size = new System.Drawing.Size(158, 60);
            this.moveDocButton.TabIndex = 3;
            this.moveDocButton.Text = "העבר מסמך";
            this.moveDocButton.UseVisualStyleBackColor = true;
            this.moveDocButton.Click += new System.EventHandler(this.MoveDocButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(754, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(754, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(332, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "מעביר הקבצים";
            // 
            // diskOnKeyStatusLabel
            // 
            this.diskOnKeyStatusLabel.AutoSize = true;
            this.diskOnKeyStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.diskOnKeyStatusLabel.Location = new System.Drawing.Point(351, 101);
            this.diskOnKeyStatusLabel.Name = "diskOnKeyStatusLabel";
            this.diskOnKeyStatusLabel.Size = new System.Drawing.Size(105, 29);
            this.diskOnKeyStatusLabel.TabIndex = 7;
            this.diskOnKeyStatusLabel.Text = "לא מחובר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(462, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = ":דיסק און קי";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(229, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 168);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(754, 381);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // movePdfButton
            // 
            this.movePdfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.movePdfButton.Location = new System.Drawing.Point(48, 408);
            this.movePdfButton.Name = "movePdfButton";
            this.movePdfButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.movePdfButton.Size = new System.Drawing.Size(158, 60);
            this.movePdfButton.TabIndex = 11;
            this.movePdfButton.Text = "pdf העבר";
            this.movePdfButton.UseVisualStyleBackColor = true;
            this.movePdfButton.Click += new System.EventHandler(this.MovePdfButton_Click);
            // 
            // pdfComboBox
            // 
            this.pdfComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pdfComboBox.FormattingEnabled = true;
            this.pdfComboBox.Location = new System.Drawing.Point(229, 416);
            this.pdfComboBox.Name = "pdfComboBox";
            this.pdfComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pdfComboBox.Size = new System.Drawing.Size(506, 38);
            this.pdfComboBox.TabIndex = 10;
            // 
            // openDiskOnKeyButton
            // 
            this.openDiskOnKeyButton.Enabled = false;
            this.openDiskOnKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.openDiskOnKeyButton.Location = new System.Drawing.Point(340, 639);
            this.openDiskOnKeyButton.Name = "openDiskOnKeyButton";
            this.openDiskOnKeyButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openDiskOnKeyButton.Size = new System.Drawing.Size(185, 60);
            this.openDiskOnKeyButton.TabIndex = 13;
            this.openDiskOnKeyButton.Text = "פתח דיסק און קי";
            this.openDiskOnKeyButton.UseVisualStyleBackColor = true;
            this.openDiskOnKeyButton.Click += new System.EventHandler(this.openDiskOnKeyButton_Click);
            // 
            // mp4Icon
            // 
            this.mp4Icon.Image = ((System.Drawing.Image)(resources.GetObject("mp4Icon.Image")));
            this.mp4Icon.Location = new System.Drawing.Point(754, 495);
            this.mp4Icon.Name = "mp4Icon";
            this.mp4Icon.Size = new System.Drawing.Size(100, 87);
            this.mp4Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mp4Icon.TabIndex = 16;
            this.mp4Icon.TabStop = false;
            // 
            // mp4ComboBox
            // 
            this.mp4ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mp4ComboBox.FormattingEnabled = true;
            this.mp4ComboBox.Location = new System.Drawing.Point(229, 530);
            this.mp4ComboBox.Name = "mp4ComboBox";
            this.mp4ComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mp4ComboBox.Size = new System.Drawing.Size(506, 38);
            this.mp4ComboBox.TabIndex = 15;
            // 
            // mp4Button
            // 
            this.mp4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mp4Button.Location = new System.Drawing.Point(48, 522);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mp4Button.Size = new System.Drawing.Size(158, 60);
            this.mp4Button.TabIndex = 17;
            this.mp4Button.Text = "mp4 העבר";
            this.mp4Button.UseVisualStyleBackColor = true;
            this.mp4Button.Click += new System.EventHandler(this.MoveMp4Button_Click);
            // 
            // FilesMoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 711);
            this.Controls.Add(this.mp4Button);
            this.Controls.Add(this.mp4Icon);
            this.Controls.Add(this.mp4ComboBox);
            this.Controls.Add(this.openDiskOnKeyButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.movePdfButton);
            this.Controls.Add(this.pdfComboBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diskOnKeyStatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.moveDocButton);
            this.Controls.Add(this.movPresButton);
            this.Controls.Add(this.docsComboBox);
            this.Controls.Add(this.presCombobox);
            this.Name = "FilesMoverForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FilesMover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp4Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox presCombobox;
        private System.Windows.Forms.ComboBox docsComboBox;
        private System.Windows.Forms.Button movPresButton;
        private System.Windows.Forms.Button moveDocButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label diskOnKeyStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button movePdfButton;
        private System.Windows.Forms.ComboBox pdfComboBox;
        private System.Windows.Forms.Button openDiskOnKeyButton;
        private System.Windows.Forms.PictureBox mp4Icon;
        private System.Windows.Forms.ComboBox mp4ComboBox;
        private System.Windows.Forms.Button mp4Button;
    }
}

