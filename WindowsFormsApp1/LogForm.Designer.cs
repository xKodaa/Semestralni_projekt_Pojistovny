using System.Windows.Forms;
using System.Drawing;

namespace Semestralni_projekt
{
    partial class LogForm
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.logsLb = new ListBox();
            this.btnOk = new Button();
            this.SuspendLayout();
            // 
            // logsLb
            // 
            this.logsLb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.logsLb.FormattingEnabled = true;
            this.logsLb.ItemHeight = 20;
            this.logsLb.Location = new Point(12, 12);
            this.logsLb.Name = "logsLb";
            this.logsLb.Size = new Size(425, 304);
            this.logsLb.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.btnOk.Location = new Point(12, 334);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new Size(424, 36);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(448, 382);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.logsLb);
            this.Name = "LogForm";
            this.Text = "Události";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox logsLb;
        private Button btnOk;
    }
}