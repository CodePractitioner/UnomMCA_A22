/*
    Program to Demonstrate the String Functions along with Operator Overloading
*/

#include <iostream>       //change to iostream.h when used in Turbo C++
//#include <conio.h>      //required when used in Turbo C++
#include <stdio.h>
#include <string.h>

using namespace std;      //not required when used in Turbo C++

class String_Functions
{
    private:
        char str[80];
    public:
        String_Functions()
        {
            strcpy(str,"");
        }

        friend istream& operator >> (istream& in, String_Functions& obj);
        friend ostream& operator << (ostream& out, String_Functions& obj);

        String_Functions operator + (String_Functions obj);

        int operator == (String_Functions obj);
        int operator != (String_Functions obj);
        int operator > (String_Functions obj);
        int operator < (String_Functions obj);

};

istream& operator >> (istream& in, String_Functions& obj)
{
    gets(obj.str);
    return in;
}

ostream& operator <<(ostream& out, String_Functions& obj)
{
    puts(obj.str);
    return out;
}

String_Functions String_Functions :: operator + (String_Functions obj)
{
    String_Functions temp;
    strcpy(temp.str,str);
    strcat(temp.str,obj.str);
    return(temp);
}

int String_Functions :: operator == (String_Functions obj)
{
    if (strcmp(str,obj.str) == 0)
        return 1;
    else
        return 0;
}

int String_Functions :: operator != (String_Functions obj)
{
    if (strcmp(str,obj.str) == 0)
        return 0;
    else
        return 1;
}

int String_Functions :: operator > (String_Functions obj)
{
    if (strcmp(str,obj.str) > 0)
        return 1;
    else
        return 0;
}

int String_Functions :: operator < (String_Functions obj)
{
    if (strcmp(str,obj.str) < 0)
        return 1;
    else
        return 0;
}


int main()
{
    String_Functions str1, str2, str3, str4;

    //clrscr();     //required when used in Turbo C++

    cout << "Enter the First String : " << endl;
    cin >> str1;
    cout << "Enter the Second String : " << endl;
    cin >> str2;

    cout << "Enter the String 1 is : " << str1;
    cout << "Enter the String 2 is : " << str2;

    str3 = str1 + str2;
    cout << "The Concatenated String (String 3) is : " << str3;

    if (str1 == str2)
        cout << "The Given Strings are Equal." << endl;
    if (str1 != str2)
        cout << "The Given Strings are not Equal." << endl;

    if (str1 > str2)
        cout << "The String 1 is greater than String 2." << endl;
    if (str1 < str2)
        cout << "The String 1 is lesser than String 2." << endl;

    str4 = str1;
    cout << "The copy of String 1 (String 4) is : " << str4;

    //getch();      //required when used in Turbo C++
    return 0;
}
