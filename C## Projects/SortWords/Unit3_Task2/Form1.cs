/**
 * © Gloria Gutierrez 
 * Spring 2018
 * */

/*
 **********************************************************************************************
 *************** This program reads a list of words and sorts them alphabetically *************
 **********************************************************************************************
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unit3_Task2{

    public partial class SortWords : Form{

        List<String> names = new List<String>();
        List<String> nameList = new List<String>();
        String inputWord;

        public SortWords(){
            InitializeComponent();
        }

        private void SortWords_Load(object sender, EventArgs e){
            TitleLbl.Text = "Please enter a list of words in the box below and I'll sort them alphabetically for you." +
                             "\n            After each word, press the button to add it to the list >>";
        }        

        private void SortButton_Click(object sender, EventArgs e){            

            inputWord = TextBox.Text;
            names.Add(inputWord);
            nameList.AddRange(names);
            nameList.Sort();
            MsgLbl.Text = "Sorted words:";            

            /* This gets rid of duplicate words*/
            for (int i = 0; i < nameList.Count - 1; i++) {
                for (int j = i + 1; j < nameList.Count; j++){
                    if (nameList[i].ToString() == nameList[j].ToString()) {
                        nameList.RemoveAt(j);                        
                        j -= 1;
                    }
                }
            }

            /* This writes the words to a label separated by a few spaces*/
            ResultsLbl.Text = " ";
            foreach (string s in nameList){
                ResultsLbl.Text += s + "  "; 
            }            
        TextBox.Clear();
        }               
    }      
 }
    