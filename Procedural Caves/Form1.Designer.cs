﻿namespace Procedural_Caves
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeNud = new System.Windows.Forms.NumericUpDown();
            this.DelayNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DensityNud = new System.Windows.Forms.NumericUpDown();
            this.RegenerateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IterationsNud = new System.Windows.Forms.NumericUpDown();
            this.pathLabel = new System.Windows.Forms.Label();
            this.CheckboxRemoveCaverns = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FloorConvertNup = new System.Windows.Forms.NumericUpDown();
            this.WallConvertNup = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorConvertNup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallConvertNup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cell Size (px):";
            // 
            // SizeNud
            // 
            this.SizeNud.Location = new System.Drawing.Point(92, 7);
            this.SizeNud.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SizeNud.Name = "SizeNud";
            this.SizeNud.Size = new System.Drawing.Size(53, 23);
            this.SizeNud.TabIndex = 1;
            this.SizeNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DelayNud
            // 
            this.DelayNud.Location = new System.Drawing.Point(220, 7);
            this.DelayNud.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DelayNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DelayNud.Name = "DelayNud";
            this.DelayNud.Size = new System.Drawing.Size(53, 23);
            this.DelayNud.TabIndex = 2;
            this.DelayNud.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.DelayNud.ValueChanged += new System.EventHandler(this.DelayNud_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delay (ms):";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "asduhdas";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Density (%):";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DensityNud
            // 
            this.DensityNud.Location = new System.Drawing.Point(384, 7);
            this.DensityNud.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DensityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DensityNud.Name = "DensityNud";
            this.DensityNud.Size = new System.Drawing.Size(53, 23);
            this.DensityNud.TabIndex = 5;
            this.DensityNud.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // RegenerateButton
            // 
            this.RegenerateButton.Location = new System.Drawing.Point(716, 7);
            this.RegenerateButton.Name = "RegenerateButton";
            this.RegenerateButton.Size = new System.Drawing.Size(75, 23);
            this.RegenerateButton.TabIndex = 6;
            this.RegenerateButton.Text = "Regenerate";
            this.RegenerateButton.UseVisualStyleBackColor = true;
            this.RegenerateButton.Click += new System.EventHandler(this.RegenerateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(797, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 520);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iterations:";
            // 
            // IterationsNud
            // 
            this.IterationsNud.Location = new System.Drawing.Point(505, 7);
            this.IterationsNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IterationsNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IterationsNud.Name = "IterationsNud";
            this.IterationsNud.Size = new System.Drawing.Size(53, 23);
            this.IterationsNud.TabIndex = 10;
            this.IterationsNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(13, 599);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 15);
            this.pathLabel.TabIndex = 11;
            // 
            // CheckboxRemoveCaverns
            // 
            this.CheckboxRemoveCaverns.AutoSize = true;
            this.CheckboxRemoveCaverns.Location = new System.Drawing.Point(564, 8);
            this.CheckboxRemoveCaverns.Name = "CheckboxRemoveCaverns";
            this.CheckboxRemoveCaverns.Size = new System.Drawing.Size(146, 19);
            this.CheckboxRemoveCaverns.TabIndex = 12;
            this.CheckboxRemoveCaverns.Text = "Remove Small Caverns";
            this.CheckboxRemoveCaverns.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Floor Conversion Value:";
            // 
            // FloorConvertNup
            // 
            this.FloorConvertNup.Location = new System.Drawing.Point(149, 33);
            this.FloorConvertNup.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.FloorConvertNup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FloorConvertNup.Name = "FloorConvertNup";
            this.FloorConvertNup.Size = new System.Drawing.Size(53, 23);
            this.FloorConvertNup.TabIndex = 14;
            this.FloorConvertNup.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.FloorConvertNup.ValueChanged += new System.EventHandler(this.FloorConvertNup_Changed);
            // 
            // WallConvertNup
            // 
            this.WallConvertNup.Location = new System.Drawing.Point(341, 35);
            this.WallConvertNup.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.WallConvertNup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WallConvertNup.Name = "WallConvertNup";
            this.WallConvertNup.Size = new System.Drawing.Size(53, 23);
            this.WallConvertNup.TabIndex = 15;
            this.WallConvertNup.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.WallConvertNup.ValueChanged += new System.EventHandler(this.WallConvertNup_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Wall Conversion Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 625);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WallConvertNup);
            this.Controls.Add(this.FloorConvertNup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckboxRemoveCaverns);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.IterationsNud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RegenerateButton);
            this.Controls.Add(this.DensityNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelayNud);
            this.Controls.Add(this.SizeNud);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cellular Autonama Procedural Cave - C# Visualisation";
            ((System.ComponentModel.ISupportInitialize)(this.SizeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorConvertNup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallConvertNup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown SizeNud;
        private NumericUpDown DelayNud;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown DensityNud;
        private Button RegenerateButton;
        private Button SaveButton;
        private PictureBox pictureBox1;
        private Label label4;
        private NumericUpDown IterationsNud;
        private Label pathLabel;
        private CheckBox CheckboxRemoveCaverns;
        private Label label5;
        private NumericUpDown FloorConvertNup;
        private NumericUpDown WallConvertNup;
        private Label label6;
    }
}