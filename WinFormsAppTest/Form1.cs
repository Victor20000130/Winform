namespace WinFormsAppTest
{
    public partial class MathQuiz : Form
    {
        // Constructor
        public MathQuiz()
        {
            InitializeComponent();
        }

        // Create a Random object called randomizer
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers
        // for the addition problem.
        int addend1;
        int addend2;

        // These integer variable store the numbers
        // for the subtraction problem.
        int minuend;
        int subtrahend;

        // These integer variables store the numbers
        // for the multiplication problem.
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers
        // for the division problem.
        int dividend;
        int divisor;

        // This integer variable keeps track of the
        // remaining time.
        int timeLeft;

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly henerated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int TemporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * TemporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if((addend1 + addend2 == sum.Value))
            {
                return true;
            }

            return false;
        }
    }
}
