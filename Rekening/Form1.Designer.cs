﻿ namespace Rekening {     partial class Form1     {         /// <summary>         /// Required designer variable.         /// </summary>         private System.ComponentModel.IContainer components = null;          /// <summary>         /// Clean up any resources being used.         /// </summary>         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>         protected override void Dispose(bool disposing)         {             if (disposing && (components != null))             {                 components.Dispose();             }             base.Dispose(disposing);         }          #region Windows Form Designer generated code          /// <summary>         /// Required method for Designer support - do not modify         /// the contents of this method with the code editor.         /// </summary>         private void InitializeComponent()         {             this.invoerRekening = new System.Windows.Forms.TextBox();
            this.invoerSpaar = new System.Windows.Forms.TextBox();
            this.invoerZicht = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RekeningPlus = new System.Windows.Forms.Button();
            this.RekeningMin = new System.Windows.Forms.Button();
            this.SpaarPlus = new System.Windows.Forms.Button();
            this.SpaarMin = new System.Windows.Forms.Button();
            this.ZichtPlus = new System.Windows.Forms.Button();
            this.ZichtMin = new System.Windows.Forms.Button();
            this.Intrest = new System.Windows.Forms.Button();
            this.uitvoerRekening = new System.Windows.Forms.Label();
            this.uitvoerSpaarrekening = new System.Windows.Forms.Label();
            this.uitvoerZichtrekening = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invoerRekening
            // 
            this.invoerRekening.Location = new System.Drawing.Point(38, 52);
            this.invoerRekening.Margin = new System.Windows.Forms.Padding(2);
            this.invoerRekening.Name = "invoerRekening";
            this.invoerRekening.Size = new System.Drawing.Size(204, 20);
            this.invoerRekening.TabIndex = 0;
            // 
            // invoerSpaar
            // 
            this.invoerSpaar.Location = new System.Drawing.Point(38, 141);
            this.invoerSpaar.Margin = new System.Windows.Forms.Padding(2);
            this.invoerSpaar.Name = "invoerSpaar";
            this.invoerSpaar.Size = new System.Drawing.Size(204, 20);
            this.invoerSpaar.TabIndex = 1;
            // 
            // invoerZicht
            // 
            this.invoerZicht.Location = new System.Drawing.Point(38, 228);
            this.invoerZicht.Margin = new System.Windows.Forms.Padding(2);
            this.invoerZicht.Name = "invoerZicht";
            this.invoerZicht.Size = new System.Drawing.Size(204, 20);
            this.invoerZicht.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rekening";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spaarrekening";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zichtrekening";
            // 
            // RekeningPlus
            // 
            this.RekeningPlus.Location = new System.Drawing.Point(272, 48);
            this.RekeningPlus.Margin = new System.Windows.Forms.Padding(2);
            this.RekeningPlus.Name = "RekeningPlus";
            this.RekeningPlus.Size = new System.Drawing.Size(56, 25);
            this.RekeningPlus.TabIndex = 6;
            this.RekeningPlus.Text = "+";
            this.RekeningPlus.UseVisualStyleBackColor = true;
            this.RekeningPlus.Click += new System.EventHandler(this.RekeningPlus_Click);
            // 
            // RekeningMin
            // 
            this.RekeningMin.Location = new System.Drawing.Point(348, 48);
            this.RekeningMin.Margin = new System.Windows.Forms.Padding(2);
            this.RekeningMin.Name = "RekeningMin";
            this.RekeningMin.Size = new System.Drawing.Size(56, 25);
            this.RekeningMin.TabIndex = 7;
            this.RekeningMin.Text = "-";
            this.RekeningMin.UseVisualStyleBackColor = true;
            this.RekeningMin.Click += new System.EventHandler(this.RekeningMin_Click);
            // 
            // SpaarPlus
            // 
            this.SpaarPlus.Location = new System.Drawing.Point(272, 136);
            this.SpaarPlus.Margin = new System.Windows.Forms.Padding(2);
            this.SpaarPlus.Name = "SpaarPlus";
            this.SpaarPlus.Size = new System.Drawing.Size(56, 25);
            this.SpaarPlus.TabIndex = 8;
            this.SpaarPlus.Text = "+";
            this.SpaarPlus.UseVisualStyleBackColor = true;
            this.SpaarPlus.Click += new System.EventHandler(this.SpaarPlus_Click);
            // 
            // SpaarMin
            // 
            this.SpaarMin.Location = new System.Drawing.Point(348, 136);
            this.SpaarMin.Margin = new System.Windows.Forms.Padding(2);
            this.SpaarMin.Name = "SpaarMin";
            this.SpaarMin.Size = new System.Drawing.Size(56, 25);
            this.SpaarMin.TabIndex = 9;
            this.SpaarMin.Text = "-";
            this.SpaarMin.UseVisualStyleBackColor = true;
            this.SpaarMin.Click += new System.EventHandler(this.SpaarMin_Click);
            // 
            // ZichtPlus
            // 
            this.ZichtPlus.Location = new System.Drawing.Point(272, 224);
            this.ZichtPlus.Margin = new System.Windows.Forms.Padding(2);
            this.ZichtPlus.Name = "ZichtPlus";
            this.ZichtPlus.Size = new System.Drawing.Size(56, 25);
            this.ZichtPlus.TabIndex = 10;
            this.ZichtPlus.Text = "+";
            this.ZichtPlus.UseVisualStyleBackColor = true;
            this.ZichtPlus.Click += new System.EventHandler(this.ZichtPlus_Click);
            // 
            // ZichtMin
            // 
            this.ZichtMin.Location = new System.Drawing.Point(348, 224);
            this.ZichtMin.Margin = new System.Windows.Forms.Padding(2);
            this.ZichtMin.Name = "ZichtMin";
            this.ZichtMin.Size = new System.Drawing.Size(56, 25);
            this.ZichtMin.TabIndex = 11;
            this.ZichtMin.Text = "-";
            this.ZichtMin.UseVisualStyleBackColor = true;
            this.ZichtMin.Click += new System.EventHandler(this.ZichtMin_Click);
            // 
            // Intrest
            // 
            this.Intrest.Location = new System.Drawing.Point(424, 136);
            this.Intrest.Margin = new System.Windows.Forms.Padding(2);
            this.Intrest.Name = "Intrest";
            this.Intrest.Size = new System.Drawing.Size(56, 25);
            this.Intrest.TabIndex = 12;
            this.Intrest.Text = "Intrest";
            this.Intrest.UseVisualStyleBackColor = true;
            this.Intrest.Click += new System.EventHandler(this.Intrest_Click);
            // 
            // uitvoerRekening
            // 
            this.uitvoerRekening.AutoSize = true;
            this.uitvoerRekening.Location = new System.Drawing.Point(35, 80);
            this.uitvoerRekening.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uitvoerRekening.Name = "uitvoerRekening";
            this.uitvoerRekening.Size = new System.Drawing.Size(35, 13);
            this.uitvoerRekening.TabIndex = 13;
            this.uitvoerRekening.Text = "label4";
            // 
            // uitvoerSpaarrekening
            // 
            this.uitvoerSpaarrekening.AutoSize = true;
            this.uitvoerSpaarrekening.Location = new System.Drawing.Point(35, 170);
            this.uitvoerSpaarrekening.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uitvoerSpaarrekening.Name = "uitvoerSpaarrekening";
            this.uitvoerSpaarrekening.Size = new System.Drawing.Size(35, 13);
            this.uitvoerSpaarrekening.TabIndex = 14;
            this.uitvoerSpaarrekening.Text = "label5";
            // 
            // uitvoerZichtrekening
            // 
            this.uitvoerZichtrekening.AutoSize = true;
            this.uitvoerZichtrekening.Location = new System.Drawing.Point(35, 255);
            this.uitvoerZichtrekening.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uitvoerZichtrekening.Name = "uitvoerZichtrekening";
            this.uitvoerZichtrekening.Size = new System.Drawing.Size(35, 13);
            this.uitvoerZichtrekening.TabIndex = 15;
            this.uitvoerZichtrekening.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uitvoerZichtrekening);
            this.Controls.Add(this.uitvoerSpaarrekening);
            this.Controls.Add(this.uitvoerRekening);
            this.Controls.Add(this.Intrest);
            this.Controls.Add(this.ZichtMin);
            this.Controls.Add(this.ZichtPlus);
            this.Controls.Add(this.SpaarMin);
            this.Controls.Add(this.SpaarPlus);
            this.Controls.Add(this.RekeningMin);
            this.Controls.Add(this.RekeningPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoerZicht);
            this.Controls.Add(this.invoerSpaar);
            this.Controls.Add(this.invoerRekening);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }          #endregion          private System.Windows.Forms.TextBox invoerRekening;         private System.Windows.Forms.TextBox invoerSpaar;         private System.Windows.Forms.TextBox invoerZicht;         private System.Windows.Forms.Label label1;         private System.Windows.Forms.Label label2;         private System.Windows.Forms.Label label3;         private System.Windows.Forms.Button RekeningPlus;         private System.Windows.Forms.Button RekeningMin;         private System.Windows.Forms.Button SpaarPlus;         private System.Windows.Forms.Button SpaarMin;         private System.Windows.Forms.Button ZichtPlus;         private System.Windows.Forms.Button ZichtMin;         private System.Windows.Forms.Button Intrest;         private System.Windows.Forms.Label uitvoerRekening;         private System.Windows.Forms.Label uitvoerSpaarrekening;         private System.Windows.Forms.Label uitvoerZichtrekening;     } }  