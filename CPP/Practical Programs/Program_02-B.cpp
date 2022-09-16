/*
    Program to Demonstrate Billing System using Array of Objects
*/

#include <iostream>       //change to iostream.h when used in Turbo C++
//#include <conio.h>      //required when used in Turbo C++

using namespace std;      //not required when used in Turbo C++

void Line();
void Header();

struct Inventory
{
    int productid, quantity;
    char productname[15];
    float unitprice, amount;
} inven[5][10];     //array of objects

int main()
{
   int nosItm=0, nosCntr=0;
   float total[10]={0.0}, cashtotal=0.0;

    //clrscr();     //required when used in Turbo C++

    cout << "Enter the Number of Sales Counter : ";
    cin >> nosCntr;

    for(int i=1; i<=nosCntr; i++)
    {
        cout << endl << "\tCounter : " << i;
        cout << endl << "Enter the no of Items : ";
        cin >> nosItm;

        cout << "\nId: \tProduct Name \tQuantity \tUnitPrice :" << endl;
        for(int j=1; j<=nosItm; j++)
        {
            cin >> inven[i][j].productid;
            cin >> inven[i][j].productname;
            cin >> inven[i][j].quantity;
            cin >> inven[i][j].unitprice;
            inven[i][j].amount = inven[i][j].quantity * inven[i][j].unitprice;
            total[i] += inven[i][j].amount;
        }
    }

    for(int i=1; i<=nosCntr; i++)
        cashtotal += total[i];

    cout << endl << endl;
    Line();
    Header();
    Line();
    for(int i=1; i<=nosCntr; i++)
    {
        cout << i;
        for(int j=1; j<=nosItm; j++)
        {
            cout << "\t" << inven[i][j].productid;
            cout << "\t  " << inven[i][j].productname;
            cout << "\t\t" << inven[i][j].quantity;
            cout << "\t" << inven[i][j].unitprice;
            cout << "\t" << inven[i][j].amount << endl;
        }
        Line();
        cout << "\t\t\t\t\tTotal : " << total[i] << endl;
        Line();
    }
    cout << "\t\t\tTotal Sales Amount : " << cashtotal;

    //getch();      //required when used in Turbo C++
    return 0;
}

void Line()
{
    for(unsigned short line=0 ; line<=53; line++)
        cout << "-";
    cout << endl;
}

void Header()
{
    cout << "Counter\t";
    cout << "Product\t";
    cout << "  Name\t\t";
    cout << "Qty\t";
    cout << "Price\t";
    cout << "Amount" << endl;
    cout << "Id\tId\t\t\t\tRs.\tRs." << endl;
}
