namespace sudoku_practice
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnIntermediate = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Location = new System.Drawing.Point(215, 40);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(371, 371);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // gametime
            // 
            this.gametime.Interval = 10000;
            this.gametime.Tick += new System.EventHandler(this.gametime_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(30, 411);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(24, 13);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00s";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRestart.Location = new System.Drawing.Point(12, 144);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(89, 27);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "restart puzzle";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnValid
            // 
            this.btnValid.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnValid.Location = new System.Drawing.Point(670, 393);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(118, 45);
            this.btnValid.TabIndex = 7;
            this.btnValid.Text = "valid";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEasy.Location = new System.Drawing.Point(12, 40);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(89, 27);
            this.btnEasy.TabIndex = 8;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnIntermediate
            // 
            this.btnIntermediate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnIntermediate.Location = new System.Drawing.Point(12, 68);
            this.btnIntermediate.Name = "btnIntermediate";
            this.btnIntermediate.Size = new System.Drawing.Size(89, 27);
            this.btnIntermediate.TabIndex = 9;
            this.btnIntermediate.Text = "Intermediate";
            this.btnIntermediate.UseVisualStyleBackColor = true;
            this.btnIntermediate.Click += new System.EventHandler(this.btnIntermediate_Click);
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(12, 98);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(89, 27);
            this.btnHard.TabIndex = 10;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnIntermediate);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panelGrid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnIntermediate;
        private System.Windows.Forms.Button btnHard;
    }
}