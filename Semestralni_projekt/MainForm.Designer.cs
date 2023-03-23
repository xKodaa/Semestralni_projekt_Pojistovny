using System.Windows.Forms;
using System.Drawing;

namespace Semestralni_projekt
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataView = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnZdravotniPojistovna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnOsoba,
            this.columnAdresa,
            this.columnZdravotniPojistovna});
            this.dataView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataView.Location = new System.Drawing.Point(0, 75);
            this.dataView.Margin = new System.Windows.Forms.Padding(2);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersVisible = false;
            this.dataView.RowHeadersWidth = 60;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(784, 580);
            this.dataView.TabIndex = 0;
            // 
            // columnID
            // 
            this.columnID.DividerWidth = 1;
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 6;
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // columnOsoba
            // 
            this.columnOsoba.HeaderText = "Osoba";
            this.columnOsoba.MinimumWidth = 6;
            this.columnOsoba.Name = "columnOsoba";
            this.columnOsoba.ReadOnly = true;
            this.columnOsoba.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnOsoba.Width = 225;
            this.columnOsoba.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // columnAdresa
            // 
            this.columnAdresa.HeaderText = "Adresa";
            this.columnAdresa.MinimumWidth = 6;
            this.columnAdresa.Name = "columnAdresa";
            this.columnAdresa.ReadOnly = true;
            this.columnAdresa.Width = 230;
            this.columnAdresa.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // columnZdravotniPojistovna
            // 
            this.columnZdravotniPojistovna.HeaderText = "Zdravotní pojišťovna";
            this.columnZdravotniPojistovna.MinimumWidth = 6;
            this.columnZdravotniPojistovna.Name = "columnZdravotniPojistovna";
            this.columnZdravotniPojistovna.ReadOnly = true;
            this.columnZdravotniPojistovna.Width = 230;
            this.columnZdravotniPojistovna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Edvidence obyvatel";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataView;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnOsoba;
        private DataGridViewTextBoxColumn columnAdresa;
        private DataGridViewTextBoxColumn columnZdravotniPojistovna;
    }
}

