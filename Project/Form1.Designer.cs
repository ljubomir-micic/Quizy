/*
 * Created by SharpDevelop.
 * User: ucenik
 * Date: 6/1/2022
 * Time: 11:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Quizy
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox logoBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundEdgeButton6 = new Quizy.RoundEdgeButton();
            this.aboutButton = new Quizy.RoundEdgeButton();
            this.playButton = new Quizy.RoundEdgeButton();
            this.tajmer1 = new Quizy.Tajmer();
            this.roundEdgeButton2 = new Quizy.RoundEdgeButton();
            this.roundEdgeButton4 = new Quizy.RoundEdgeButton();
            this.roundEdgeButton1 = new Quizy.RoundEdgeButton();
            this.option4 = new Quizy.CustomCheckBox();
            this.option3 = new Quizy.CustomCheckBox();
            this.option2 = new Quizy.CustomCheckBox();
            this.option1 = new Quizy.CustomCheckBox();
            this.roundEdgeButton5 = new Quizy.RoundEdgeButton();
            this.roundEdgeButton3 = new Quizy.RoundEdgeButton();
            this.divider1 = new Quizy.Divider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.divider1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logoBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 561);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(187, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 27);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(155, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 27);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quizy";
            // 
            // logoBox
            // 
            this.logoBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBox.BackgroundImage")));
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Location = new System.Drawing.Point(13, 6);
            this.logoBox.Name = "logoBox";
            this.logoBox.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.logoBox.Size = new System.Drawing.Size(59, 72);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.LogoBoxClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.roundEdgeButton6);
            this.panel2.Controls.Add(this.aboutButton);
            this.panel2.Controls.Add(this.playButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 561);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(192, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро дошли!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tajmer1);
            this.panel3.Controls.Add(this.roundEdgeButton2);
            this.panel3.Controls.Add(this.roundEdgeButton4);
            this.panel3.Controls.Add(this.roundEdgeButton1);
            this.panel3.Controls.Add(this.option4);
            this.panel3.Controls.Add(this.option3);
            this.panel3.Controls.Add(this.option2);
            this.panel3.Controls.Add(this.option1);
            this.panel3.Controls.Add(this.pointsLabel);
            this.panel3.Controls.Add(this.questionLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 561);
            this.panel3.TabIndex = 2;
            // 
            // pointsLabel
            // 
            this.pointsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(219, 58);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(325, 76);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "бодови";
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(42, 199);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(679, 28);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Питање";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.roundEdgeButton5);
            this.panel4.Controls.Add(this.roundEdgeButton3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(221, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 561);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "бодова";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(730, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundEdgeButton6
            // 
            this.roundEdgeButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundEdgeButton6.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.roundEdgeButton6.ForeColor = System.Drawing.Color.Blue;
            this.roundEdgeButton6.IsShowingText = true;
            this.roundEdgeButton6.Location = new System.Drawing.Point(275, 333);
            this.roundEdgeButton6.Name = "roundEdgeButton6";
            this.roundEdgeButton6.Size = new System.Drawing.Size(213, 55);
            this.roundEdgeButton6.TabIndex = 2;
            this.roundEdgeButton6.Text = "Додај питања";
            this.roundEdgeButton6.UseVisualStyleBackColor = true;
            this.roundEdgeButton6.XOffset = 20;
            this.roundEdgeButton6.Click += new System.EventHandler(this.AddQClick);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.aboutButton.ForeColor = System.Drawing.Color.Blue;
            this.aboutButton.IsShowingText = true;
            this.aboutButton.Location = new System.Drawing.Point(275, 394);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(213, 55);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "О програму";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.XOffset = 0;
            this.aboutButton.Click += new System.EventHandler(this.LogoBoxClick);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.Color.Blue;
            this.playButton.IsShowingText = true;
            this.playButton.Location = new System.Drawing.Point(275, 272);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(213, 55);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Играј";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.XOffset = 0;
            this.playButton.Click += new System.EventHandler(this.roundEdgeButton3_Click);
            // 
            // tajmer1
            // 
            this.tajmer1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tajmer1.Location = new System.Drawing.Point(6, 6);
            this.tajmer1.Name = "tajmer1";
            this.tajmer1.Size = new System.Drawing.Size(60, 57);
            this.tajmer1.TabIndex = 4;
            this.tajmer1.Text1 = "0";
            this.tajmer1.textLocation = new System.Drawing.Point(18, 10);
            this.tajmer1.totalTimerTime = 0D;
            // 
            // roundEdgeButton2
            // 
            this.roundEdgeButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.roundEdgeButton2.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.roundEdgeButton2.ForeColor = System.Drawing.Color.Blue;
            this.roundEdgeButton2.IsShowingText = true;
            this.roundEdgeButton2.Location = new System.Drawing.Point(384, 439);
            this.roundEdgeButton2.Name = "roundEdgeButton2";
            this.roundEdgeButton2.Size = new System.Drawing.Size(171, 38);
            this.roundEdgeButton2.TabIndex = 3;
            this.roundEdgeButton2.Text = "▶️";
            this.roundEdgeButton2.UseVisualStyleBackColor = true;
            this.roundEdgeButton2.XOffset = 0;
            this.roundEdgeButton2.Click += new System.EventHandler(this.roundEdgeButton2_Click);
            // 
            // roundEdgeButton4
            // 
            this.roundEdgeButton4.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.roundEdgeButton4.ForeColor = System.Drawing.Color.Orange;
            this.roundEdgeButton4.IsShowingText = true;
            this.roundEdgeButton4.Location = new System.Drawing.Point(7, 525);
            this.roundEdgeButton4.Name = "roundEdgeButton4";
            this.roundEdgeButton4.Size = new System.Drawing.Size(70, 29);
            this.roundEdgeButton4.TabIndex = 3;
            this.roundEdgeButton4.Text = "❌";
            this.roundEdgeButton4.UseVisualStyleBackColor = true;
            this.roundEdgeButton4.XOffset = 0;
            this.roundEdgeButton4.Click += new System.EventHandler(this.roundEdgeButton4_Click);
            // 
            // roundEdgeButton1
            // 
            this.roundEdgeButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.roundEdgeButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.roundEdgeButton1.ForeColor = System.Drawing.Color.Blue;
            this.roundEdgeButton1.IsShowingText = true;
            this.roundEdgeButton1.Location = new System.Drawing.Point(207, 439);
            this.roundEdgeButton1.Name = "roundEdgeButton1";
            this.roundEdgeButton1.Size = new System.Drawing.Size(171, 38);
            this.roundEdgeButton1.TabIndex = 3;
            this.roundEdgeButton1.Text = "◀️";
            this.roundEdgeButton1.UseVisualStyleBackColor = true;
            this.roundEdgeButton1.XOffset = 0;
            // 
            // option4
            // 
            this.option4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.option4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.option4.Location = new System.Drawing.Point(79, 336);
            this.option4.Name = "option4";
            this.option4.onChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option4.Size = new System.Drawing.Size(642, 26);
            this.option4.TabIndex = 2;
            this.option4.Text = "customCheckBox1";
            this.option4.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.option3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.option3.Location = new System.Drawing.Point(79, 304);
            this.option3.Name = "option3";
            this.option3.onChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option3.Size = new System.Drawing.Size(642, 26);
            this.option3.TabIndex = 2;
            this.option3.Text = "customCheckBox1";
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.option2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.option2.Location = new System.Drawing.Point(79, 272);
            this.option2.Name = "option2";
            this.option2.onChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option2.Size = new System.Drawing.Size(642, 26);
            this.option2.TabIndex = 2;
            this.option2.Text = "customCheckBox1";
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option1
            // 
            this.option1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.option1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(79, 240);
            this.option1.Name = "option1";
            this.option1.onChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))));
            this.option1.Size = new System.Drawing.Size(642, 26);
            this.option1.TabIndex = 2;
            this.option1.Text = "customCheckBox1";
            this.option1.UseVisualStyleBackColor = true;
            // 
            // roundEdgeButton5
            // 
            this.roundEdgeButton5.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold);
            this.roundEdgeButton5.ForeColor = System.Drawing.Color.Blue;
            this.roundEdgeButton5.IsShowingText = true;
            this.roundEdgeButton5.Location = new System.Drawing.Point(285, 340);
            this.roundEdgeButton5.Name = "roundEdgeButton5";
            this.roundEdgeButton5.Size = new System.Drawing.Size(193, 51);
            this.roundEdgeButton5.TabIndex = 2;
            this.roundEdgeButton5.Text = "Почетни екран";
            this.roundEdgeButton5.UseVisualStyleBackColor = true;
            this.roundEdgeButton5.XOffset = 9;
            this.roundEdgeButton5.Click += new System.EventHandler(this.roundEdgeButton3_Click_1);
            // 
            // roundEdgeButton3
            // 
            this.roundEdgeButton3.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold);
            this.roundEdgeButton3.ForeColor = System.Drawing.Color.Blue;
            this.roundEdgeButton3.IsShowingText = true;
            this.roundEdgeButton3.Location = new System.Drawing.Point(285, 279);
            this.roundEdgeButton3.Name = "roundEdgeButton3";
            this.roundEdgeButton3.Size = new System.Drawing.Size(193, 51);
            this.roundEdgeButton3.TabIndex = 2;
            this.roundEdgeButton3.Text = "Нова игра";
            this.roundEdgeButton3.UseVisualStyleBackColor = true;
            this.roundEdgeButton3.XOffset = 7;
            this.roundEdgeButton3.Click += new System.EventHandler(this.roundEdgeButton5_Click);
            // 
            // divider1
            // 
            this.divider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider1.Location = new System.Drawing.Point(4, 516);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(212, 2);
            this.divider1.TabIndex = 3;
            this.divider1.Text = "divider1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

		}
		private Quizy.RoundEdgeButton roundEdgeButton1;
		private Quizy.RoundEdgeButton roundEdgeButton2;
		private System.Windows.Forms.Label questionLabel;
		private System.Windows.Forms.Label pointsLabel;
		private Quizy.CustomCheckBox option1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
        private RoundEdgeButton roundEdgeButton4;
        private CustomCheckBox option4;
        private CustomCheckBox option3;
        private CustomCheckBox option2;
        private RoundEdgeButton playButton;
        private RoundEdgeButton aboutButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Quizy.Divider divider1;
        private Tajmer tajmer1;
        private System.Windows.Forms.Panel panel4;
        private RoundEdgeButton roundEdgeButton5;
        private RoundEdgeButton roundEdgeButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private RoundEdgeButton roundEdgeButton6;
    }
}
