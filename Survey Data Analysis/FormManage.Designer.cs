namespace Survey_Data_Analysis
{
    partial class FormManage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataView);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1449, 726);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitors Data";
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(3, 27);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 33;
            this.dataView.Size = new System.Drawing.Size(1443, 696);
            this.dataView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Addministrator: Visitors Data Analysis";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1144, 977);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(317, 79);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close Board";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1144, 857);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(317, 79);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Data";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 843);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysed Data";
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1475, 1090);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Visitors";
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataView;
    }
}

