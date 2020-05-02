using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

			//Calls GetRandomMathProblem() and stores the result as a variable called mathProblem
			MathProblem mathProblem = GetRandomMathProblem();

			//Ask the user a question
			Console.WriteLine("What is {0}", mathProblem.Question);

			//This next bit of code tries to parse the user input, if its successful it returns true, otherwise false
			//We check if its valid input, if its not we alert and exit
			//Might want to make this a loop later so the user can keep trying input until they have a valid one...
			int userAnswer;
			if (!int.TryParse(Console.ReadLine(), out userAnswer))
			{
				Console.WriteLine("That is not a valid integer!");
				return;
			}

			//Compare the actual numbers, never compare strings for math...
			if (userAnswer == mathProblem.Answer)
			{
				Console.WriteLine("Correct");
			}
			else
			{
				Console.WriteLine("Incorrect");
			}
		}

		private static Random rnd = new Random();

		public static MathProblem GetRandomMathProblem()
		{
			//Generates random number for 1st part of problem
			int number1 = rnd.Next(1, 11);

			//Generates random number for 2nd part of problem
			int number2 = rnd.Next(1, 11);

			// gives value of 1-3 to select operand
			// returns new MathProblem() in each case, no more answer and question local variables needed
			switch (rnd.Next(4))
			{
				//if case 1 is generated, addition is used
				case 1:
					return new MathProblem()
					{
						Question = $"{number1} + {number2}",
						Answer = number1 + number2
					};
				//if case 2 is generated, subtraction is used
				case 2:
					return new MathProblem()
					{
						Question = $"{number1} - {number2}",
						Answer = number1 - number2
					};
				//if case 3 is generated, multiplication is used
				case 3:
				default:
					return new MathProblem()
					{
						Question = $"{number1} * {number2}",
						Answer = number1 * number2
					};
			}
		}
	}

	//This is a custom class, it has two properties.  This is how we will transmit the two pieces of data we need, question and answer
	public class MathProblem
	{
		public string Question { get; set; }
		public int Answer { get; set; }
	}
}
    