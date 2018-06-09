
/*
* © Gloria Gutierrez
* Summer 2017
*/


/* ******************************************************************************************
********* This is a simulated shipping system. The user can obtain the total shipping *******
************ charges based on the weight of the package and the shipping distance. **********
*********************************************************************************************/


#include <iostream>
#include <iomanip>  
using namespace std;

//This is the function prototype
void calculateCharge(double packageWeight, double distance);


int main(){
	double packageWeight = 0.0, distance=0.0;
	calculateCharge(packageWeight, distance);
	cin.get();
	cin.ignore();
    return 0;
}

//calculateCharge function
void calculateCharge(double packageWeight, double distance){
	const double rateOne = 3.10;
	const double rateTwo = 4.20;
	const double overSixToTenKg = 5.30;
	const double overTenKg = 6.40;
	double totalCharge, baseMiles = 500;

	
	
// User Inputs
  do
	{
		cout << "What is the weight of the package you want to ship (in Kg)?\n" << endl;
		cin >> packageWeight;
             if (packageWeight <= 0)
		        {
				 cout << "Sorry, you can't ship an item with 0 weight\n";
				 cout << "the program will exit after you press the 'Enter' key" << endl; 
			     break;
		         }

        cout << "What is the distance to ship (in miles)?\n" << endl;
		cin >> distance;
			
	{
		if (packageWeight <= 2)
			{
				cout  << setprecision(2) << fixed << endl;
				totalCharge = (distance / baseMiles) * rateOne;
				cout << "The shipping charge for this item is $" << totalCharge << "\n" << endl;
			}
		else if (packageWeight > 2 && packageWeight <= 6)
		   {
				cout << fixed << setprecision(2) << endl;
				totalCharge = (distance / baseMiles)  * rateTwo ;
				cout << "The shipping charge for this item is $ " << totalCharge << "\n" << endl;
			}
		else if (packageWeight > 6 && packageWeight <= 10)
			{
				cout << fixed << setprecision(2) << endl;
				totalCharge = (distance / baseMiles) * overSixToTenKg;
				cout << "The shipping charge for this item is $ " << totalCharge << "\n" << endl;
			}
		else 
			{
				cout << fixed << setprecision(2) << endl;
				totalCharge = (distance / baseMiles) * overTenKg;
				cout << "The shipping charge for this item is $ " << totalCharge <<"\n"<< endl;
			}
		}
		
	} while (packageWeight != 0);

}

	

