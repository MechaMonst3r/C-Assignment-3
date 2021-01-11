namespace HospitalCharges
{
    partial class HospitalCharges
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
            this.days_tb = new System.Windows.Forms.TextBox();
            this.meds_tb = new System.Windows.Forms.TextBox();
            this.surgical_tb = new System.Windows.Forms.TextBox();
            this.lab_tb = new System.Windows.Forms.TextBox();
            this.physical_tb = new System.Windows.Forms.TextBox();
            this.charges_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.results_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // days_tb
            // 
            this.days_tb.Location = new System.Drawing.Point(208, 18);
            this.days_tb.Name = "days_tb";
            this.days_tb.Size = new System.Drawing.Size(100, 20);
            this.days_tb.TabIndex = 0;
            // 
            // meds_tb
            // 
            this.meds_tb.Location = new System.Drawing.Point(208, 58);
            this.meds_tb.Name = "meds_tb";
            this.meds_tb.Size = new System.Drawing.Size(100, 20);
            this.meds_tb.TabIndex = 1;
            // 
            // surgical_tb
            // 
            this.surgical_tb.Location = new System.Drawing.Point(208, 98);
            this.surgical_tb.Name = "surgical_tb";
            this.surgical_tb.Size = new System.Drawing.Size(100, 20);
            this.surgical_tb.TabIndex = 2;
            // 
            // lab_tb
            // 
            this.lab_tb.Location = new System.Drawing.Point(208, 130);
            this.lab_tb.Name = "lab_tb";
            this.lab_tb.Size = new System.Drawing.Size(100, 20);
            this.lab_tb.TabIndex = 3;
            // 
            // physical_tb
            // 
            this.physical_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physical_tb.Location = new System.Drawing.Point(208, 162);
            this.physical_tb.Name = "physical_tb";
            this.physical_tb.Size = new System.Drawing.Size(100, 20);
            this.physical_tb.TabIndex = 4;
            // 
            // charges_btn
            // 
            this.charges_btn.Location = new System.Drawing.Point(119, 199);
            this.charges_btn.Name = "charges_btn";
            this.charges_btn.Size = new System.Drawing.Size(100, 23);
            this.charges_btn.TabIndex = 5;
            this.charges_btn.Text = "Calculate ";
            this.charges_btn.UseVisualStyleBackColor = true;
            this.charges_btn.Click += new System.EventHandler(this.charges_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Charges:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Days Spent in Hospital:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Medication Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surgical Charges:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lab Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Physical Rehabilitation Charges:";
            // 
            // results_lbl
            // 
            this.results_lbl.AutoSize = true;
            this.results_lbl.Location = new System.Drawing.Point(104, 242);
            this.results_lbl.Name = "results_lbl";
            this.results_lbl.Size = new System.Drawing.Size(34, 13);
            this.results_lbl.TabIndex = 12;
            this.results_lbl.Text = "$0.00";
            // 
            // HospitalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 284);
            this.Controls.Add(this.results_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charges_btn);
            this.Controls.Add(this.physical_tb);
            this.Controls.Add(this.lab_tb);
            this.Controls.Add(this.surgical_tb);
            this.Controls.Add(this.meds_tb);
            this.Controls.Add(this.days_tb);
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox days_tb;
        private System.Windows.Forms.TextBox meds_tb;
        private System.Windows.Forms.TextBox surgical_tb;
        private System.Windows.Forms.TextBox lab_tb;
        private System.Windows.Forms.TextBox physical_tb;
        private System.Windows.Forms.Button charges_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label results_lbl;
    }
}

