namespace Healt_Declaration_Form
{
<<<<<<< HEAD
    partial class QRCodeScanner
=======
    partial class CodeScanner
>>>>>>> 0b894a91089cbfc687320cff6baa1bcaf18ee110
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
<<<<<<< HEAD
            this.Startbtn = new System.Windows.Forms.Button();
            this.CameraBox = new System.Windows.Forms.ComboBox();
            this.ScannerBox = new System.Windows.Forms.PictureBox();
            this.DecodeBox = new System.Windows.Forms.RichTextBox();
            this.CameraLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(150, 313);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 23);
            this.Startbtn.TabIndex = 0;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // CameraBox
            // 
            this.CameraBox.FormattingEnabled = true;
            this.CameraBox.Location = new System.Drawing.Point(87, 47);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(243, 23);
            this.CameraBox.TabIndex = 1;
            // 
            // ScannerBox
            // 
            this.ScannerBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScannerBox.Location = new System.Drawing.Point(87, 90);
            this.ScannerBox.Name = "ScannerBox";
            this.ScannerBox.Size = new System.Drawing.Size(243, 217);
            this.ScannerBox.TabIndex = 2;
            this.ScannerBox.TabStop = false;
            // 
            // DecodeBox
            // 
            this.DecodeBox.Location = new System.Drawing.Point(369, 117);
            this.DecodeBox.Name = "DecodeBox";
            this.DecodeBox.Size = new System.Drawing.Size(206, 134);
            this.DecodeBox.TabIndex = 3;
            this.DecodeBox.Text = "";
            // 
            // CameraLabel
            // 
            this.CameraLabel.AutoSize = true;
            this.CameraLabel.Location = new System.Drawing.Point(33, 50);
            this.CameraLabel.Name = "CameraLabel";
            this.CameraLabel.Size = new System.Drawing.Size(48, 15);
            this.CameraLabel.TabIndex = 4;
            this.CameraLabel.Text = "Camera";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(435, 273);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // QRCodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 373);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CameraLabel);
            this.Controls.Add(this.DecodeBox);
            this.Controls.Add(this.ScannerBox);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.Startbtn);
            this.Name = "QRCodeScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRCodeScanner_FormClosing);
            this.Load += new System.EventHandler(this.QRCodeScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox)).EndInit();
=======
            this.CameraBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScannerBox1 = new System.Windows.Forms.PictureBox();
            this.strbtn = new System.Windows.Forms.Button();
            this.readbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DecodedText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraBox1
            // 
            this.CameraBox1.FormattingEnabled = true;
            this.CameraBox1.Location = new System.Drawing.Point(137, 38);
            this.CameraBox1.Name = "CameraBox1";
            this.CameraBox1.Size = new System.Drawing.Size(257, 23);
            this.CameraBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // ScannerBox1
            // 
            this.ScannerBox1.Location = new System.Drawing.Point(83, 83);
            this.ScannerBox1.Name = "ScannerBox1";
            this.ScannerBox1.Size = new System.Drawing.Size(349, 303);
            this.ScannerBox1.TabIndex = 2;
            this.ScannerBox1.TabStop = false;
            // 
            // strbtn
            // 
            this.strbtn.Location = new System.Drawing.Point(216, 392);
            this.strbtn.Name = "strbtn";
            this.strbtn.Size = new System.Drawing.Size(75, 23);
            this.strbtn.TabIndex = 3;
            this.strbtn.Text = "Start";
            this.strbtn.UseVisualStyleBackColor = true;
            this.strbtn.Click += new System.EventHandler(this.strbtn_Click);
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(216, 421);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(75, 23);
            this.readbtn.TabIndex = 4;
            this.readbtn.Text = "Read";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DecodedText
            // 
            this.DecodedText.Location = new System.Drawing.Point(83, 463);
            this.DecodedText.Name = "DecodedText";
            this.DecodedText.Size = new System.Drawing.Size(349, 134);
            this.DecodedText.TabIndex = 5;
            this.DecodedText.Text = "";
            // 
            // CodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 636);
            this.Controls.Add(this.DecodedText);
            this.Controls.Add(this.readbtn);
            this.Controls.Add(this.strbtn);
            this.Controls.Add(this.ScannerBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CameraBox1);
            this.Name = "CodeScanner";
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeScanner_FormClosing);
            this.Load += new System.EventHandler(this.CodeScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox1)).EndInit();
>>>>>>> 0b894a91089cbfc687320cff6baa1bcaf18ee110
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private Button Startbtn;
        private ComboBox CameraBox;
        private PictureBox ScannerBox;
        private RichTextBox DecodeBox;
        private Label CameraLabel;
        private Button SaveBtn;
        private System.Windows.Forms.Timer Timer;
=======
        private ComboBox CameraBox1;
        private Label label1;
        private PictureBox ScannerBox1;
        private Button strbtn;
        private Button readbtn;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox DecodedText;
>>>>>>> 0b894a91089cbfc687320cff6baa1bcaf18ee110
    }
}