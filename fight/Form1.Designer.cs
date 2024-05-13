namespace fight
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            NamePlayer = new Label();
            NameHp = new Label();
            NameDamage = new Label();
            NameEnemy = new Label();
            NameHpEnemy = new Label();
            NameDamageEnemy = new Label();
            NameModefi = new Label();
            NameModefiEnemy = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Resource1.hero;
            pictureBox1.Location = new Point(35, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Resource1.enemy;
            pictureBox2.Location = new Point(706, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(325, 301);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21F);
            button1.Location = new Point(35, 509);
            button1.Name = "button1";
            button1.Size = new Size(126, 100);
            button1.TabIndex = 2;
            button1.Text = "Атака";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 21F);
            button2.Location = new Point(167, 509);
            button2.Name = "button2";
            button2.Size = new Size(139, 100);
            button2.TabIndex = 3;
            button2.Text = "Лечение";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 21F);
            button3.Location = new Point(312, 509);
            button3.Name = "button3";
            button3.Size = new Size(139, 100);
            button3.TabIndex = 3;
            button3.Text = "Стан";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 21F);
            button4.Location = new Point(457, 509);
            button4.Name = "button4";
            button4.Size = new Size(139, 100);
            button4.TabIndex = 3;
            button4.Text = "Обратка";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 21F);
            button5.Location = new Point(602, 509);
            button5.Name = "button5";
            button5.Size = new Size(139, 100);
            button5.TabIndex = 3;
            button5.Text = "Инвиз";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 21F);
            button6.Location = new Point(747, 509);
            button6.Name = "button6";
            button6.Size = new Size(139, 100);
            button6.TabIndex = 3;
            button6.Text = "ДД";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 21F);
            button7.Location = new Point(892, 509);
            button7.Name = "button7";
            button7.Size = new Size(139, 100);
            button7.TabIndex = 3;
            button7.Text = "Мисы";
            button7.UseVisualStyleBackColor = true;
            // 
            // NamePlayer
            // 
            NamePlayer.AutoSize = true;
            NamePlayer.Font = new Font("Segoe UI", 22F);
            NamePlayer.Location = new Point(35, 1);
            NamePlayer.Name = "NamePlayer";
            NamePlayer.Size = new Size(104, 41);
            NamePlayer.TabIndex = 4;
            NamePlayer.Text = "Yasper";
            // 
            // NameHp
            // 
            NameHp.AutoSize = true;
            NameHp.Font = new Font("Segoe UI", 22F);
            NameHp.Location = new Point(35, 42);
            NameHp.Name = "NameHp";
            NameHp.Size = new Size(57, 41);
            NameHp.TabIndex = 4;
            NameHp.Text = "Hp";
            // 
            // NameDamage
            // 
            NameDamage.AutoSize = true;
            NameDamage.Font = new Font("Segoe UI", 22F);
            NameDamage.Location = new Point(35, 83);
            NameDamage.Name = "NameDamage";
            NameDamage.Size = new Size(129, 41);
            NameDamage.TabIndex = 4;
            NameDamage.Text = "Damage";
            // 
            // NameEnemy
            // 
            NameEnemy.AutoSize = true;
            NameEnemy.Font = new Font("Segoe UI", 22F);
            NameEnemy.Location = new Point(876, 9);
            NameEnemy.Name = "NameEnemy";
            NameEnemy.Size = new Size(161, 41);
            NameEnemy.TabIndex = 4;
            NameEnemy.Text = "IgorFashist";
            // 
            // NameHpEnemy
            // 
            NameHpEnemy.AutoSize = true;
            NameHpEnemy.Font = new Font("Segoe UI", 22F);
            NameHpEnemy.Location = new Point(960, 50);
            NameHpEnemy.Name = "NameHpEnemy";
            NameHpEnemy.Size = new Size(57, 41);
            NameHpEnemy.TabIndex = 4;
            NameHpEnemy.Text = "Hp";
            // 
            // NameDamageEnemy
            // 
            NameDamageEnemy.AutoSize = true;
            NameDamageEnemy.Font = new Font("Segoe UI", 22F);
            NameDamageEnemy.Location = new Point(902, 91);
            NameDamageEnemy.Name = "NameDamageEnemy";
            NameDamageEnemy.Size = new Size(129, 41);
            NameDamageEnemy.TabIndex = 4;
            NameDamageEnemy.Text = "Damage";
            // 
            // NameModefi
            // 
            NameModefi.AutoSize = true;
            NameModefi.Font = new Font("Segoe UI", 22F);
            NameModefi.Location = new Point(35, 133);
            NameModefi.Name = "NameModefi";
            NameModefi.Size = new Size(113, 41);
            NameModefi.TabIndex = 4;
            NameModefi.Text = "Modefi";
            // 
            // NameModefiEnemy
            // 
            NameModefiEnemy.AutoSize = true;
            NameModefiEnemy.Font = new Font("Segoe UI", 22F);
            NameModefiEnemy.Location = new Point(918, 133);
            NameModefiEnemy.Name = "NameModefiEnemy";
            NameModefiEnemy.Size = new Size(113, 41);
            NameModefiEnemy.TabIndex = 4;
            NameModefiEnemy.Text = "Modefi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 621);
            Controls.Add(NameDamageEnemy);
            Controls.Add(NameHpEnemy);
            Controls.Add(NameEnemy);
            Controls.Add(NameModefiEnemy);
            Controls.Add(NameModefi);
            Controls.Add(NameDamage);
            Controls.Add(NameHp);
            Controls.Add(NamePlayer);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label NamePlayer;
        private Label NameHp;
        private Label NameDamage;
        private Label NameEnemy;
        private Label NameHpEnemy;
        private Label NameDamageEnemy;
        private Label NameModefi;
        private Label NameModefiEnemy;
    }
}
