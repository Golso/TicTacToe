namespace TicTacToeProject
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
            this.single = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.ex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // single
            // 
            this.single.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.single.Location = new System.Drawing.Point(43, 21);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(205, 85);
            this.single.TabIndex = 0;
            this.single.Text = "Single player";
            this.single.UseVisualStyleBackColor = true;
            this.single.Click += new System.EventHandler(this.single_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(43, 124);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(205, 85);
            this.two.TabIndex = 1;
            this.two.Text = "Player vs player";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // ex
            // 
            this.ex.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex.Location = new System.Drawing.Point(43, 226);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(205, 85);
            this.ex.TabIndex = 2;
            this.ex.Text = "Exit";
            this.ex.UseVisualStyleBackColor = true;
            this.ex.Click += new System.EventHandler(this.ex_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 345);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.two);
            this.Controls.Add(this.single);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button single;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button ex;
    }
}