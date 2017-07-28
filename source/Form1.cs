using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_Game
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer s = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            string text = QuestionGenerator.Generate();
            label1.Text = text;
            s.SelectVoiceByHints(VoiceGender.Female);
            s.SpeakAsync(text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int converted;
            if (text != "" && text != " ")
            {
                try
                {
                    converted = Convert.ToInt32(text);
                    if (converted == QuestionGenerator.answer)
                    {
                        s.SpeakAsyncCancelAll();
                        textBox1.Text = "";
                        string txt = QuestionGenerator.Generate();
                        label1.Text = txt;
                        s.SpeakAsyncCancelAll();
                        s.SpeakAsync(txt);
                    }
                    else
                    {
                        s.SpeakAsyncCancelAll();
                        s.SpeakAsync("No. Try again.");
                    }
                }
                catch (Exception n)
                {
                    s.SpeakAsyncCancelAll();
                    s.SpeakAsync("You idiot! " + text + " is not a number.");
                }
            }
            else
            {
                s.SpeakAsyncCancelAll();
                s.SpeakAsync("You didn't enter anything.");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}