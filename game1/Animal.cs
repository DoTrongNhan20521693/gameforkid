using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace game1
{
    public partial class Animal : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        public int Numbrd = 0;
        public List<int> ListRand = new List<int>();
        public Random rd = new Random();
        private int counter = 20;
        public int question = 1;
        public int points = 0;
        public string pic = "", ans = "";
        public Animal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (btn_Submit.Text == "Next")
            {
                btn_Submit.Focus();
                NextQuestion();
                txt_Answer.Focus();
            }
            else if (btn_Submit.Text == "Check")
            {
                CheckYourAnswer();
            }
            else if (btn_Submit.Text == "Home")
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
                this.Close();

            }
        }

        private void Animal_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Animals.xml");
            nodeList = xmlDoc.SelectNodes("animals" + "/animal");

            StartLevel();
        }
        public void CheckYourAnswer()
        {
            if (txt_Answer.Text.Trim().ToLower() == lbl_Answer.Text.Trim().ToLower())
            {
                CorrectAnswer();
            }
            else
            {
                IncorrectAnswer();
            }
        }
        public void StartLevel()
        {
            GetRandom();
            pic = nodeList[ListRand[0]].SelectSingleNode("name").InnerText.Trim() + ".jpg";
            ans = nodeList[ListRand[0]].SelectSingleNode("name").InnerText.Trim();

            picWord.BackgroundImage = Image.FromFile(@"..\\..\\pictures in use\Animals\" + pic);
            lbl_Answer.Text = ans;

            //lbl_QuestionNumb.Text = "Question number " + question;

            txt_Answer.Enabled = true;

            //lbl_CorrectAns.Visible = false;


            counter = 30;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lbl_Time.Text = counter.ToString();
        }
        public void


            YourAnswer()
        {
            if (txt_Answer.Text.Trim().ToLower() == lbl_Answer.Text.Trim().ToLower())
            {
                CorrectAnswer();
            }
            else
            {
                IncorrectAnswer();
            }
        }
        public void NextQuestion()
        {
            txt_Answer.Enabled = true;
            btn_Submit.Text = "Check";
            //lbl_CorrectAns.Visible = false;
            btn_Answer.Visible = false;
            pic = nodeList[ListRand[question - 1]].SelectSingleNode("name").InnerText.Trim() + ".jpg";
            ans = nodeList[ListRand[question - 1]].SelectSingleNode("name").InnerText.Trim();
            picWord.BackgroundImage = Image.FromFile(@"..\\..\\pictures in use\Animals\" + pic);
            lbl_Answer.Text = ans;
            txt_Answer.ForeColor = Color.Black;
            txt_Answer.Text = "";
        }

        public void CorrectAnswer()
        {
            txt_Answer.Enabled = false;


            question++;
            btn_Submit.Text = "Next";
            points += 10;

            lbl_Score.Text = points.ToString();
            txt_Answer.Enabled = true;
            txt_Answer.ForeColor = Color.Green;
            if (question == 6)
            {
                btn_Submit.Text = "Home";
            }
        }

        public void IncorrectAnswer()
        {
            question++;
            //txt_Answer.Enabled = false;
            btn_Submit.Text = "Next";
            btn_Answer.Text = lbl_Answer.Text;
            btn_Answer.Visible = true;
            txt_Answer.ForeColor = Color.Red;
            btn_Submit.Focus();
            if (question == 6)
            {
                btn_Submit.Text = "Home";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                txt_Answer.Enabled = false;
                btn_Submit.Text = "Home";
            }
            lbl_Time.Text = counter.ToString();
        }

        private void lbl_CorrectAns_Click(object sender, EventArgs e)
        {

        }

        public void GetRandom()
        {
            int i = 0;
            while (i < 5)
            {
                Numbrd = rd.Next(0, nodeList.Count - 1);
                if (ListRand.Contains(Numbrd) == false)
                {
                    ListRand.Add(Numbrd);
                    i++;
                }
            }
        }
        public string GetScore
        {
            get { return lbl_Score.Text; }
        }
    }
}

