﻿namespace WinFormsApp1
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(309, 179);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 0;
            button1.Text = "Catch me !!!";
            button1.UseVisualStyleBackColor = false;
            button1.MouseEnter += button1_MouseEnter;
            // 
            // Form1
            // 
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Blue;
            ClientSize = new Size(700, 450);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Escaping button";
            ResumeLayout(false);
        }

        #endregion

        protected Button button1;
    }
}