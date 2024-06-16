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
                    Text = "Питання 1: Що таке C#?",
                    Answer = "Мова програмування",
                    Wrongs = new string[] { "Інструмент розробки", "Операційна система", "База даних" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 2: Що таке .NET?",
                    Answer = "Фреймворк",
                    Wrongs = new[] { "Мова програмування", "Текстовий редактор", "Графічний редактор" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 3: Хто створив Windows?",
                    Answer = "Microsoft",
                    Wrongs = new string[] { "Apple", "Google", "Facebook" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 4: Який найбільший океан у світі?",
                    Answer = "Тихий",
                    Wrongs = new string[] {"Атлантичний", "Індійський", "Північний Льодовитий" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 5: Хто є автором 'Гаррі Поттер'?",
                    Answer = "Джоан Роулінг",
                    Wrongs = new string[] { "Стівен Кінг",  "Марк Твен", "Джейн Остін" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 6: Яка столиця України?",
                    Answer = "Київ",
                    Wrongs = new string[] { "Львів",  "Одеса", "Харків" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 7: Що таке HTML?",
                    Answer = "Мова розмітки",
                    Wrongs = new string[] { "Протокол передачі даних", "Операційна система", "База даних" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 8: Яка планета найбільша в Сонячній системі?",
                    Answer = "Юпітер",
                    Wrongs = new string[] { "Земля", "Марс",  "Сатурн" },
                    Status = false
                },
                new Question()
                {
                    Text = "Питання 9: Який хімічний елемент має символ 'O'?",
                    Answer =  "Гідроген",
                    Wrongs = new string[] {  "Карбон", "Оксиген", "Нітроген" },
                    Status = false
                },
                 new Question()
                {
                    Text = "Питання 10: Скільки континентів на Землі?",
                    Answer =  "7",
                    Wrongs = new string[] { "5", "6", "8" },
                    Status = false
                },
            };

            InitializeComponent();
            lblScore.Text = $"Правильних відповідей: {score}";

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (questionsCounter < questions.Count)
            {

                lblScore.Text = $"Правильних відповідей: {score}";
                rbOption1.Checked = false;
                rbOption2.Checked = false;
                rbOption3.Checked = false;
                rbOption4.Checked = false;

            }
            else
            {
                MessageBox.Show("asdad");
                lblQuestion.Text = $"Вікторина завершена! Ваш рахунок: {score}/{questions.Count}";
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
 