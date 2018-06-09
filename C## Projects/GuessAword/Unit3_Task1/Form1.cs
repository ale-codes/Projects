/**
 * © Gloria Gutierrez 
 * Spring 2018 
 * */

/*
*****************************************************************************************************
******** This program reads characters from the user until a random hidden words is guessed *********
*****************************************************************************************************
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unit3_Task1 {

    public partial class GuessAWord : Form {
        List<char> correctLetters = new List<char>();
        string hiddenWord;
        int attempts;
        int num;


        public GuessAWord(){
            InitializeComponent();            
        }
        
        private void GuessAWord_Load(object sender, EventArgs e) { 
            
            YesButton.Visible = false;
            NoButton.Visible = false;
            string[] wordBank = { "dog", "tea", "bass", "light", "computer", "sofa", "planet", "windows" };
            Random randNum = new Random();
            int num = randNum.Next(0, 8);
            hiddenWord = wordBank[num];
            attempts = 0;

            introLabel.Text = "Let's try to guess the hidden word. Press the START button to begin >>";
            SubmitButton.Visible = false;
            textBox1.Visible = false;  
        }

        
        private void StartButton_Click(object sender, EventArgs e) { 
            
            introLabel.Text = "";
            startLabelOne.Text = "The hidden word: ";
            startLabelTwo.Text = "Begin by typing a letter in the box >>";
            StartButton.Visible = false;
            SubmitButton.Visible = true;
            textBox1.Visible = true;
            YesButton.Visible = false;
            NoButton.Visible = false;            
            ResultsLabel.Text = "";
            wrongGuessLabel.Text = "";
            totalsLabel.Text = "";
            repeatLabel.Text = "";
            WordLabel.Text = "";               
        }


        private void SubmitButton_Click(object sender, EventArgs e) {

            attempts++;
            startLabelTwo.Text = "Please guess again >>";
            string labelText = "";
            string answer = textBox1.Text;           
            int right = 0;

            for (int i = 0; i < hiddenWord.Length; i++) {
                
                /* This lets the user know if a match has been made*/
                matchesLabel.Visible = true;
                int pos = hiddenWord.IndexOf(answer, 0);
                if (pos > -1){
                    matchesLabel.Text = "Yes! " + answer + " is in the word";
                }
                else{
                    matchesLabel.Text = "Sorry, " + answer + " is not in the word";
                }
                matchesLabel.Visible = true;


                /* This keeps track of clicks / guesses and checks the user's input against the hidden word.*/
                if (hiddenWord[i].ToString() == answer || correctLetters.Contains(hiddenWord[i])) {                    
                    right++;                   
                    correctLetters.Add(hiddenWord[i]);
                    labelText += hiddenWord[i].ToString();
                }
                else {                    
                    labelText += "*";                      
                    textBox1.Clear();  
                }

                WordLabel.Text = labelText;
                totalsLabel.Text = "Correct Guesses: " + right.ToString() +"               Number of tries: " + attempts ;
                int wrong = attempts - right;
                wrongGuessLabel.Text = "Incorrect Guesses: " + wrong.ToString();
            }            

            if (WordLabel.Text == hiddenWord){
                matchesLabel.Text = ""; 
                textBox1.Visible = false;
                SubmitButton.Visible = false;
                startLabelTwo.Text = "";                
                ResultsLabel.Text = "Congratulations, you have guessed the word!";
                repeatLabel.Text = "Would you like to guess another word? >>";
                YesButton.Visible = true;
                NoButton.Visible = true;
            }           
        } 
        
        private void YesButton_Click(object sender, EventArgs e) {
            Application.Restart();
            Environment.Exit(0);
        }
        
        private void NoButton_Click(object sender, EventArgs e) {
            matchesLabel.Text = "";           
            startLabelOne.Text = "";
            WordLabel.Text = "";
            ResultsLabel.Text = "Thank You for Playing!!!";
            wrongGuessLabel.Text = "";
            totalsLabel.Text = "";
            repeatLabel.Text = "";
            YesButton.Visible = false;
            NoButton.Visible = false;         
        }
    }
}


        

  


