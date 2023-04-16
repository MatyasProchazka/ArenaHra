namespace ArenaHra
{
    partial class Inventar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.utokLabel = new System.Windows.Forms.Label();
            this.kritickaSanceLabel = new System.Windows.Forms.Label();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.nasaditBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.odejitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 48;
            this.listBox1.Location = new System.Drawing.Point(56, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(691, 388);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jmenoLabel.Location = new System.Drawing.Point(67, 455);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(78, 32);
            this.jmenoLabel.TabIndex = 1;
            this.jmenoLabel.Text = "label1";
            // 
            // utokLabel
            // 
            this.utokLabel.AutoSize = true;
            this.utokLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.utokLabel.Location = new System.Drawing.Point(263, 455);
            this.utokLabel.Name = "utokLabel";
            this.utokLabel.Size = new System.Drawing.Size(78, 32);
            this.utokLabel.TabIndex = 2;
            this.utokLabel.Text = "label2";
            // 
            // kritickaSanceLabel
            // 
            this.kritickaSanceLabel.AutoSize = true;
            this.kritickaSanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kritickaSanceLabel.Location = new System.Drawing.Point(444, 455);
            this.kritickaSanceLabel.Name = "kritickaSanceLabel";
            this.kritickaSanceLabel.Size = new System.Drawing.Size(78, 32);
            this.kritickaSanceLabel.TabIndex = 3;
            this.kritickaSanceLabel.Text = "label3";
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cenaLabel.Location = new System.Drawing.Point(641, 455);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(78, 32);
            this.cenaLabel.TabIndex = 4;
            this.cenaLabel.Text = "label4";
            // 
            // nasaditBtn
            // 
            this.nasaditBtn.Location = new System.Drawing.Point(56, 519);
            this.nasaditBtn.Name = "nasaditBtn";
            this.nasaditBtn.Size = new System.Drawing.Size(163, 63);
            this.nasaditBtn.TabIndex = 5;
            this.nasaditBtn.Text = "Nasadit";
            this.nasaditBtn.UseVisualStyleBackColor = true;
            this.nasaditBtn.Click += new System.EventHandler(this.nasaditBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Prodat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // odejitBtn
            // 
            this.odejitBtn.Location = new System.Drawing.Point(599, 519);
            this.odejitBtn.Name = "odejitBtn";
            this.odejitBtn.Size = new System.Drawing.Size(171, 63);
            this.odejitBtn.TabIndex = 7;
            this.odejitBtn.Text = "Zpatky";
            this.odejitBtn.UseVisualStyleBackColor = true;
            this.odejitBtn.Click += new System.EventHandler(this.odejitBtn_Click);
            // 
            // Inventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.odejitBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nasaditBtn);
            this.Controls.Add(this.cenaLabel);
            this.Controls.Add(this.kritickaSanceLabel);
            this.Controls.Add(this.utokLabel);
            this.Controls.Add(this.jmenoLabel);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Inventar";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label jmenoLabel;
        private Label utokLabel;
        private Label kritickaSanceLabel;
        private Label cenaLabel;
        private Button nasaditBtn;
        private Button button2;
        private Button odejitBtn;
    }
}
