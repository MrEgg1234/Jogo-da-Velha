namespace ProjetoJogoDaVelha
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(278, 168);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(359, 168);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(439, 168);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(439, 248);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(359, 248);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(278, 248);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 3;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(278, 335);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(359, 335);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            // 
            // button9
            // 
            button9.Location = new Point(439, 335);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 6;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tic_tac_toe;
            pictureBox1.Location = new Point(247, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private PictureBox pictureBox1;
    }
}