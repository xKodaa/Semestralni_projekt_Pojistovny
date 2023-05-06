using System.Windows.Forms;
using System.Drawing;
using System.Net;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnZdravotniPojistovna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
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
            this.dataView.Location = new System.Drawing.Point(-1, -1);
            this.dataView.Margin = new System.Windows.Forms.Padding(2);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersVisible = false;
            this.dataView.RowHeadersWidth = 60;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(784, 523);
            this.dataView.TabIndex = 0;
            // 
            // columnID
            // 
            this.columnID.DividerWidth = 1;
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 6;
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnID.Width = 125;
            // 
            // columnOsoba
            // 
            this.columnOsoba.HeaderText = "Osoba";
            this.columnOsoba.MinimumWidth = 6;
            this.columnOsoba.Name = "columnOsoba";
            this.columnOsoba.ReadOnly = true;
            this.columnOsoba.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnOsoba.Width = 219;
            // 
            // columnAdresa
            // 
            this.columnAdresa.HeaderText = "Adresa";
            this.columnAdresa.MinimumWidth = 6;
            this.columnAdresa.Name = "columnAdresa";
            this.columnAdresa.ReadOnly = true;
            this.columnAdresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnAdresa.Width = 219;
            // 
            // columnZdravotniPojistovna
            // 
            this.columnZdravotniPojistovna.HeaderText = "Zdravotní pojišťovna";
            this.columnZdravotniPojistovna.MinimumWidth = 6;
            this.columnZdravotniPojistovna.Name = "columnZdravotniPojistovna";
            this.columnZdravotniPojistovna.ReadOnly = true;
            this.columnZdravotniPojistovna.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnZdravotniPojistovna.Width = 220;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(15, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Přidat";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(130, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Odstranit";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(245, 527);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Upravit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogs.Location = new System.Drawing.Point(605, 527);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(167, 25);
            this.btnLogs.TabIndex = 4;
            this.btnLogs.Text = "Zobrazit znáznam změn";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Edvidence obyvatel";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataView;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnLogs;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnOsoba;
        private DataGridViewTextBoxColumn columnAdresa;
        private DataGridViewTextBoxColumn columnZdravotniPojistovna;
    }
}

