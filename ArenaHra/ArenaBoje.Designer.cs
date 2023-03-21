namespace ArenaHra
{
    partial class ArenaBoje
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
            this.protivnikZivot = new System.Windows.Forms.Label();
            this.protivnikJmeno = new System.Windows.Forms.Label();
            this.utokBtn = new System.Windows.Forms.Button();
            this.hracJmeno = new System.Windows.Forms.Label();
            this.hracZivot = new System.Windows.Forms.Label();
            this.hracProgressBar = new System.Windows.Forms.ProgressBar();
            this.protivnikProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // protivnikZivot
            // 
            this.protivnikZivot.AutoSize = true;
            this.protivnikZivot.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.protivnikZivot.Location = new System.Drawing.Point(698, 173);
            this.protivnikZivot.Name = "protivnikZivot";
            this.protivnikZivot.Size = new System.Drawing.Size(132, 65);
            this.protivnikZivot.TabIndex = 1;
            this.protivnikZivot.Text = "Zivot";
            // 
            // protivnikJmeno
            // 
            this.protivnikJmeno.AutoSize = true;
            this.protivnikJmeno.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.protivnikJmeno.Location = new System.Drawing.Point(553, 40);
            this.protivnikJmeno.Name = "protivnikJmeno";
            this.protivnikJmeno.Size = new System.Drawing.Size(444, 133);
            this.protivnikJmeno.TabIndex = 2;
            this.protivnikJmeno.Text = "Protivnik";
            // 
            // utokBtn
            // 
            this.utokBtn.Location = new System.Drawing.Point(388, 534);
            this.utokBtn.Name = "utokBtn";
            this.utokBtn.Size = new System.Drawing.Size(243, 83);
            this.utokBtn.TabIndex = 0;
            this.utokBtn.Text = "Zacit zapas";
            this.utokBtn.UseVisualStyleBackColor = true;
            this.utokBtn.Click += new System.EventHandler(this.utokBtn_Click);
            // 
            // hracJmeno
            // 
            this.hracJmeno.AutoSize = true;
            this.hracJmeno.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hracJmeno.Location = new System.Drawing.Point(65, 40);
            this.hracJmeno.Name = "hracJmeno";
            this.hracJmeno.Size = new System.Drawing.Size(260, 133);
            this.hracJmeno.TabIndex = 3;
            this.hracJmeno.Text = "Hrac";
            // 
            // hracZivot
            // 
            this.hracZivot.AutoSize = true;
            this.hracZivot.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hracZivot.Location = new System.Drawing.Point(133, 176);
            this.hracZivot.Name = "hracZivot";
            this.hracZivot.Size = new System.Drawing.Size(127, 62);
            this.hracZivot.TabIndex = 4;
            this.hracZivot.Text = "Zivot";
            // 
            // hracProgressBar
            // 
            this.hracProgressBar.Location = new System.Drawing.Point(52, 263);
            this.hracProgressBar.Name = "hracProgressBar";
            this.hracProgressBar.Size = new System.Drawing.Size(249, 31);
            this.hracProgressBar.TabIndex = 5;
            this.hracProgressBar.Value = 100;
            // 
            // protivnikProgressBar
            // 
            this.protivnikProgressBar.Location = new System.Drawing.Point(622, 263);
            this.protivnikProgressBar.Name = "protivnikProgressBar";
            this.protivnikProgressBar.Size = new System.Drawing.Size(249, 31);
            this.protivnikProgressBar.TabIndex = 6;
            this.protivnikProgressBar.Value = 100;
            // 
            // ArenaBoje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.protivnikProgressBar);
            this.Controls.Add(this.hracProgressBar);
            this.Controls.Add(this.hracZivot);
            this.Controls.Add(this.hracJmeno);
            this.Controls.Add(this.protivnikJmeno);
            this.Controls.Add(this.protivnikZivot);
            this.Controls.Add(this.utokBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ArenaBoje";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label protivnikZivot;
        private Label protivnikJmeno;
        private Button utokBtn;
        private Label hracJmeno;
        private Label hracZivot;
        private ProgressBar hracProgressBar;
        private ProgressBar protivnikProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
