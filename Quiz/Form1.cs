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
                string results="";
                for(int i = 0; i < questions.Count; i++)
                {
                    results += questions[i].Text;
                    results += "\n";
                    results += $"{questions[i].givenAnswer} - {questions[i].Status}";
                    results += "\n\n";
                }

                MessageBox.Show(results);

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
                questions[questionsCounter].givenAnswer = rbOption1.Text;
                if (rbOption1.Text == questions[questionsCounter].Answer)
                {
                    score++; 
                    questions[questionsCounter].Status = true;
                }
            }
            else
            if (rbOption2.Checked) {
                questions[questionsCounter].givenAnswer = rbOption2.Text;
                if (rbOption1.Text == questions[questionsCounter].Answer)
                {
                    score++; 
                    questions[questionsCounter].Status = true;  
                }
            }
            else
            if (rbOption3.Checked) {
                questions[questionsCounter].givenAnswer = rbOption3.Text;
                if (rbOption1.Text == questions[questionsCounter].Answer)
                {
                    score++; 
                    questions[questionsCounter].Status = true;
                }
            }
            else
            if (rbOption4.Checked)
            {
                questions[questionsCounter].givenAnswer = rbOption4.Text;
                if (rbOption1.Text == questions[questionsCounter].Answer)
                {
                    score++;
                    questions[questionsCounter].Status = true;

                }
            }



            questionsCounter++;

            label1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
 