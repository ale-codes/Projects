
/*
* © Gloria Gutierrez
* Summer 2017
*/


/* ******************************************************************************************
********* This program reads 5 numbers from the user and displays whether any of them *******
******** matched the random lottery numbers created by the program.(value and position) *****
*********************************************************************************************/

#include <iostream>
#include <cstdlib>
#include <time.h>
using namespace std;

int main()
{
	const int SIZE = 5;
	int winningNumbers[SIZE];
	int player[SIZE];
	int match = 0;

	unsigned seed = 0;
	srand(time(0));
	winningNumbers[0] = rand() % 10;  //This sets up the random values for the lottery.
	winningNumbers[1] = rand() % 10;
	winningNumbers[2] = rand() % 10;
	winningNumbers[3] = rand() % 10;
	winningNumbers[4] = rand() % 10;

	cout << "\nEnter " << SIZE << " random numbers from 0 to 9 and I will tell you how many of them match\n"
		<< "the winning numbers' value and position.\n"
		<< "\nPress [Enter] after each entry.\n\n";

	for (int index = 0; index < SIZE; index++) { //This assigns the user inputs to the 'player'array
		cout << "\nValue #" << (index + 1) << ": ";
		cin >> player[index];

		while (player[index] < 0 || player[index] > 9){
			cout << "\nError! The values must be between 0 and 9. Try again\n\n";
			cin >> player[index];}
	    }

	cout << endl << "Lottery numbers: ";
	for (int index = 0; index < 5; index++) { //This shows the random lottery values.
		cout << winningNumbers[index];
		cout << " ";}

	cout << "\n\nYour numbers:    ";
	for (int index = 0; index < SIZE; index++) { // This shows the user values.
		cout << player[index];
		cout << " ";}

	//This compares both arrays and displays the matches based on position.
	for (int index = 0; index < SIZE; index++) {  
		if (winningNumbers[index] == player[index])
			 match = match + 1;}
	    if (match)
		    cout << "\n\nNumber of digits matched: " << match << endl;
	    else
		    cout << "\n\nYou did not match any numbers. ";

	cin.get();
	cin.ignore();
	return 0;

}

