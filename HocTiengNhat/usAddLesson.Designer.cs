namespace HocTiengNhat
{
    partial class usAddLesson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kanji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbLesson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kanji,
            this.hira,
            this.mean});
            this.dataGridView1.Location = new System.Drawing.Point(27, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 230);
            this.dataGridView1.TabIndex = 4;
            // 
            // kanji
            // 
            this.kanji.HeaderText = "Kanji";
            this.kanji.Name = "kanji";
            this.kanji.ReadOnly = true;
            this.kanji.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kanji.Width = 150;
            // 
            // hira
            // 
            this.hira.HeaderText = "Hiragana";
            this.hira.Name = "hira";
            this.hira.ReadOnly = true;
            this.hira.Width = 150;
            // 
            // mean
            // 
            this.mean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mean.HeaderText = "Mean";
            this.mean.Name = "mean";
            this.mean.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(421, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbLesson
            // 
            this.lbLesson.AutoSize = true;
            this.lbLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLesson.Location = new System.Drawing.Point(27, 38);
            this.lbLesson.Name = "lbLesson";
            this.lbLesson.Size = new System.Drawing.Size(60, 24);
            this.lbLesson.TabIndex = 6;
            this.lbLesson.Text = "label1";
            // 
            // usAddLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLesson);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "usAddLesson";
            this.Size = new System.Drawing.Size(568, 403);
            this.Load += new System.EventHandler(this.usAddLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanji;
        private System.Windows.Forms.DataGridViewTextBoxColumn hira;
        private System.Windows.Forms.DataGridViewTextBoxColumn mean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbLesson;
    }
}
