using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BestSlidePuzzle
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void AnswerCheck_Clicked(object sender, EventArgs e)
        {
       

            if (Quest01.Text == "tiles")
            {
                Quest01.Text = "Answer is correct!";           
            }
            else
            {
                Quest01.Text = "Incorrect, Please try again";
            }
        }

        private void AnswerCheck02_Clicked(object sender, EventArgs e)
        {
            if (Quest02.Text == "rubix cube")
            {
                Quest02.Text = "Answer is correct!";
            }
            else
            {
                Quest02.Text = "Incorrect, Please try again";
            }
        }

        private void AnswerCheck03_Clicked(object sender, EventArgs e)
        {
            if (Quest03.Text == "4")
            {
                Quest03.Text = "Answer is correct!";
            }
            else
            {
                Quest03.Text = "Incorrect, Please try again";
            }
        }

        private void AnswerCheck04_Clicked(object sender, EventArgs e)
        {
            if (Quest04.Text == "2")
            {
                Quest04.Text = "Answer is correct!";
            }
            else
            {
                Quest04.Text = "Incorrect, Please try again";
            }
        }

        private void AnswerCheck05_Clicked(object sender, EventArgs e)
        {
            if (Quest05.Text == "kongregate")
            {
                Quest05.Text = "Answer is correct!";
            }
            else
            {
                Quest05.Text = "Incorrect, Please try again";
            }
        }

        private void AnswerCheck06_Clicked(object sender, EventArgs e)
        {
            if (Quest06.Text == "Mr Puzzle")
            {
                Quest06.Text = "Answer is correct!";
            }
            else
            {
                Quest06.Text = "Incorrect, Please try again";
            }
        }

        private void AnswerCheck07_Clicked(object sender, EventArgs e)
        {
            if (Quest07.Text == "48")
            {
                Quest07.Text = "Answer is correct!";
            }
            else
            {
                Quest07.Text = "Incorrect, Please try again";
            }
        }

        private void AnswerCheck08_Clicked(object sender, EventArgs e)
        {
            if (Quest08.Text == "hypest")
            {
                Quest08.Text = "Answer is correct!";
            }
            else
            {
                Quest08.Text = "Incorrect, Please try again";
            }
        }
    }
}
