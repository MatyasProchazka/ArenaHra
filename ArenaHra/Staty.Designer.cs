﻿namespace ArenaHra
{
    partial class Staty
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
            this.components = new System.ComponentModel.Container();
            this.hracJmenoLabel = new System.Windows.Forms.Label();
            this.hracUtokLabel = new System.Windows.Forms.Label();
            this.hracMaxZivotyLabel = new System.Windows.Forms.Label();
            this.hracPenizeLabel = new System.Windows.Forms.Label();
            this.utokPridaniBtn = new System.Windows.Forms.Button();
            this.maxZivotPridatBtn = new System.Windows.Forms.Button();
            this.odejitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.hracZbranLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hracJmenoLabel
            // 
            this.hracJmenoLabel.AutoSize = true;
            this.hracJmenoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hracJmenoLabel.Location = new System.Drawing.Point(444, 22);
            this.hracJmenoLabel.Name = "hracJmenoLabel";
            this.hracJmenoLabel.Size = new System.Drawing.Size(133, 65);
            this.hracJmenoLabel.TabIndex = 0;
            this.hracJmenoLabel.Text = "Hrac";
            // 
            // hracUtokLabel
            // 
            this.hracUtokLabel.AutoSize = true;
            this.hracUtokLabel.Location = new System.Drawing.Point(115, 170);
            this.hracUtokLabel.Name = "hracUtokLabel";
            this.hracUtokLabel.Size = new System.Drawing.Size(39, 48);
            this.hracUtokLabel.TabIndex = 1;
            this.hracUtokLabel.Text = "0";
            // 
            // hracMaxZivotyLabel
            // 
            this.hracMaxZivotyLabel.AutoSize = true;
            this.hracMaxZivotyLabel.Location = new System.Drawing.Point(491, 170);
            this.hracMaxZivotyLabel.Name = "hracMaxZivotyLabel";
            this.hracMaxZivotyLabel.Size = new System.Drawing.Size(39, 48);
            this.hracMaxZivotyLabel.TabIndex = 2;
            this.hracMaxZivotyLabel.Text = "0";
            // 
            // hracPenizeLabel
            // 
            this.hracPenizeLabel.AutoSize = true;
            this.hracPenizeLabel.Location = new System.Drawing.Point(802, 170);
            this.hracPenizeLabel.Name = "hracPenizeLabel";
            this.hracPenizeLabel.Size = new System.Drawing.Size(39, 48);
            this.hracPenizeLabel.TabIndex = 3;
            this.hracPenizeLabel.Text = "0";
            // 
            // utokPridaniBtn
            // 
            this.utokPridaniBtn.Location = new System.Drawing.Point(104, 254);
            this.utokPridaniBtn.Name = "utokPridaniBtn";
            this.utokPridaniBtn.Size = new System.Drawing.Size(65, 70);
            this.utokPridaniBtn.TabIndex = 4;
            this.utokPridaniBtn.Text = "+";
            this.utokPridaniBtn.UseVisualStyleBackColor = true;
            this.utokPridaniBtn.Click += new System.EventHandler(this.utokPridaniBtn_Click);
            this.utokPridaniBtn.MouseHover += new System.EventHandler(this.utokPridaniBtn_MouseHover);
            // 
            // maxZivotPridatBtn
            // 
            this.maxZivotPridatBtn.Location = new System.Drawing.Point(491, 254);
            this.maxZivotPridatBtn.Name = "maxZivotPridatBtn";
            this.maxZivotPridatBtn.Size = new System.Drawing.Size(65, 70);
            this.maxZivotPridatBtn.TabIndex = 5;
            this.maxZivotPridatBtn.Text = "+";
            this.maxZivotPridatBtn.UseVisualStyleBackColor = true;
            this.maxZivotPridatBtn.Click += new System.EventHandler(this.maxZivotPridatBtn_Click);
            this.maxZivotPridatBtn.MouseHover += new System.EventHandler(this.maxZivotPridatBtn_MouseHover);
            // 
            // odejitBtn
            // 
            this.odejitBtn.Location = new System.Drawing.Point(785, 530);
            this.odejitBtn.Name = "odejitBtn";
            this.odejitBtn.Size = new System.Drawing.Size(173, 66);
            this.odejitBtn.TabIndex = 8;
            this.odejitBtn.Text = "Zpátky";
            this.odejitBtn.UseVisualStyleBackColor = true;
            this.odejitBtn.Click += new System.EventHandler(this.odejitBtn_Click);
            // 
            // hracZbranLabel
            // 
            this.hracZbranLabel.AutoSize = true;
            this.hracZbranLabel.Location = new System.Drawing.Point(104, 456);
            this.hracZbranLabel.Name = "hracZbranLabel";
            this.hracZbranLabel.Size = new System.Drawing.Size(147, 48);
            this.hracZbranLabel.TabIndex = 9;
            this.hracZbranLabel.Text = "Prazdne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Utok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zivoty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = "Penize";
            // 
            // Staty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hracZbranLabel);
            this.Controls.Add(this.odejitBtn);
            this.Controls.Add(this.maxZivotPridatBtn);
            this.Controls.Add(this.utokPridaniBtn);
            this.Controls.Add(this.hracPenizeLabel);
            this.Controls.Add(this.hracMaxZivotyLabel);
            this.Controls.Add(this.hracUtokLabel);
            this.Controls.Add(this.hracJmenoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Staty";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hracJmenoLabel;
        private Label hracUtokLabel;
        private Label hracMaxZivotyLabel;
        private Label hracPenizeLabel;
        private Button utokPridaniBtn;
        private Button maxZivotPridatBtn;
        private Button odejitBtn;
        private ToolTip toolTip1;
        private Label hracZbranLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
