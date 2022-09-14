/*
    Program to find the roots of an Equation (Linear and Quadratic Equations)
*/


#include <iostream>       //change to iostream.h when used in Turbo C++
//#include <conio.h>      //required when used in Turbo C++
#include <math.h>

using namespace std;    //not required when used in Turbo C++

class Equation
{
private:
    float eqNum1;
    float eqNum2;
    float eqNum3;
public :
    inline void getInfo(float a, float b, float c);
    inline void display();
    inline void calculation();
    inline void linearRoot();
    inline void sameRealRoot();
    inline void distinctRealRoot(float det);
};

inline void Equation :: getInfo(float a, float b, float c)
{
    eqNum1=a;
    eqNum2=b;
    eqNum3=c;
}

inline void Equation :: display()
{
    if(eqNum1==0)
    {
        cout << "The given values of B,C in the Linear Equation : Bx+C=0" << endl;
        cout << "B = "<< eqNum2 <<endl;
        cout << "C = "<< eqNum3 <<endl;
    }
    else
    {
        cout << "The given values of A,B,C in the Quadratic Equation : Ax^2+Bx+C=0" << endl;
        cout << "A = "<< eqNum1 <<endl;
        cout << "B = "<< eqNum2 <<endl;
        cout << "C = "<< eqNum3 <<endl;
    }

}

inline void Equation :: calculation()
{
    if(eqNum1==0)
    {
        linearRoot();
    }
    else
    {
        float det;
        det=eqNum2*eqNum2-(4*eqNum1*eqNum3);
        if(det==0)
        {
            sameRealRoot();
        }
        else if(det>0)
        {
            distinctRealRoot(det);
        }
        else if (det<0)
        {
            cout << "The given Quadratic Equation contains Imaginary Roots";
        }
    }
}

inline void Equation :: linearRoot()
{
    float linearResult;
    linearResult=eqNum3/eqNum2;
    cout << "The Root is "<<linearResult<<endl;
}

inline void Equation :: sameRealRoot ()
{
    float root;
    root=-eqNum2/(2*eqNum1);
    cout << "The given Quadratic equation contains real same roots : \n root1 = root2 = " << root;
}

inline void Equation :: distinctRealRoot(float det)
{
    float root1,root2;
    root1=-eqNum2+sqrt(det)/(2*eqNum1);
    root2=-eqNum2-sqrt(det)/(2*eqNum1);
    cout << "The given Quadratic equation contains real distinct roots : "<<endl;
    cout << "root1 = "<<root1<<"\t root2 = "<<root2;
}


int main()
{
    class Equation eq;
    float num1,num2,num3;
    //clrscr();     //required when used in Turbo C++
    cout << "Enter the values of A,B,C values of the Equation :" << endl;
    cin >> num1>>num2>>num3;
    eq.getInfo(num1,num2,num3);
    eq.display();
    eq.calculation();
    //getch();      //required when used in Turbo C+
    return 0;
}
