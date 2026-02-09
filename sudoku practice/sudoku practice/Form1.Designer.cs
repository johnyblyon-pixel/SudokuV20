namespace sudoku_practice
{
    partial class FrmSudoku
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
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(12, 379);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(776, 59);
            this.btnSwitch.TabIndex = 20;
            this.btnSwitch.Text = "play game";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Sans Serif Collection", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(302, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(196, 126);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "Sudoku ";
            // 
            // btnEnd
            // 
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(587, 312);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(200, 67);
            this.btnEnd.TabIndex = 23;
            this.btnEnd.Text = "leave";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // FrmSudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSwitch);
            this.Name = "FrmSudoku";
            this.Text = "Form Sudoku";
            this.Load += new System.EventHandler(this.FrmSudoku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnEnd;
    }
}

