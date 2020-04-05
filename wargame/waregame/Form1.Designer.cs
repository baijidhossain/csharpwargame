namespace waregame
{
    partial class Form1
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
            this.timerBludragon = new System.Windows.Forms.Timer(this.components);
            this.road1 = new System.Windows.Forms.Panel();
            this.timerMissile = new System.Windows.Forms.Timer(this.components);
            this.timerFireBall = new System.Windows.Forms.Timer(this.components);
            this.player_live = new System.Windows.Forms.Label();
            this.live_text = new System.Windows.Forms.Label();
            this.score_point = new System.Windows.Forms.Label();
            this.bishforon = new System.Windows.Forms.PictureBox();
            this.picMissile111 = new System.Windows.Forms.PictureBox();
            this.picMissile11 = new System.Windows.Forms.PictureBox();
            this.picmissile3 = new System.Windows.Forms.PictureBox();
            this.picmissile2 = new System.Windows.Forms.PictureBox();
            this.enemy_tank2 = new System.Windows.Forms.PictureBox();
            this.picMissile1 = new System.Windows.Forms.PictureBox();
            this.track_playercontrol = new System.Windows.Forms.PictureBox();
            this.player_Tank = new System.Windows.Forms.PictureBox();
            this.enemy_tank1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bishforon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_tank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_playercontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_Tank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_tank1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBludragon
            // 
            this.timerBludragon.Enabled = true;
            this.timerBludragon.Interval = 10;
            this.timerBludragon.Tick += new System.EventHandler(this.timerBludragon_Tick);
            // 
            // road1
            // 
            this.road1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.road1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.road1.Location = new System.Drawing.Point(2, 481);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(990, 72);
            this.road1.TabIndex = 0;
            // 
            // timerMissile
            // 
            this.timerMissile.Enabled = true;
            this.timerMissile.Interval = 1;
            this.timerMissile.Tick += new System.EventHandler(this.timerMissile_Tick);
            // 
            // timerFireBall
            // 
            this.timerFireBall.Enabled = true;
            this.timerFireBall.Interval = 10;
            this.timerFireBall.Tick += new System.EventHandler(this.timerFireBall_Tick);
            // 
            // player_live
            // 
            this.player_live.AutoSize = true;
            this.player_live.Location = new System.Drawing.Point(729, 98);
            this.player_live.Name = "player_live";
            this.player_live.Size = new System.Drawing.Size(76, 17);
            this.player_live.TabIndex = 8;
            this.player_live.Text = "player_live";
            // 
            // live_text
            // 
            this.live_text.AutoSize = true;
            this.live_text.BackColor = System.Drawing.Color.Transparent;
            this.live_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.live_text.Location = new System.Drawing.Point(910, 88);
            this.live_text.Name = "live_text";
            this.live_text.Size = new System.Drawing.Size(34, 17);
            this.live_text.TabIndex = 9;
            this.live_text.Text = "Live";
            // 
            // score_point
            // 
            this.score_point.AutoSize = true;
            this.score_point.BackColor = System.Drawing.Color.Transparent;
            this.score_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_point.Location = new System.Drawing.Point(910, 133);
            this.score_point.Name = "score_point";
            this.score_point.Size = new System.Drawing.Size(35, 17);
            this.score_point.TabIndex = 10;
            this.score_point.Text = "scor";
            // 
            // bishforon
            // 
            this.bishforon.BackColor = System.Drawing.Color.Transparent;
            this.bishforon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bishforon.Image = global::waregame.Properties.Resources._8b1b3a0e7a2ff5d84a2248c70a68df19_w200;
            this.bishforon.Location = new System.Drawing.Point(409, 220);
            this.bishforon.Name = "bishforon";
            this.bishforon.Size = new System.Drawing.Size(94, 97);
            this.bishforon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bishforon.TabIndex = 13;
            this.bishforon.TabStop = false;
            // 
            // picMissile111
            // 
            this.picMissile111.Image = global::waregame.Properties.Resources.bullet;
            this.picMissile111.Location = new System.Drawing.Point(488, 410);
            this.picMissile111.Name = "picMissile111";
            this.picMissile111.Size = new System.Drawing.Size(5, 30);
            this.picMissile111.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMissile111.TabIndex = 12;
            this.picMissile111.TabStop = false;
            // 
            // picMissile11
            // 
            this.picMissile11.Image = global::waregame.Properties.Resources.bullet;
            this.picMissile11.Location = new System.Drawing.Point(440, 410);
            this.picMissile11.Name = "picMissile11";
            this.picMissile11.Size = new System.Drawing.Size(5, 30);
            this.picMissile11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMissile11.TabIndex = 11;
            this.picMissile11.TabStop = false;
            // 
            // picmissile3
            // 
            this.picmissile3.Image = global::waregame.Properties.Resources.bullet2;
            this.picmissile3.Location = new System.Drawing.Point(951, 109);
            this.picmissile3.Name = "picmissile3";
            this.picmissile3.Size = new System.Drawing.Size(5, 30);
            this.picmissile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissile3.TabIndex = 7;
            this.picmissile3.TabStop = false;
            // 
            // picmissile2
            // 
            this.picmissile2.Image = global::waregame.Properties.Resources.bullet2;
            this.picmissile2.Location = new System.Drawing.Point(46, 85);
            this.picmissile2.Name = "picmissile2";
            this.picmissile2.Size = new System.Drawing.Size(5, 30);
            this.picmissile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissile2.TabIndex = 6;
            this.picmissile2.TabStop = false;
            // 
            // enemy_tank2
            // 
            this.enemy_tank2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.enemy_tank2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_tank2.Location = new System.Drawing.Point(901, 46);
            this.enemy_tank2.Name = "enemy_tank2";
            this.enemy_tank2.Size = new System.Drawing.Size(69, 32);
            this.enemy_tank2.TabIndex = 5;
            this.enemy_tank2.TabStop = false;
            this.enemy_tank2.Click += new System.EventHandler(this.enemy_tank2_Click);
            // 
            // picMissile1
            // 
            this.picMissile1.Image = global::waregame.Properties.Resources.bullet;
            this.picMissile1.Location = new System.Drawing.Point(464, 410);
            this.picMissile1.Name = "picMissile1";
            this.picMissile1.Size = new System.Drawing.Size(5, 30);
            this.picMissile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMissile1.TabIndex = 4;
            this.picMissile1.TabStop = false;
            // 
            // track_playercontrol
            // 
            this.track_playercontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.track_playercontrol.Location = new System.Drawing.Point(751, 404);
            this.track_playercontrol.Name = "track_playercontrol";
            this.track_playercontrol.Size = new System.Drawing.Size(35, 26);
            this.track_playercontrol.TabIndex = 3;
            this.track_playercontrol.TabStop = false;
            // 
            // player_Tank
            // 
            this.player_Tank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.player_Tank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player_Tank.Location = new System.Drawing.Point(440, 446);
            this.player_Tank.Name = "player_Tank";
            this.player_Tank.Size = new System.Drawing.Size(53, 36);
            this.player_Tank.TabIndex = 2;
            this.player_Tank.TabStop = false;
            // 
            // enemy_tank1
            // 
            this.enemy_tank1.BackColor = System.Drawing.Color.Lime;
            this.enemy_tank1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_tank1.Location = new System.Drawing.Point(2, 12);
            this.enemy_tank1.Name = "enemy_tank1";
            this.enemy_tank1.Size = new System.Drawing.Size(69, 32);
            this.enemy_tank1.TabIndex = 1;
            this.enemy_tank1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.bishforon);
            this.Controls.Add(this.picMissile111);
            this.Controls.Add(this.picMissile11);
            this.Controls.Add(this.score_point);
            this.Controls.Add(this.live_text);
            this.Controls.Add(this.player_live);
            this.Controls.Add(this.picmissile3);
            this.Controls.Add(this.picmissile2);
            this.Controls.Add(this.enemy_tank2);
            this.Controls.Add(this.picMissile1);
            this.Controls.Add(this.track_playercontrol);
            this.Controls.Add(this.player_Tank);
            this.Controls.Add(this.enemy_tank1);
            this.Controls.Add(this.road1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ware game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bishforon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_tank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_playercontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_Tank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_tank1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel road1;
        private System.Windows.Forms.PictureBox enemy_tank1;
        private System.Windows.Forms.Timer timerBludragon;
        private System.Windows.Forms.PictureBox player_Tank;
        private System.Windows.Forms.PictureBox track_playercontrol;
        private System.Windows.Forms.Timer timerMissile;
        private System.Windows.Forms.Timer timerFireBall;
        private System.Windows.Forms.PictureBox picMissile1;
        private System.Windows.Forms.PictureBox enemy_tank2;
        private System.Windows.Forms.PictureBox picmissile2;
        private System.Windows.Forms.PictureBox picmissile3;
        private System.Windows.Forms.Label player_live;
        private System.Windows.Forms.Label live_text;
        private System.Windows.Forms.Label score_point;
        private System.Windows.Forms.PictureBox picMissile11;
        private System.Windows.Forms.PictureBox picMissile111;
        private System.Windows.Forms.PictureBox bishforon;
    }
}

