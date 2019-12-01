namespace CameraControllWindowsFormCSharp
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimizedIcon = new System.Windows.Forms.Button();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.lblCameraList = new System.Windows.Forms.Label();
            this.btnGetCameraInfo = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 30);
            this.lblTitle.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(770, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "×";
            this.btnClose.UseCompatibleTextRendering = true;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // btnMinimizedIcon
            // 
            this.btnMinimizedIcon.BackColor = System.Drawing.Color.Black;
            this.btnMinimizedIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizedIcon.ForeColor = System.Drawing.Color.White;
            this.btnMinimizedIcon.Location = new System.Drawing.Point(739, 0);
            this.btnMinimizedIcon.Name = "btnMinimizedIcon";
            this.btnMinimizedIcon.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizedIcon.TabIndex = 2;
            this.btnMinimizedIcon.TabStop = false;
            this.btnMinimizedIcon.Text = "-";
            this.btnMinimizedIcon.UseVisualStyleBackColor = false;
            this.btnMinimizedIcon.Click += new System.EventHandler(this.OnClickBtnMinimizedIcon);
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(12, 69);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(314, 28);
            this.cmbCamera.TabIndex = 3;
            // 
            // lblCameraList
            // 
            this.lblCameraList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCameraList.Location = new System.Drawing.Point(12, 39);
            this.lblCameraList.Name = "lblCameraList";
            this.lblCameraList.Size = new System.Drawing.Size(174, 27);
            this.lblCameraList.TabIndex = 4;
            this.lblCameraList.Text = "Camera List";
            // 
            // btnGetCameraInfo
            // 
            this.btnGetCameraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCameraInfo.Location = new System.Drawing.Point(332, 64);
            this.btnGetCameraInfo.Name = "btnGetCameraInfo";
            this.btnGetCameraInfo.Size = new System.Drawing.Size(72, 37);
            this.btnGetCameraInfo.TabIndex = 4;
            this.btnGetCameraInfo.Text = "Get";
            this.btnGetCameraInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 112);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 476);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(632, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnClickBtnStart);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(713, 64);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 37);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.OnClickBtnStop);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnGetCameraInfo);
            this.Controls.Add(this.lblCameraList);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.btnMinimizedIcon);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizedIcon;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Label lblCameraList;
        private System.Windows.Forms.Button btnGetCameraInfo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

