using System.Collections;
using System.Text;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random;
        string[] words =
        {
            "computer", "Science", "information", "technology", "programming", "coding", "engineer", "library"
        };
        string word;
        int word_order;

        public void load_word()
        {
            if (word_order < words.Length)
            {
                word = words[word_order].ToUpper();

                int word_length = word.Length;

                StringBuilder guessWord = new StringBuilder(word_length);

                int guess = word_length / 2;

                ArrayList letter_guess = new ArrayList();

                for (int i = 0; i < guess; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = random.Next(words.Length);
                        if (!letter_guess.Contains(rand_num))
                        {
                            letter_guess.Add(rand_num);
                            can_loop = false;
                        }
                    } while (can_loop);
                }

                for (int i = 0; i < words.Length; i++)
                {
                    if (letter_guess.Contains(i))
                    {
                        guessWord.Append("?");
                    }
                    else
                    {
                        guessWord.Append(word[i]);
                    }
                }

                lb_guess_word.Text = guessWord.ToString();
            }
            else
            {
                refresh_words();
                load_word();
            }
        }

        public void refresh_words()
        {
            words = words.OrderBy(x => random.Next()).ToArray();

            word_order = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();

            refresh_words();
            load_word();
        }

        private void tb_guess_Click(object sender, EventArgs e)
        {
            if (tb_guess.Text.Equals("Play Again?"))
            {
                word_order++;
                load_word();
                tb_guess.Text = "Guess";
                lst_wrong_guess.Items.Clear();
            }

            if (!tb_answer.Text.Equals(""))
            {
                if (tb_answer.Text.ToUpper().Equals(word))
                {
                    lb_guess_word.Text = word;
                    tb_guess.Text = "Play Again?";

                    MessageBox.Show("Correct Guess");
                }
                else
                {
                    lst_wrong_guess.Items.Add(tb_answer.Text);
                    MessageBox.Show("Wrong Guess");
                }

                tb_answer.Text = "";
            }
        }
    }
}
