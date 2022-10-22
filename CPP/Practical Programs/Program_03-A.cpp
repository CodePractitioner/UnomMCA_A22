/*
Program to Demonstrate Implementation of Polynomial Object using Overloaded Operator
*/

#include <iostream>			//change to iostream.h when used in Turbo C++
//#include <conio.h>		//required when used in Turbo C++
//#include <time.h>			//required when used in Turbo C++
//#include <stdlib.h>		//required when used in Turbo C++

using namespace std;		//not required when used in Turbo C++

class Polynomial
{
private:
	int power;
	int* coeffs;
public:
	//Constructors
	Polynomial()
	{
		power = 0;
		coeffs = new int[1];
	}
	Polynomial(int deg)
	{
		power = deg;
		coeffs = new int[deg + 1];
	}
	Polynomial(const Polynomial& X);

	//Methods to get and show Polynomials
	void GetCoefficients(istream& in);
	int Coefficient(int deg);
	void Show(ostream& out);
	int degree() { return power; }

	//Operator Overloading using Friend Functions
	friend Polynomial operator + (Polynomial& X, Polynomial& Y);
	friend Polynomial operator - (Polynomial& X, Polynomial& Y);
};

Polynomial::Polynomial(const Polynomial& X)
{
	coeffs = new int[X.power + 1];
	power = X.power;
	for (int i = X.power; i >= 0; i--)
		coeffs[i] = X.coeffs[i];
}

void Polynomial::GetCoefficients(istream& in)
{
	for (int i = power; i >= 0; i--)
		in >> coeffs[i];
	in.ignore();
}

int Polynomial::Coefficient(int deg)
{
	return coeffs[deg];
}

void Polynomial::Show(ostream& out)
{
	for (int i = power; i >= 0; i--)
	{
		if (coeffs[i] >= 0)
		{
			if (i != power)
				out << "+";
			out << coeffs[i];
		}
		else
		{
			if (coeffs[i] < 0)
				out << "-";
			out << 0 - coeffs[i];
		}
		if (i > 1)
			out << "X^" << i;
		else if (i == 1)
			out << "X";
	}
}

Polynomial operator + (Polynomial& X, Polynomial& Y)
{
	Polynomial Z;
	if (X.power == Y.power)
	{
		Z = X;
		for (int i = Y.power; i >= 0; i--)
			Z.coeffs[i] = X.coeffs[i] + Y.coeffs[i];
		return Z;
	}
	else if (X.power < Y.power)
	{
		Z = Y;
		for (int i = Y.power; i >= 0; i--)
			Z.coeffs[i] = Y.coeffs[i];
		return Z;
	}
	else if (X.power < Y.power)
	{
		Z = X;
		for (int i = X.power; i >= 0; i--)
			Z.coeffs[i] = X.coeffs[i];
		return Z;
	}
	return 0;
}

Polynomial operator - (Polynomial& X, Polynomial& Y)
{
	Polynomial Z;
	if (X.power == Y.power)
	{
		Z = X;
		for (int i = Y.power; i >= 0; i--)
			Z.coeffs[i] = X.coeffs[i] - Y.coeffs[i];
		return Z;
	}
	else if (X.power < Y.power)
	{
		Z = Y;
		for (int i = Y.power; i >= 0; i--)
			Z.coeffs[i] = Y.coeffs[i];
		return Z;
	}
	else if (X.power < Y.power)
	{
		Z = X;
		for (int i = X.power; i >= 0; i--)
			Z.coeffs[i] = X.coeffs[i];
		return Z;
	}
	return 0;
}

void line(int lines)
{
	for (int i = 0; i < lines; i++)
		cout << endl;
}

int main()
{
	short choice;
	bool cont;
	do
	{
		//clrscr();			//required when used in Turbo C++
		system("cls");		//not required when used in Turbo C++
		cout << "<--------Polynomial Program-------->" << endl;
		cout << "====================================";
		cout << "\nEnter your Choice :";
		cout << "\n1. Addition of Polynomial";
		cout << "\n2. Subtraction Of Polynomial";
		cout << "\n3. Exit\n";
		cout << "====================================" << endl;
		cin >> choice;

		switch (choice)
		{
			case 1:
			{
				Polynomial X(3);
				Polynomial Y(3);
				Polynomial Z(3);
				cout << "\nEnter the Coefficients of 1st Polynomial :\n";
				X.GetCoefficients(cin);
				cout << "\nEntered 1st Polynomial :\n";
				X.Show(cout);

				line(2);
				cout << "Enter the Coefficients of 2nd Polynomial :\n";
				Y.GetCoefficients(cin);
				cout << "\nEntered 2nd Polynomial :\n";
				Y.Show(cout);

				Z = X + Y;

				line(2);
				cout << "The Addition of Two Polynomials is :\n";
				Z.Show(cout);
				break;
			}
			case 2:
			{
				Polynomial X(3);
				Polynomial Y(3);
				Polynomial Z(3);
				cout << "\nEnter the Coefficients of 1st Polynomial :\n";
				X.GetCoefficients(cin);
				cout << "\nEntered 1st Polynomial :\n";
				X.Show(cout);

				line(2);
				cout << "Enter the Coefficients of 2nd Polynomial :\n";
				Y.GetCoefficients(cin);
				cout << "\nEntered 2nd Polynomial :\n";
				Y.Show(cout);

				Z = X - Y;

				line(2);
				cout << "The Subtraction of Two Polynomials is :\n";
				Z.Show(cout);
				break;
			}
			case 3:
			default:
				return 0;
		}
		line(2);
		cout << "Do You Want to Continue?(0,1)" << endl;
		cin >> cont;
	} while (cont);
	//getch();			//required when used in Turbo C++
}
