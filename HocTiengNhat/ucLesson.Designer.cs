namespace HocTiengNhat
{
    partial class ucLesson
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
            this.lbNum = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.kanji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLesson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.Location = new System.Drawing.Point(352, 33);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(120, 25);
            this.lbNum.TabIndex = 5;
            this.lbNum.Text = "Vocabulary";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kanji,
            this.hira,
            this.mean});
            this.dgvData.Location = new System.Drawing.Point(12, 99);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(524, 226);
            this.dgvData.TabIndex = 6;
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
            // lbLesson
            // 
            this.lbLesson.AutoSize = true;
            this.lbLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLesson.Location = new System.Drawing.Point(7, 33);
            this.lbLesson.Name = "lbLesson";
            this.lbLesson.Size = new System.Drawing.Size(82, 25);
            this.lbLesson.TabIndex = 4;
            this.lbLesson.Text = "Lesson";
            // 
            // ucLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lbLesson);
            this.Name = "ucLesson";
            this.Size = new System.Drawing.Size(550, 400);
            this.Load += new System.EventHandler(this.ucLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanji;
        private System.Windows.Forms.DataGridViewTextBoxColumn hira;
        private System.Windows.Forms.DataGridViewTextBoxColumn mean;
        private System.Windows.Forms.Label lbLesson;
    }
}
