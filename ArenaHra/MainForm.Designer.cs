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
            this.statyBtn = new System.Windows.Forms.Button();
            this.inventarBtn = new System.Windows.Forms.Button();
            this.obchodBtn = new System.Windows.Forms.Button();
            this.odejitBtn = new System.Windows.Forms.Button();
            this.staty = new ArenaHra.Staty();
            this.inventar = new ArenaHra.Inventar();
            this.SuspendLayout();
            // 
            // arenaBoje
            // 
            this.arenaBoje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arenaBoje.Location = new System.Drawing.Point(-2, 2);
            this.arenaBoje.Margin = new System.Windows.Forms.Padding(6);
            this.arenaBoje.Name = "arenaBoje";
            this.arenaBoje.Size = new System.Drawing.Size(992, 652);
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
            // statyBtn
            // 
            this.statyBtn.Location = new System.Drawing.Point(266, 21);
            this.statyBtn.Name = "statyBtn";
            this.statyBtn.Size = new System.Drawing.Size(178, 69);
            this.statyBtn.TabIndex = 3;
            this.statyBtn.Text = "Staty";
            this.statyBtn.UseVisualStyleBackColor = true;
            this.statyBtn.Click += new System.EventHandler(this.statyBtn_Click);
            // 
            // inventarBtn
            // 
            this.inventarBtn.Location = new System.Drawing.Point(496, 21);
            this.inventarBtn.Name = "inventarBtn";
            this.inventarBtn.Size = new System.Drawing.Size(178, 69);
            this.inventarBtn.TabIndex = 4;
            this.inventarBtn.Text = "Inventar";
            this.inventarBtn.UseVisualStyleBackColor = true;
            this.inventarBtn.Click += new System.EventHandler(this.inventarBtn_Click);
            // 
            // obchodBtn
            // 
            this.obchodBtn.Location = new System.Drawing.Point(727, 23);
            this.obchodBtn.Name = "obchodBtn";
            this.obchodBtn.Size = new System.Drawing.Size(178, 69);
            this.obchodBtn.TabIndex = 5;
            this.obchodBtn.Text = "Obchod";
            this.obchodBtn.UseVisualStyleBackColor = true;
            // 
            // odejitBtn
            // 
            this.odejitBtn.Location = new System.Drawing.Point(760, 540);
            this.odejitBtn.Name = "odejitBtn";
            this.odejitBtn.Size = new System.Drawing.Size(178, 69);
            this.odejitBtn.TabIndex = 6;
            this.odejitBtn.Text = "Odejit";
            this.odejitBtn.UseVisualStyleBackColor = true;
            this.odejitBtn.Click += new System.EventHandler(this.odejitBtn_Click);
            // 
            // staty
            // 
            this.staty.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staty.Location = new System.Drawing.Point(-2, 2);
            this.staty.Margin = new System.Windows.Forms.Padding(6);
            this.staty.Name = "staty";
            this.staty.Size = new System.Drawing.Size(992, 652);
            this.staty.TabIndex = 7;
            // 
            // inventar
            // 
            this.inventar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventar.Location = new System.Drawing.Point(-2, 2);
            this.inventar.Margin = new System.Windows.Forms.Padding(6);
            this.inventar.Name = "inventar";
            this.inventar.Size = new System.Drawing.Size(979, 652);
            this.inventar.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.odejitBtn);
            this.Controls.Add(this.obchodBtn);
            this.Controls.Add(this.inventarBtn);
            this.Controls.Add(this.statyBtn);
            this.Controls.Add(this.arenaBtn);
            this.Controls.Add(this.arenaBoje);
            this.Controls.Add(this.staty);
            this.Controls.Add(this.inventar);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ArenaBoje arenaBoje;
        private Button arenaBtn;
        private Button statyBtn;
        private Button inventarBtn;
        private Button obchodBtn;
        private Button odejitBtn;
        private Staty staty;
        private Inventar inventar;
    }
}