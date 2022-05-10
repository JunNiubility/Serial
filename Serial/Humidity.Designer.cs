
namespace Serial
{
    partial class Humidity
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.humidity_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.datenow = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.timenow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.humidity_tbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.datenow);
            this.groupBox1.Controls.Add(this.time_lbl);
            this.groupBox1.Controls.Add(this.timenow);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据面板";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // humidity_tbx
            // 
            this.humidity_tbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.humidity_tbx.Location = new System.Drawing.Point(75, 93);
            this.humidity_tbx.Name = "humidity_tbx";
            this.humidity_tbx.ReadOnly = true;
            this.humidity_tbx.Size = new System.Drawing.Size(59, 23);
            this.humidity_tbx.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "当前湿度：";
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
            // timenow
            // 
            this.timenow.AutoSize = true;
            this.timenow.Location = new System.Drawing.Point(12, 61);
            this.timenow.Name = "timenow";
            this.timenow.Size = new System.Drawing.Size(68, 17);
            this.timenow.TabIndex = 0;
            this.timenow.Text = "当前时间：";
            // 
            // Humidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 162);
            this.Controls.Add(this.groupBox1);
            this.Name = "Humidity";
            this.Text = "湿度";
            this.Load += new System.EventHandler(this.Humidity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox humidity_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label datenow;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label timenow;
    }
}