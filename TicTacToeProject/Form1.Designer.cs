namespace TicTacToeProject
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.goBackToMainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.resetToolStripMenuItem.Text = "Reset results";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // goBackToMainMenuToolStripMenuItem
            // 
            this.goBackToMainMenuToolStripMenuItem.Name = "goBackToMainMenuToolStripMenuItem";
            this.goBackToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.goBackToMainMenuToolStripMenuItem.Text = "Go back to main menu";
            this.goBackToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.goBackToMainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonA1
            // 
            this.buttonA1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA1.Location = new System.Drawing.Point(26, 41);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(80, 80);
            this.buttonA1.TabIndex = 1;
            this.buttonA1.UseVisualStyleBackColor = false;
            this.buttonA1.Click += new System.EventHandler(this.button_click);
            this.buttonA1.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonA1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonA2
            // 
            this.buttonA2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA2.Location = new System.Drawing.Point(112, 41);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(80, 80);
            this.buttonA2.TabIndex = 2;
            this.buttonA2.UseVisualStyleBackColor = false;
            this.buttonA2.Click += new System.EventHandler(this.button_click);
            this.buttonA2.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonA2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonA3
            // 
            this.buttonA3.BackColor = System.Drawing.SystemColors.Control;
            this.buttonA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA3.Location = new System.Drawing.Point(198, 41);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(80, 80);
            this.buttonA3.TabIndex = 3;
            this.buttonA3.UseVisualStyleBackColor = false;
            this.buttonA3.Click += new System.EventHandler(this.button_click);
            this.buttonA3.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonA3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonB1
            // 
            this.buttonB1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB1.Location = new System.Drawing.Point(26, 127);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(80, 80);
            this.buttonB1.TabIndex = 4;
            this.buttonB1.UseVisualStyleBackColor = false;
            this.buttonB1.Click += new System.EventHandler(this.button_click);
            this.buttonB1.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonB1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonB2
            // 
            this.buttonB2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB2.Location = new System.Drawing.Point(112, 127);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(80, 80);
            this.buttonB2.TabIndex = 5;
            this.buttonB2.UseVisualStyleBackColor = false;
            this.buttonB2.Click += new System.EventHandler(this.button_click);
            this.buttonB2.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonB2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonB3
            // 
            this.buttonB3.BackColor = System.Drawing.SystemColors.Control;
            this.buttonB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB3.Location = new System.Drawing.Point(198, 127);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(80, 80);
            this.buttonB3.TabIndex = 6;
            this.buttonB3.UseVisualStyleBackColor = false;
            this.buttonB3.Click += new System.EventHandler(this.button_click);
            this.buttonB3.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonB3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonC1
            // 
            this.buttonC1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC1.Location = new System.Drawing.Point(26, 213);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(80, 80);
            this.buttonC1.TabIndex = 7;
            this.buttonC1.UseVisualStyleBackColor = false;
            this.buttonC1.Click += new System.EventHandler(this.button_click);
            this.buttonC1.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonC1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonC2
            // 
            this.buttonC2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC2.Location = new System.Drawing.Point(112, 213);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(80, 80);
            this.buttonC2.TabIndex = 8;
            this.buttonC2.UseVisualStyleBackColor = false;
            this.buttonC2.Click += new System.EventHandler(this.button_click);
            this.buttonC2.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonC2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // buttonC3
            // 
            this.buttonC3.BackColor = System.Drawing.SystemColors.Control;
            this.buttonC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC3.Location = new System.Drawing.Point(198, 213);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(80, 80);
            this.buttonC3.TabIndex = 9;
            this.buttonC3.UseVisualStyleBackColor = false;
            this.buttonC3.Click += new System.EventHandler(this.button_click);
            this.buttonC3.MouseEnter += new System.EventHandler(this.button_enter);
            this.buttonC3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(344, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tie";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(352, 77);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(16, 17);
            this.x_win_count.TabIndex = 13;
            this.x_win_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(352, 245);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(16, 17);
            this.draw_count.TabIndex = 14;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(352, 164);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(16, 17);
            this.o_win_count.TabIndex = 15;
            this.o_win_count.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(328, 41);
            this.label1.MaximumSize = new System.Drawing.Size(120, 17);
            this.label1.MinimumSize = new System.Drawing.Size(68, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Player 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(328, 127);
            this.label3.MaximumSize = new System.Drawing.Size(120, 17);
            this.label3.MinimumSize = new System.Drawing.Size(68, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Player 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 316);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Button buttonA2;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonB1;
        private System.Windows.Forms.Button buttonB2;
        private System.Windows.Forms.Button buttonB3;
        private System.Windows.Forms.Button buttonC1;
        private System.Windows.Forms.Button buttonC2;
        private System.Windows.Forms.Button buttonC3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem goBackToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    }
}

