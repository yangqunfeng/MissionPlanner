﻿namespace MissionPlanner.Controls
{
   partial class RangeControl
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LBL_max = new System.Windows.Forms.Label();
            this.LBL_min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 58);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(69, 58);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(293, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickFrequency = 100;
            // 
            // LBL_max
            // 
            this.LBL_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_max.Location = new System.Drawing.Point(296, 90);
            this.LBL_max.Name = "LBL_max";
            this.LBL_max.Size = new System.Drawing.Size(66, 13);
            this.LBL_max.TabIndex = 6;
            this.LBL_max.Text = "65535";
            this.LBL_max.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LBL_min
            // 
            this.LBL_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_min.Location = new System.Drawing.Point(72, 90);
            this.LBL_min.Name = "LBL_min";
            this.LBL_min.Size = new System.Drawing.Size(77, 13);
            this.LBL_min.TabIndex = 7;
            this.LBL_min.Text = "0";
            // 
            // RangeControl
            // 
            this.Controls.Add(this.LBL_max);
            this.Controls.Add(this.LBL_min);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "RangeControl";
            this.Size = new System.Drawing.Size(365, 108);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Label LBL_max;
      private System.Windows.Forms.Label LBL_min;
        private System.Windows.Forms.TrackBar trackBar1;

   }
}
