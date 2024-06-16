using System;
using System.Text;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int questionsCounter = 0;


        private readonly List<Question> questions;


        public Form1()
        {

            questions = new List<Question>()
            {
                new Question()
                {
                    Text = "������� 1: �� ���� C#?",
                    Answer = "���� �������������",
                    Wrongs = new string[] { "���������� ��������", "���������� �������", "���� �����" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 2: �� ���� .NET?",
                    Answer = "���������",
                    Wrongs = new[] { "���� �������������", "��������� ��������", "��������� ��������" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 3: ��� ������� Windows?",
                    Answer = "Microsoft",
                    Wrongs = new string[] { "Apple", "Google", "Facebook" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 4: ���� ��������� ����� � ���?",
                    Answer = "�����",
                    Wrongs = new string[] {"�����������", "���������", "ϳ������ ����������" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 5: ��� � ������� '���� ������'?",
                    Answer = "����� ������",
                    Wrongs = new string[] { "����� ʳ��",  "���� ����", "����� ����" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 6: ��� ������� ������?",
                    Answer = "���",
                    Wrongs = new string[] { "����",  "�����", "�����" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 7: �� ���� HTML?",
                    Answer = "���� �������",
                    Wrongs = new string[] { "�������� �������� �����", "���������� �������", "���� �����" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 8: ��� ������� �������� � ������� ������?",
                    Answer = "�����",
                    Wrongs = new string[] { "�����", "����",  "������" },
                    Status = false
                },
                new Question()
                {
                    Text = "������� 9: ���� ������� ������� �� ������ 'O'?",
                    Answer =  "ó������",
                    Wrongs = new string[] {  "������", "�������", "ͳ������" },
                    Status = false
                },
                 new Question()
                {
                    Text = "������� 10: ������ ���������� �� ����?",
                    Answer =  "7",
                    Wrongs = new string[] { "5", "6", "8" },
                    Status = false
                },
            };

            InitializeComponent();
            lblScore.Text = $"���������� ��������: {score}";

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (questionsCounter < questions.Count)
            {

                lblScore.Text = $"���������� ��������: {score}";
                rbOption1.Checked = false;
                rbOption2.Checked = false;
                rbOption3.Checked = false;
                rbOption4.Checked = false;

            }
            else
            {
                MessageBox.Show("asdad");
                lblQuestion.Text = $"³������� ���������! ��� �������: {score}/{questions.Count}";
                btnNext.Enabled = false;
                btnNext.Visible = false;
                rbOption1.Visible = false;
                rbOption2.Visible = false;
                rbOption3.Visible = false;
                rbOption4.Visible = false;

            }

            lblQuestion.Text = questions[questionsCounter].Text;
            List<string> tempWrongs = questions[questionsCounter].Wrongs.ToList();
            tempWrongs.Add(questions[questionsCounter].Answer);


            Random rnd = new Random();
            for (int i = tempWrongs.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (tempWrongs[i], tempWrongs[j]) = (tempWrongs[j], tempWrongs[i]);
            }

            rbOption1.Text = tempWrongs[0];
            rbOption2.Text = tempWrongs[1];
            rbOption3.Text = tempWrongs[2];
            rbOption4.Text = tempWrongs[3];


            if (rbOption1.Checked)
            {
                if (rbOption1.Text == questions[questionsCounter].Answer)
                {
                    score++; questions[questionsCounter].Status = true;
                }
            }
            else
            if (rbOption2.Checked) {
                if (rbOption1.Text == questions[questionsCounter].Answer)
                {
                    score++; questions[questionsCounter].Status = true;
                }
            }
            else
            if (rbOption3.Checked) {
                if (rbOption1.Text == questions[questionsCounter].Answer)
                {
                    score++; questions[questionsCounter].Status = true;
                }
            }
            else
            if (rbOption4.Text == questions[questionsCounter].Answer) 
            { 
                score++; questions[questionsCounter].Status = true; 
            }



            questionsCounter++;

            label1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
 