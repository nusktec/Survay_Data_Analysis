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
            this.label2 = new System.Windows.Forms.Label();
            this.lbVisitor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLikesAve = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotalFemale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaleTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAgeAverage = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataView);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1492, 726);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitors Data";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.BackgroundColor = System.Drawing.Color.White;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(3, 27);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowTemplate.Height = 33;
            this.dataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.Size = new System.Drawing.Size(1486, 696);
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
            this.btnClose.Size = new System.Drawing.Size(357, 79);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close Board";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1144, 857);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(357, 79);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Data";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAgeAverage);
            this.groupBox1.Controls.Add(this.lbMaleTotal);
            this.groupBox1.Controls.Add(this.lbTotalFemale);
            this.groupBox1.Controls.Add(this.lbLikesAve);
            this.groupBox1.Controls.Add(this.lbVisitor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 843);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysed Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visitors Total:";
            // 
            // lbVisitor
            // 
            this.lbVisitor.AutoSize = true;
            this.lbVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisitor.Location = new System.Drawing.Point(230, 62);
            this.lbVisitor.Name = "lbVisitor";
            this.lbVisitor.Size = new System.Drawing.Size(29, 31);
            this.lbVisitor.TabIndex = 0;
            this.lbVisitor.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Likes Average:";
            // 
            // lbLikesAve
            // 
            this.lbLikesAve.AutoSize = true;
            this.lbLikesAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLikesAve.Location = new System.Drawing.Point(230, 134);
            this.lbLikesAve.Name = "lbLikesAve";
            this.lbLikesAve.Size = new System.Drawing.Size(29, 31);
            this.lbLikesAve.TabIndex = 0;
            this.lbLikesAve.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Female:";
            // 
            // lbTotalFemale
            // 
            this.lbTotalFemale.AutoSize = true;
            this.lbTotalFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFemale.Location = new System.Drawing.Point(486, 134);
            this.lbTotalFemale.Name = "lbTotalFemale";
            this.lbTotalFemale.Size = new System.Drawing.Size(29, 31);
            this.lbTotalFemale.TabIndex = 0;
            this.lbTotalFemale.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Male:";
            // 
            // lbMaleTotal
            // 
            this.lbMaleTotal.AutoSize = true;
            this.lbMaleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaleTotal.Location = new System.Drawing.Point(486, 62);
            this.lbMaleTotal.Name = "lbMaleTotal";
            this.lbMaleTotal.Size = new System.Drawing.Size(29, 31);
            this.lbMaleTotal.TabIndex = 0;
            this.lbMaleTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Age Average:";
            // 
            // lbAgeAverage
            // 
            this.lbAgeAverage.AutoSize = true;
            this.lbAgeAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgeAverage.Location = new System.Drawing.Point(759, 62);
            this.lbAgeAverage.Name = "lbAgeAverage";
            this.lbAgeAverage.Size = new System.Drawing.Size(29, 31);
            this.lbAgeAverage.TabIndex = 0;
            this.lbAgeAverage.Text = "0";
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1516, 1090);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lbLikesAve;
        private System.Windows.Forms.Label lbVisitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalFemale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMaleTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAgeAverage;
        private System.Windows.Forms.Label label5;
    }
}

