namespace HocTiengNhat
{
    partial class MainForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLesson = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.lbNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(70, 29);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Hello";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(383, 12);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(70, 25);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "label1";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Location = new System.Drawing.Point(12, 110);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(192, 447);
            this.panelData.TabIndex = 5;
            // 
            // lbLesson
            // 
            this.lbLesson.AutoSize = true;
            this.lbLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLesson.Location = new System.Drawing.Point(44, 25);
            this.lbLesson.Name = "lbLesson";
            this.lbLesson.Size = new System.Drawing.Size(82, 25);
            this.lbLesson.TabIndex = 0;
            this.lbLesson.Text = "Lesson";
            // 
            // panelDetail
            // 
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Controls.Add(this.lbNum);
            this.panelDetail.Controls.Add(this.dataGridView1);
            this.panelDetail.Controls.Add(this.lbLesson);
            this.panelDetail.Location = new System.Drawing.Point(210, 110);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(569, 447);
            this.panelDetail.TabIndex = 7;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.Location = new System.Drawing.Point(322, 25);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(120, 25);
            this.lbNum.TabIndex = 2;
            this.lbNum.Text = "Vocabulary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kanji,
            this.hira,
            this.mean});
            this.dataGridView1.Location = new System.Drawing.Point(20, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 226);
            this.dataGridView1.TabIndex = 3;
            // 
            // mean
            // 
            this.mean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mean.HeaderText = "Mean";
            this.mean.Name = "mean";
            this.mean.ReadOnly = true;
            // 
            // hira
            // 
            this.hira.HeaderText = "Hiragana";
            this.hira.Name = "hira";
            this.hira.ReadOnly = true;
            this.hira.Width = 150;
            // 
            // kanji
            // 
            this.kanji.HeaderText = "Kanji";
            this.kanji.Name = "kanji";
            this.kanji.ReadOnly = true;
            this.kanji.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kanji.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 584);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.FlowLayoutPanel panelData;
        private System.Windows.Forms.Label lbLesson;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanji;
        private System.Windows.Forms.DataGridViewTextBoxColumn hira;
        private System.Windows.Forms.DataGridViewTextBoxColumn mean;
    }
}