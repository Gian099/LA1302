namespace DnDRPG
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
            this.button1 = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.playerhealth = new System.Windows.Forms.Label();
            this.enemyhealth1 = new System.Windows.Forms.Label();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemyhealth2 = new System.Windows.Forms.Label();
            this.enemyhealth4 = new System.Windows.Forms.Label();
            this.enemyhealth3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.enemycontext = new System.Windows.Forms.RichTextBox();
            this.enemycontext2 = new System.Windows.Forms.RichTextBox();
            this.enemycontext3 = new System.Windows.Forms.RichTextBox();
            this.enemycontext4 = new System.Windows.Forms.RichTextBox();
            this.context = new System.Windows.Forms.RichTextBox();
            this.losingscreen = new System.Windows.Forms.PictureBox();
            this.losingtext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.losingscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(659, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::DnDRPG.Resources.images.mage;
            this.player.Location = new System.Drawing.Point(36, 240);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(158, 144);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::DnDRPG.Resources.images.Goblin;
            this.enemy2.Location = new System.Drawing.Point(536, 240);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(129, 131);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 5;
            this.enemy2.TabStop = false;
            // 
            // playerhealth
            // 
            this.playerhealth.AutoSize = true;
            this.playerhealth.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerhealth.Location = new System.Drawing.Point(75, 201);
            this.playerhealth.Name = "playerhealth";
            this.playerhealth.Size = new System.Drawing.Size(52, 21);
            this.playerhealth.TabIndex = 6;
            this.playerhealth.Text = "label1";
            this.playerhealth.Click += new System.EventHandler(this.label1_Click);
            // 
            // enemyhealth1
            // 
            this.enemyhealth1.AutoSize = true;
            this.enemyhealth1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyhealth1.Location = new System.Drawing.Point(698, 201);
            this.enemyhealth1.Name = "enemyhealth1";
            this.enemyhealth1.Size = new System.Drawing.Size(52, 21);
            this.enemyhealth1.TabIndex = 7;
            this.enemyhealth1.Text = "label2";
            // 
            // enemy3
            // 
            this.enemy3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Image = global::DnDRPG.Resources.images.Goblin;
            this.enemy3.Location = new System.Drawing.Point(401, 240);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(129, 144);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 9;
            this.enemy3.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy4.BackColor = System.Drawing.Color.Transparent;
            this.enemy4.Image = global::DnDRPG.Resources.images.Goblin;
            this.enemy4.Location = new System.Drawing.Point(262, 250);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(140, 134);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 10;
            this.enemy4.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::DnDRPG.Resources.images.Goblin;
            this.enemy1.Location = new System.Drawing.Point(659, 240);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(133, 131);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 11;
            this.enemy1.TabStop = false;
            // 
            // enemyhealth2
            // 
            this.enemyhealth2.AutoSize = true;
            this.enemyhealth2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyhealth2.Location = new System.Drawing.Point(574, 201);
            this.enemyhealth2.Name = "enemyhealth2";
            this.enemyhealth2.Size = new System.Drawing.Size(52, 21);
            this.enemyhealth2.TabIndex = 12;
            this.enemyhealth2.Text = "label1";
            // 
            // enemyhealth4
            // 
            this.enemyhealth4.AutoSize = true;
            this.enemyhealth4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyhealth4.Location = new System.Drawing.Point(305, 201);
            this.enemyhealth4.Name = "enemyhealth4";
            this.enemyhealth4.Size = new System.Drawing.Size(52, 21);
            this.enemyhealth4.TabIndex = 14;
            this.enemyhealth4.Text = "label3";
            // 
            // enemyhealth3
            // 
            this.enemyhealth3.AutoSize = true;
            this.enemyhealth3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyhealth3.Location = new System.Drawing.Point(429, 201);
            this.enemyhealth3.Name = "enemyhealth3";
            this.enemyhealth3.Size = new System.Drawing.Size(52, 21);
            this.enemyhealth3.TabIndex = 13;
            this.enemyhealth3.Text = "label4";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(540, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "Attack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(401, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 17;
            this.button3.Text = "Attack";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(272, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 18;
            this.button4.Text = "Attack";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // enemycontext
            // 
            this.enemycontext.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemycontext.Location = new System.Drawing.Point(659, 32);
            this.enemycontext.Name = "enemycontext";
            this.enemycontext.Size = new System.Drawing.Size(113, 100);
            this.enemycontext.TabIndex = 19;
            this.enemycontext.Text = "";
            // 
            // enemycontext2
            // 
            this.enemycontext2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemycontext2.Location = new System.Drawing.Point(540, 32);
            this.enemycontext2.Name = "enemycontext2";
            this.enemycontext2.Size = new System.Drawing.Size(113, 100);
            this.enemycontext2.TabIndex = 20;
            this.enemycontext2.Text = "";
            // 
            // enemycontext3
            // 
            this.enemycontext3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemycontext3.Location = new System.Drawing.Point(401, 32);
            this.enemycontext3.Name = "enemycontext3";
            this.enemycontext3.Size = new System.Drawing.Size(113, 100);
            this.enemycontext3.TabIndex = 21;
            this.enemycontext3.Text = "";
            // 
            // enemycontext4
            // 
            this.enemycontext4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemycontext4.Location = new System.Drawing.Point(272, 32);
            this.enemycontext4.Name = "enemycontext4";
            this.enemycontext4.Size = new System.Drawing.Size(113, 100);
            this.enemycontext4.TabIndex = 22;
            this.enemycontext4.Text = "";
            // 
            // context
            // 
            this.context.BackColor = System.Drawing.Color.White;
            this.context.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.context.Location = new System.Drawing.Point(36, 68);
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(125, 120);
            this.context.TabIndex = 23;
            this.context.Text = "";
            // 
            // losingscreen
            // 
            this.losingscreen.BackgroundImage = global::DnDRPG.Properties.Resources.losingscreen;
            this.losingscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.losingscreen.Location = new System.Drawing.Point(-3, -8);
            this.losingscreen.Name = "losingscreen";
            this.losingscreen.Size = new System.Drawing.Size(806, 462);
            this.losingscreen.TabIndex = 24;
            this.losingscreen.TabStop = false;
            // 
            // losingtext
            // 
            this.losingtext.AutoSize = true;
            this.losingtext.Location = new System.Drawing.Point(352, 181);
            this.losingtext.Name = "losingtext";
            this.losingtext.Size = new System.Drawing.Size(0, 20);
            this.losingtext.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DnDRPG.Resources.images.grass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.losingtext);
            this.Controls.Add(this.losingscreen);
            this.Controls.Add(this.context);
            this.Controls.Add(this.enemycontext4);
            this.Controls.Add(this.enemycontext3);
            this.Controls.Add(this.enemycontext2);
            this.Controls.Add(this.enemycontext);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enemyhealth4);
            this.Controls.Add(this.enemyhealth3);
            this.Controls.Add(this.enemyhealth2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemyhealth1);
            this.Controls.Add(this.playerhealth);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.losingscreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private PictureBox player;
        private PictureBox enemy2;
        private Label playerhealth;
        private Label enemyhealth1;
        private PictureBox enemy3;
        private PictureBox enemy4;
        private PictureBox enemy1;
        private Label enemyhealth2;
        private Label enemyhealth4;
        private Label enemyhealth3;
        private Button button2;
        private Button button3;
        private Button button4;
        private RichTextBox enemycontext;
        private RichTextBox enemycontext2;
        private RichTextBox enemycontext3;
        private RichTextBox enemycontext4;
        private RichTextBox context;
        private PictureBox losingscreen;
        private Label losingtext;
    }
}