﻿namespace Medication_Tracker
{
    partial class AddMedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblroute = new System.Windows.Forms.Label();
            this.lblDose = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnSaveMed = new System.Windows.Forms.Button();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.dtpMedTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(239, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(294, 38);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Ibuprophen Tylenol";
            // 
            // lblroute
            // 
            this.lblroute.AutoSize = true;
            this.lblroute.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroute.Location = new System.Drawing.Point(84, 160);
            this.lblroute.Name = "lblroute";
            this.lblroute.Size = new System.Drawing.Size(113, 38);
            this.lblroute.TabIndex = 20;
            this.lblroute.Text = "Route:";
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDose.Location = new System.Drawing.Point(94, 94);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(103, 38);
            this.lblDose.TabIndex = 21;
            this.lblDose.Text = "Dose:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(94, 227);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(98, 38);
            this.lbltime.TabIndex = 24;
            this.lbltime.Text = "Time:";
            // 
            // btnSaveMed
            // 
            this.btnSaveMed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMed.Location = new System.Drawing.Point(202, 308);
            this.btnSaveMed.Name = "btnSaveMed";
            this.btnSaveMed.Size = new System.Drawing.Size(166, 45);
            this.btnSaveMed.TabIndex = 25;
            this.btnSaveMed.Text = "Save";
            this.btnSaveMed.UseVisualStyleBackColor = false;
            this.btnSaveMed.Click += new System.EventHandler(this.BtnSaveMed_Click);
            // 
            // txtDose
            // 
            this.txtDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDose.Location = new System.Drawing.Point(220, 91);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(375, 45);
            this.txtDose.TabIndex = 27;
            // 
            // txtRoute
            // 
            this.txtRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtRoute.Location = new System.Drawing.Point(220, 160);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(375, 45);
            this.txtRoute.TabIndex = 28;
            // 
            // dtpMedTime
            // 
            this.dtpMedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMedTime.Location = new System.Drawing.Point(220, 227);
            this.dtpMedTime.Name = "dtpMedTime";
            this.dtpMedTime.ShowUpDown = true;
            this.dtpMedTime.Size = new System.Drawing.Size(219, 45);
            this.dtpMedTime.TabIndex = 29;
            // 
            // AddMedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 375);
            this.Controls.Add(this.dtpMedTime);
            this.Controls.Add(this.txtRoute);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.btnSaveMed);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblDose);
            this.Controls.Add(this.lblroute);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMedForm";
            this.Text = "Add Medications";
            this.Load += new System.EventHandler(this.AddMedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblroute;
        private System.Windows.Forms.Label lblDose;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btnSaveMed;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.DateTimePicker dtpMedTime;
    }
}