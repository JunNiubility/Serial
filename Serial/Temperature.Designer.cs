﻿
namespace Serial
{
    partial class Temperature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperature));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.datenow = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.temp_tbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tempnow = new System.Windows.Forms.Label();
            this.timenow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.datenow);
            this.groupBox1.Controls.Add(this.time_lbl);
            this.groupBox1.Controls.Add(this.temp_tbx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tempnow);
            this.groupBox1.Controls.Add(this.timenow);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据面板";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(78, 32);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(74, 17);
            this.datelbl.TabIndex = 6;
            this.datelbl.Text = "2022-01-01";
            // 
            // datenow
            // 
            this.datenow.AutoSize = true;
            this.datenow.Location = new System.Drawing.Point(12, 32);
            this.datenow.Name = "datenow";
            this.datenow.Size = new System.Drawing.Size(68, 17);
            this.datenow.TabIndex = 5;
            this.datenow.Text = "当前日期：";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(78, 61);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(56, 17);
            this.time_lbl.TabIndex = 4;
            this.time_lbl.Text = "00:00:00";
            // 
            // temp_tbx
            // 
            this.temp_tbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.temp_tbx.Location = new System.Drawing.Point(75, 87);
            this.temp_tbx.Name = "temp_tbx";
            this.temp_tbx.ReadOnly = true;
            this.temp_tbx.Size = new System.Drawing.Size(59, 23);
            this.temp_tbx.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "℃";
            // 
            // tempnow
            // 
            this.tempnow.AutoSize = true;
            this.tempnow.Location = new System.Drawing.Point(12, 90);
            this.tempnow.Name = "tempnow";
            this.tempnow.Size = new System.Drawing.Size(68, 17);
            this.tempnow.TabIndex = 1;
            this.tempnow.Text = "当前温度：";
            // 
            // timenow
            // 
            this.timenow.AutoSize = true;
            this.timenow.Location = new System.Drawing.Point(12, 61);
            this.timenow.Name = "timenow";
            this.timenow.Size = new System.Drawing.Size(68, 17);
            this.timenow.TabIndex = 0;
            this.timenow.Text = "当前时间：";
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 152);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Temperature";
            this.Text = "温度";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label datenow;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.TextBox temp_tbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tempnow;
        private System.Windows.Forms.Label timenow;
    }
}