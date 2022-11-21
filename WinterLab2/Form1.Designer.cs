using System.ComponentModel;
using System.Windows.Forms;

namespace WinterLab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private GroupBox boxMath;

        private TextBox txtNumber;

        private Label lblNumber;

        private GroupBox boxInformation;

        private Button btnReset;

        private Button btnCalculate;

        private TextBox txtAnswer;

        private Label lblAnswer;

        private TextBox txtMultiplier;

        private Label lblMultiplier;

        private Button btnExit;

        private Button btnHide;

        private Button btnData;

        private Button btnPicture;

        private Label lblTopic;

        private PictureBox picImage;

        private Label lblDog;

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
            this.boxMath = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.boxInformation = new System.Windows.Forms.GroupBox();
            this.lblDog = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.boxMath.SuspendLayout();
            this.boxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // boxMath
            // 
            this.boxMath.Controls.Add(this.btnReset);
            this.boxMath.Controls.Add(this.btnCalculate);
            this.boxMath.Controls.Add(this.txtAnswer);
            this.boxMath.Controls.Add(this.lblAnswer);
            this.boxMath.Controls.Add(this.txtMultiplier);
            this.boxMath.Controls.Add(this.lblMultiplier);
            this.boxMath.Controls.Add(this.txtNumber);
            this.boxMath.Controls.Add(this.lblNumber);
            this.boxMath.Location = new System.Drawing.Point(13, 13);
            this.boxMath.Name = "boxMath";
            this.boxMath.Size = new System.Drawing.Size(230, 306);
            this.boxMath.TabIndex = 0;
            this.boxMath.TabStop = false;
            this.boxMath.Text = "Multiplier";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(122, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(18, 251);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 40);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Location = new System.Drawing.Point(102, 172);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 22);
            this.txtAnswer.TabIndex = 5;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(15, 175);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(54, 16);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer:";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(102, 94);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplier.TabIndex = 3;
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(15, 100);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(63, 16);
            this.lblMultiplier.TabIndex = 2;
            this.lblMultiplier.Text = "Multiplier:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(102, 44);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(15, 50);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(56, 16);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            // 
            // boxInformation
            // 
            this.boxInformation.Controls.Add(this.lblDog);
            this.boxInformation.Controls.Add(this.picImage);
            this.boxInformation.Controls.Add(this.lblTopic);
            this.boxInformation.Controls.Add(this.btnExit);
            this.boxInformation.Controls.Add(this.btnHide);
            this.boxInformation.Controls.Add(this.btnData);
            this.boxInformation.Controls.Add(this.btnPicture);
            this.boxInformation.Location = new System.Drawing.Point(249, 13);
            this.boxInformation.Name = "boxInformation";
            this.boxInformation.Size = new System.Drawing.Size(458, 306);
            this.boxInformation.TabIndex = 1;
            this.boxInformation.TabStop = false;
            this.boxInformation.Text = "Information";
            // 
            // lblDog
            // 
            this.lblDog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDog.Location = new System.Drawing.Point(20, 44);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(423, 201);
            this.lblDog.TabIndex = 6;
            this.lblDog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDog.Visible = false;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(199, 18);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(79, 16);
            this.lblTopic.TabIndex = 4;
            this.lblTopic.Text = "Ace the Dog";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(363, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(256, 251);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(80, 40);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(139, 251);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(80, 40);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(23, 251);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(80, 40);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picImage.Image = global::WinterLab2.Properties.Resources.IMG_0303;
            this.picImage.Location = new System.Drawing.Point(23, 44);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(420, 201);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 5;
            this.picImage.TabStop = false;
            this.picImage.Visible = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.boxInformation);
            this.Controls.Add(this.boxMath);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Lyndsey Winter";
            this.boxMath.ResumeLayout(false);
            this.boxMath.PerformLayout();
            this.boxInformation.ResumeLayout(false);
            this.boxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

