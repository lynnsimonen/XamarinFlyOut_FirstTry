using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFlyOut_FirstTry.Views
{
    public partial class QuestionairePage : ContentPage
    {
        public int TrueButton { get; set; }
        public int FalseButton { get; set; }
        public List<string> PersonalityQuestions { get; set; }
        public int QuestionNumber { get; set; }
        public int Number { get; set; }

        public QuestionairePage()
        {
            InitializeComponent();
            TrueButton = 0;
            FalseButton = 0;
            QuestionNumber = 1;
            Number = 1;

            PersonalityQuestions = new List<string>() {
                "Hamburgers are tastier than a Croque Monsieur sandwich.",
                "T-Bone steaks are yummier than filet mignon.",
                "I'd rather wake up with a black coffee than cafe au lait.",
                "Ice cold Coca-Cola is more refreshing than fresh lemonade.",
                "Maine lobster over escargot."};
            lbl_Question_Number.Text = $"Question {1} of 5:";
            lbl_Question_Listed.Text = $"T or F: \n{PersonalityQuestions[0]}";
        }
        public void btn_False_Clicked(object sender, EventArgs e)
        {
            if (Number < 5)
            {
                FalseButton++;  //French
                QuestionNumber++;
                lbl_Question_Number.Text = $"Question {QuestionNumber} of 5:";
                lbl_Question_Listed.Text = $"T or F: \n{PersonalityQuestions[Number++]}";
            }
            else
            {
                if (FalseButton > TrueButton)
                {
                    lbl_Question_Listed.Text = $"You are a true Francophile.  You are a lover of art, food and culture.";
                    btn_False.IsVisible = false;
                    btn_True.IsVisible = false;
                    lbl_Question_Number.IsVisible = false;
                }
                else
                {
                    lbl_Question_Listed.Text = $"You are a true American.  You are a lover of new ideas and a robust life.";
                    btn_False.IsVisible = false;
                    btn_True.IsVisible = false;
                    lbl_Question_Number.IsVisible = false;
                }
            }
        }
        public void btn_True_Clicked(object sender, EventArgs e)
        {
            if (Number < 5)
            {
                TrueButton++;  //American
                QuestionNumber++;
                lbl_Question_Number.Text = $"Question {QuestionNumber} of 5:";
                lbl_Question_Listed.Text = $"T or F: \n{PersonalityQuestions[Number++]}";
            }
            else
            {
                if (FalseButton > TrueButton)
                {
                    lbl_Question_Listed.Text = $"You are a true Francophile.  You are a lover of art, food and culture.";
                    btn_False.IsVisible = false;
                    btn_True.IsVisible = false;
                    lbl_Question_Number.IsVisible = false;
                }
                else
                {
                    lbl_Question_Listed.Text = $"You are a true American.  You are a lover of new ideas and a robust life.";
                    btn_False.IsVisible = false;
                    btn_True.IsVisible = false;
                    lbl_Question_Number.IsVisible = false;
                }
            }
        }

    }
}
