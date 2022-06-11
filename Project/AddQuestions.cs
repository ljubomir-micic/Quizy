using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy
{
    public partial class AddQuestions : Form
    {
        List<PitanjeModel> pitanjeModel = new List<PitanjeModel>();
        int xoff1 = 0;
        string t1 = "";

        public AddQuestions()
        {
            InitializeComponent();
            roundEdgeButton1.ForeColor = Colors.accent[1];
            roundEdgeButton2.ForeColor = Colors.accent[3];
            xoff1 = roundEdgeButton2.XOffset;
            t1 = roundEdgeButton2.Text;
            roundEdgeButton2.Text = "Изађи";
            roundEdgeButton2.XOffset = 0;
            menuStrip1.BackColor = Colors.accent[0];
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (pitanjeModel.Count > 0)
                foreach (var pM in pitanjeModel)
                {
                    Form1.pitanja.Add(pM);
                }
        }

        private void roundEdgeButton1_Click(object sender, EventArgs e)
        {
            if (String.Empty != textBox1.Text || String.Empty != textBox2.Text || String.Empty != textBox3.Text ||
                String.Empty != textBox4.Text || String.Empty != textBox5.Text)
            {
                pitanjeModel.Add(new PitanjeModel
                {
                    tekst = textBox1.Text,
                    odgovori = new Odgovor[] {
                        new Odgovor
                        {
                            text = textBox2.Text,
                            tacnost = customCheckBox1.Checked
                        },
                        new Odgovor
                        {
                            text = textBox3.Text,
                            tacnost = customCheckBox2.Checked
                        },
                        new Odgovor
                        {
                            text = textBox4.Text,
                            tacnost = customCheckBox3.Checked
                        },
                        new Odgovor
                        {
                            text = textBox5.Text,
                            tacnost = customCheckBox4.Checked
                        }
                    }
                });

                roundEdgeButton2.Text = t1;
                roundEdgeButton2.XOffset = xoff1;
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                customCheckBox1.Checked = false;
                textBox3.Text = String.Empty;
                customCheckBox2.Checked = false;
                textBox4.Text = String.Empty;
                customCheckBox3.Checked = false;
                textBox5.Text = String.Empty;
                customCheckBox4.Checked = false;
            }
            /*else
            {
                System.Diagnostics.Debug.WriteLine("Неки од TextBox-ова је празан.");
            }*/
        }

        private void roundEdgeButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сачувајУФајлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Quizy документ|*.qzy";
            saveFileDialog.Title = "Quizy: Чување новододатих питања";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var pitanje in pitanjeModel)
                    {
                        streamWriter.WriteLine(pitanje.tekst + "\n"
                            + pitanje.odgovori[0].text + "\n" + pitanje.odgovori[0].tacnost + "\n"
                            + pitanje.odgovori[1].text + "\n" + pitanje.odgovori[1].tacnost + "\n"
                            + pitanje.odgovori[2].text + "\n" + pitanje.odgovori[2].tacnost + "\n"
                            + pitanje.odgovori[3].text + "\n" + pitanje.odgovori[3].tacnost);
                    }
                }
            }
        }

        private void учитајИзФајлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                using (System.IO.StreamReader streamReader = new System.IO.StreamReader(openFileDialog.FileName))
                {
                    while(!streamReader.EndOfStream)
                    {
                        pitanjeModel.Add(new PitanjeModel
                        {
                            tekst = streamReader.ReadLine(),
                            odgovori = new Odgovor[] {
                                new Odgovor
                                {
                                    text = streamReader.ReadLine(),
                                    tacnost = Convert.ToBoolean(streamReader.ReadLine())
                                },
                                new Odgovor
                                {
                                    text = streamReader.ReadLine(),
                                    tacnost = Convert.ToBoolean(streamReader.ReadLine())
                                },
                                new Odgovor
                                {
                                    text = streamReader.ReadLine(),
                                    tacnost = Convert.ToBoolean(streamReader.ReadLine())
                                },
                                new Odgovor
                                {
                                    text = streamReader.ReadLine(),
                                    tacnost = Convert.ToBoolean(streamReader.ReadLine())
                                }
                            }
                        });

                        roundEdgeButton2.Text = t1;
                        roundEdgeButton2.XOffset = xoff1;
                    }
                }
            }
        }
    }
}
