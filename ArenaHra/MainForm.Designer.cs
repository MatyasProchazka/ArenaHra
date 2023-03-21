namespace ArenaHra
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.arenaBoje = new ArenaHra.ArenaBoje();
            this.arenaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arenaBoje
            // 
            this.arenaBoje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arenaBoje.Location = new System.Drawing.Point(2, -27);
            this.arenaBoje.Margin = new System.Windows.Forms.Padding(6);
            this.arenaBoje.Name = "arenaBoje";
            this.arenaBoje.Size = new System.Drawing.Size(984, 680);
            this.arenaBoje.TabIndex = 1;
            // 
            // arenaBtn
            // 
            this.arenaBtn.Location = new System.Drawing.Point(29, 23);
            this.arenaBtn.Name = "arenaBtn";
            this.arenaBtn.Size = new System.Drawing.Size(179, 67);
            this.arenaBtn.TabIndex = 2;
            this.arenaBtn.Text = "Zapas";
            this.arenaBtn.UseVisualStyleBackColor = true;
            this.arenaBtn.Click += new System.EventHandler(this.arenaBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.arenaBtn);
            this.Controls.Add(this.arenaBoje);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ArenaBoje arenaBoje;
        private Button arenaBtn;
    }
}