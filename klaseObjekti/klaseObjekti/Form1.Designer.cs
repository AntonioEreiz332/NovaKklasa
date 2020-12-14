namespace klaseObjekti
{
    partial class Form1
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.labString = new System.Windows.Forms.Label();
            this.labInt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 28);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 0;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(13, 73);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 20);
            this.txtInt.TabIndex = 1;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(16, 118);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(401, 164);
            this.txtIspis.TabIndex = 2;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(142, 28);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(142, 73);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 4;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            // 
            // labString
            // 
            this.labString.AutoSize = true;
            this.labString.Location = new System.Drawing.Point(13, 13);
            this.labString.Name = "labString";
            this.labString.Size = new System.Drawing.Size(68, 13);
            this.labString.TabIndex = 5;
            this.labString.Text = "Unos Stringa";
            // 
            // labInt
            // 
            this.labInt.AutoSize = true;
            this.labInt.Location = new System.Drawing.Point(13, 57);
            this.labInt.Name = "labInt";
            this.labInt.Size = new System.Drawing.Size(47, 13);
            this.labInt.TabIndex = 6;
            this.labInt.Text = "Unos Int";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labInt);
            this.Controls.Add(this.labString);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label labString;
        private System.Windows.Forms.Label labInt;
    }
}

