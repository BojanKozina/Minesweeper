namespace Minesweeper
{
    partial class frmMinesweeperMain
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            btnExit = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pbMineIcon = new PictureBox();
            panel6 = new Panel();
            pbMineSweeperLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMineIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMineSweeperLogo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(318, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 478);
            panel2.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, 476);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 2);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(135, 136, 145);
            panel4.Location = new Point(1, 474);
            panel4.Name = "panel4";
            panel4.Size = new Size(316, 2);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 472);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 199, 200);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 470);
            panel5.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(2, 78);
            panel8.Name = "panel8";
            panel8.Size = new Size(304, 390);
            panel8.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(135, 136, 143);
            panel10.Location = new Point(298, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(6, 390);
            panel10.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(135, 136, 143);
            panel9.Location = new Point(6, 384);
            panel9.Name = "panel9";
            panel9.Size = new Size(298, 6);
            panel9.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 0, 168);
            panel7.Controls.Add(pbMineSweeperLogo);
            panel7.Controls.Add(btnExit);
            panel7.Controls.Add(btnMaximize);
            panel7.Controls.Add(btnMinimize);
            panel7.Controls.Add(pbMineIcon);
            panel7.Location = new Point(2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(308, 36);
            panel7.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Transparent;
            btnExit.Image = Properties.Resources.ExitButton_DefaultState_;
            btnExit.Location = new Point(270, 2);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 3;
            btnExit.TabStop = false;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.Transparent;
            btnMaximize.Image = Properties.Resources.MaximizeButton;
            btnMaximize.Location = new Point(236, 2);
            btnMaximize.Margin = new Padding(0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(32, 32);
            btnMaximize.TabIndex = 2;
            btnMaximize.TabStop = false;
            btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.Transparent;
            btnMinimize.Image = Properties.Resources.MinimizeButton_DefaultState_;
            btnMinimize.Location = new Point(204, 2);
            btnMinimize.Margin = new Padding(0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 32);
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pbMineIcon
            // 
            pbMineIcon.Image = Properties.Resources.MineIcon_32x32_;
            pbMineIcon.Location = new Point(4, 2);
            pbMineIcon.Name = "pbMineIcon";
            pbMineIcon.Size = new Size(32, 32);
            pbMineIcon.TabIndex = 0;
            pbMineIcon.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(135, 136, 145);
            panel6.Location = new Point(1, 474);
            panel6.Name = "panel6";
            panel6.Size = new Size(316, 2);
            panel6.TabIndex = 1;
            // 
            // pbMineSweeperLogo
            // 
            pbMineSweeperLogo.BackColor = Color.Transparent;
            pbMineSweeperLogo.ErrorImage = Properties.Resources.MineSweeperText;
            pbMineSweeperLogo.Image = Properties.Resources.MineSweeperText;
            pbMineSweeperLogo.Location = new Point(42, 8);
            pbMineSweeperLogo.Margin = new Padding(0);
            pbMineSweeperLogo.Name = "pbMineSweeperLogo";
            pbMineSweeperLogo.Size = new Size(149, 23);
            pbMineSweeperLogo.TabIndex = 4;
            pbMineSweeperLogo.TabStop = false;
            pbMineSweeperLogo.Click += pbMineSweeperLogo_Click;
            // 
            // frmMinesweeperMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 199, 200);
            ClientSize = new Size(320, 478);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMinesweeperMain";
            Text = "Minesweeper";
            Load += frmMinesweeperMain_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMineIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMineSweeperLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Panel panel8;
        private Panel panel10;
        private Panel panel9;
        private PictureBox pbMineIcon;
        private Button btnMinimize;
        private Button btnExit;
        private Button btnMaximize;
        private PictureBox pbMineSweeperLogo;
    }
}
