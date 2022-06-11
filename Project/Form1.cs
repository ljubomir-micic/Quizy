/*
 * Created by SharpDevelop.
 * User: ucenik
 * Date: 6/1/2022
 * Time: 11:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Quizy
{
	public partial class Form1 : Form
	{
		// Исто што и OrderedSet у C++. Биће од помоћи кад треба да се одаберу различите ставке
		// но како је база мала - неће имати ову функцију
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "R5Z4Oj3mHB6GNZvR2p1t9gI0z4qaOIxNwpXp6r0X",
			BasePath = "https://quizy-500b0-default-rtdb.europe-west1.firebasedatabase.app/"
		};
		IFirebaseClient client;
		public static bool isLogged = false;
		int a, b, c, d;
		public static List<PitanjeModel> pitanja;
		private int trenutniBrPitanja;
		double _bodovi = 0.0;
		public static int Elapsed = 9;
		int roundTime = 60;
		public double Bodovi
        {
			get
            {
				return _bodovi;
            }
			set
            {
				_bodovi = value;
				pointsLabel.Text = "" + _bodovi;
				label3.Text = "" + _bodovi;
            }
        }

		Timer timer = new Timer
		{
			Interval = 1000
		};

		public Form1()
		{
			InitializeComponent();
			panel1.BackColor = Colors.accent[0];
			label1.ForeColor = Colors.accent[1];
			roundEdgeButton1.ForeColor = Colors.accent[1];
			roundEdgeButton2.ForeColor = Colors.accent[1];
			playButton.ForeColor = Colors.accent[1];
			roundEdgeButton4.ForeColor = Colors.accent[2];
			roundEdgeButton3.ForeColor = Colors.accent[1];
			roundEdgeButton5.ForeColor = Colors.accent[1];
			roundEdgeButton6.ForeColor = Colors.accent[1];
			aboutButton.ForeColor = Colors.accent[1];
			aboutButton.XOffset = 15;
			tajmer1.textLocation = new Point(18, 10);
			timer.Tick += new System.EventHandler(OnTimerEvent);
		}

		private void OnTimerEvent(object sender, EventArgs e)
		{
			if (roundTime == 0) {
				timer.Enabled = false;
				panel3.Visible = false;
				panel4.Visible = true;
            } else if (Elapsed == 0) {
				roundTime -= 1;
				timer.Enabled = false;
				roundEdgeButton2.PerformClick();
			} else {
				roundTime -= 1;
				Elapsed -= 1;
				tajmer1.Text1 = "" + Elapsed;
            }
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				client = new FireSharp.FirebaseClient(config);
			}
			catch
			{
				MessageBox.Show("Дошло је до проблема са мрежом. Покушајте поново касније.", "Quizy", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			// Оставићу овако, али би за ово требала оцена мање, јер није нађен начин да се обради грешка уколико програм нема интернет конекцију
			pitanja = GetItems();
		}

		protected private List<PitanjeModel> GetItems()
		{
			var result = this.client.Get("Pitanja/");
			List<PitanjeModel> pitanje = result.ResultAs<List<PitanjeModel>>();
			return pitanje;
		}

		void LogoBoxClick(object sender, EventArgs e)
		{
			ProgramInfo pi = new ProgramInfo();
			pi.Show();
		}

        private void roundEdgeButton3_Click(object sender, EventArgs e)
        {
			roundTime = 60;
            Bodovi = 0;
            int broj = QuestionChoose();
            UIInit(broj);

            panel2.Visible = false;
            panel3.Visible = true;
			panel4.Visible = false;

            EnableTimer();
        }

        private void EnableTimer()
        {
			timer.Enabled = false;
			Elapsed = 9;
            tajmer1.Text1 = "" + Elapsed;
            timer.Enabled = true;
        }

        private void UIInit(int i)
        {
            if (pitanja.Count > 0)
            {
				Random random = new Random();
				a = random.Next(0, 4);
				b = random.Next(0, 4);
				c = random.Next(0, 4);
				d = random.Next(0, 4);

				while(b == a)
                {
					b = random.Next(0, 4);
				}

				while (c == a || c == b)
				{
					c = random.Next(0, 4);
				}

				while (d == a || d == b || d == c)
				{
					d = random.Next(0, 4);
				}

				questionLabel.Text = pitanja[i].tekst;
                option1.Text = pitanja[i].odgovori[a].text;
                option2.Text = pitanja[i].odgovori[b].text;
                option3.Text = pitanja[i].odgovori[c].text;
                option4.Text = pitanja[i].odgovori[d].text;
            }

			option1.Checked = false;
			option2.Checked = false;
			option3.Checked = false;
			option4.Checked = false;

			trenutniBrPitanja = i;
		}

        int QuestionChoose()
        {
			Random r = new Random();
			return r.Next(0, pitanja.Count);
        }

		protected void ResetLayout()
        {
			questionLabel.Text = "Питање";
			option1.Text = "опција1";
			option2.Text = "опција2";
			option3.Text = "опција3";
			option4.Text = "опција4";
		}

        private void roundEdgeButton4_Click(object sender, EventArgs e)
		{
			panel2.Visible = !false;
			panel3.Visible = !true;
			panel4.Visible = false;
		}

        private void button1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100007219128523");

		}
		
        private void button2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.instagram.com/ljubomir_micic/");
		}

        private void AddQClick(object sender, EventArgs e)
        {
			AddQuestions aq = new AddQuestions();
			aq.ShowDialog();
        }

        private void roundEdgeButton2_Click(object sender, EventArgs e)
        {
			Bodovi += (option1.Checked == pitanja[trenutniBrPitanja].odgovori[a].tacnost &&
				option2.Checked == pitanja[trenutniBrPitanja].odgovori[b].tacnost &&
				option3.Checked == pitanja[trenutniBrPitanja].odgovori[c].tacnost &&
				option4.Checked == pitanja[trenutniBrPitanja].odgovori[d].tacnost) ? 1 : 0;

			int broj = QuestionChoose();
			UIInit(broj);
			EnableTimer();
		}

        private void roundEdgeButton3_Click_1(object sender, EventArgs e)
        {
			panel2.Visible = true;
			panel3.Visible = false;
			panel4.Visible = false;
		}

        private void roundEdgeButton5_Click(object sender, EventArgs e)
		{
			panel2.Visible = false;
			panel3.Visible = true;
			panel4.Visible = false;
			roundTime = 60;
			Bodovi = 0;
			int broj = QuestionChoose();
			UIInit(broj);
			EnableTimer();
		}
    }
}
