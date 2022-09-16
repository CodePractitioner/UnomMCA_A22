/*
    Program to Demonstrate Student Mark List using Array of Objects
*/

#include <iostream>       //change to iostream.h when used in Turbo C++
//#include <conio.h>      //required when used in Turbo C++
#include<string.h>

using namespace std;      //not required when used in Turbo C++

void Create(unsigned short);
void Display(unsigned short);
void Calculate(unsigned short);
bool ResCalMark(unsigned short);

struct Student
{
    char name[20];
    char result[5];
    unsigned short s_no, marks1, marks2, marks3;
    int total;
    float average;
} stud[10];     //array of objects

int main()
{
    unsigned short nos,choice,cont;
    //clrscr();     //required when used in Turbo C++

    cout << "Enter the Number of Students Max(10) : ";
    cin >> nos;

    if(nos <= 10)
    {
        do
        {
            cout << endl << "Enter your choice : \n 1. Create Student Marks \n 2. Display Records" << endl;
            cin >> choice;

            switch(choice)
            {
            case 1:
                Create(nos);
                break;

            case 2:
                Display(nos);
                break;

            default:
                cout << "Wrong Choice.";
            }

            cout << "Do you want to Continue ? (1/0)";
            cin >> cont;
        }
        while(cont!=0);
    }
    else
        cout << "Student nos Out of Predefined Range." << endl;

    //getch();      //required when used in Turbo C++
    return 0;
}

void Create(unsigned short nos)
{
    cout << "To Create Student Marks : " << endl;

    for(int itr=0 ; itr < nos; itr++)
    {
        cout << "Enter Student Name : " << endl;
        cin >> stud[itr].name;

        cout << "Enter Student RollNo : " << endl;
        cin >> stud[itr].s_no;

        cout << "Enter Marks 1 : " << endl;
        cin >> stud[itr].marks1;

        cout << "Enter Marks 2 : " << endl;
        cin >> stud[itr].marks2;

        cout << "Enter Marks 3 : " << endl;
        cin >> stud[itr].marks3;

        cout << endl;
    }

    Calculate(nos);
}

void Calculate(unsigned short nos)
{
    for(int itr=0; itr<nos; itr++)
    {
        stud[itr].total = stud[itr].marks1 + stud[itr].marks2 + stud[itr].marks3;
        stud[itr].average = stud[itr].total/3;
        if(ResCalMark(stud[itr].marks1) && ResCalMark(stud[itr].marks2) && ResCalMark(stud[itr].marks3))
            strcpy(stud[itr].result,"PASS");
        else
            strcpy(stud[itr].result,"FAIL");
    }
}

void Display(unsigned short nos)
{
    system("cls");      //not required when used in Turbo C++

    cout << "Displaying the Student Marks Records" << endl;

    cout << "| Name \t\t";
    cout << "| Roll.No \t";
    cout << "| Mark 1 \t";
    cout << "| Mark 2 \t";
    cout << "| Mark 3 \t";
    cout << "| Total \t";
    cout << "| Average \t";
    cout << "| Result \t|" << endl;

    for(int itr=0 ; itr < nos; itr++)
    {
        cout << "| " << stud[itr].name << "\t";
        cout << "| " << stud[itr].s_no << "\t\t";
        cout << "| " << stud[itr].marks1 << "\t\t";
        cout << "| " << stud[itr].marks2 << "\t\t";
        cout << "| " << stud[itr].marks3 << "\t\t";
        cout << "| " << stud[itr].total << "\t\t";
        cout << "| " << stud[itr].average << "\t\t";
        cout << "| " << stud[itr].result << "\t\t|" << endl;
    }
}

bool ResCalMark(unsigned short marks)
{
    if(marks < 35)
        return false;
    else
        return true;
}
