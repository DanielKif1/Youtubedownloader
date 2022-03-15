
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labeltitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAddresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnAudio = new System.Windows.Forms.RadioButton();
            this.radioBtnVideo = new System.Windows.Forms.RadioButton();
            this.btnTelecharger = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeltitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltitle.Location = new System.Drawing.Point(173, 20);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(326, 25);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Youtube MP3/MP4 Telecharger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Url addresse:";
            // 
            // txtBoxAddresse
            // 
            this.txtBoxAddresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddresse.Location = new System.Drawing.Point(174, 82);
            this.txtBoxAddresse.Multiline = true;
            this.txtBoxAddresse.Name = "txtBoxAddresse";
            this.txtBoxAddresse.Size = new System.Drawing.Size(355, 25);
            this.txtBoxAddresse.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(25, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Format a telecharger:";
            // 
            // radioBtnAudio
            // 
            this.radioBtnAudio.AutoSize = true;
            this.radioBtnAudio.Checked = true;
            this.radioBtnAudio.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAudio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnAudio.Location = new System.Drawing.Point(291, 140);
            this.radioBtnAudio.Name = "radioBtnAudio";
            this.radioBtnAudio.Size = new System.Drawing.Size(107, 22);
            this.radioBtnAudio.TabIndex = 4;
            this.radioBtnAudio.TabStop = true;
            this.radioBtnAudio.Text = "Audio/MP3";
            this.radioBtnAudio.UseVisualStyleBackColor = true;
            this.radioBtnAudio.CheckedChanged += new System.EventHandler(this.radioBtnAudio_CheckedChanged);
            // 
            // radioBtnVideo
            // 
            this.radioBtnVideo.AutoSize = true;
            this.radioBtnVideo.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnVideo.Location = new System.Drawing.Point(421, 142);
            this.radioBtnVideo.Name = "radioBtnVideo";
            this.radioBtnVideo.Size = new System.Drawing.Size(108, 22);
            this.radioBtnVideo.TabIndex = 5;
            this.radioBtnVideo.Text = "Video/MP4";
            this.radioBtnVideo.UseVisualStyleBackColor = true;
            this.radioBtnVideo.CheckedChanged += new System.EventHandler(this.radioBtnVideo_CheckedChanged);
            // 
            // btnTelecharger
            // 
            this.btnTelecharger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelecharger.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelecharger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelecharger.Location = new System.Drawing.Point(50, 267);
            this.btnTelecharger.Name = "btnTelecharger";
            this.btnTelecharger.Size = new System.Drawing.Size(218, 36);
            this.btnTelecharger.TabIndex = 7;
            this.btnTelecharger.Text = "Telecharger";
            this.btnTelecharger.UseVisualStyleBackColor = true;
            this.btnTelecharger.Click += new System.EventHandler(this.btnTelecharger_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimer.Location = new System.Drawing.Point(338, 267);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(218, 36);
            this.btnsupprimer.TabIndex = 8;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(462, 31);
            this.progressBar1.TabIndex = 9;
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpercentage.Location = new System.Drawing.Point(499, 205);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(58, 19);
            this.lblpercentage.TabIndex = 10;
            this.lblpercentage.Text = "label1";
            this.lblpercentage.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 338);
            this.Controls.Add(this.lblpercentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnTelecharger);
            this.Controls.Add(this.radioBtnVideo);
            this.Controls.Add(this.radioBtnAudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxAddresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telecharger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAddresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnAudio;
        private System.Windows.Forms.RadioButton radioBtnVideo;
        private System.Windows.Forms.Button btnTelecharger;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.Timer timer1;
    }
}

