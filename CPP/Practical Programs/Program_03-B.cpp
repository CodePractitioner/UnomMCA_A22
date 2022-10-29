/*
Program to Demonstrate Implementation of Polynomial Addition and Multiplication using Pointer Methods
*/

#include <iostream>			//change to iostream.h when used in Turbo C++
//#include <conio.h>		//required when used in Turbo C++
//#include <alloc.h>		//required when used in Turbo C++

#define Next(poly)poly->nxtpoly

using namespace std;		//not required when used in Turbo C++

typedef struct POLY
{
	int coeff, power;
	struct POLY* nxtpoly;
}POLY;

POLY* InsertPoly(int coeff, int power, POLY* First)
{
	POLY* New, *Current, *Prod;
	New = (POLY*)malloc(sizeof(POLY));
	if (!New)
	{
		cout << "\nError : Out of Memory.";
		return(First);
	}
	New->coeff = coeff;
	New->power = power;
	New->nxtpoly = NULL;

	if (!First)
	{
		return(New);
	}
	Prod = First;

	for (Current = First; Current; Current = Next(Current))
		Prod = (POLY*)Current;
	Next(Prod) = New;

	return First;
}

POLY* CreatePoly()
{
	int coeff, power;
	POLY* poly = NULL;
	cout << "\nEnter the Coeffs.Power<Coeffs.Power>0->end :\t";
	while (true)
	{
		cin >> coeff >> power;
		if (coeff == 0)
			break;
		else
			poly = InsertPoly(coeff, power, poly);
		if (power == 0)
			break;
	}
	return(poly);
}

POLY* FreePoly(POLY* poly)
{
	free(poly);
	return(NULL);
}

void DisplayPoly(POLY* poly)
{
	POLY* Current;
	for (Current = poly; Current; Current = Next(Current))
		if (Current->coeff > 0)
			cout << Current->coeff << "X^" << Current->power<<"+";
	cout << "=0" << endl;
}

POLY* PolyAdd(POLY* poly1, POLY* poly2)
{
	POLY* p1, *p2, *poly = NULL;
	p1 = poly1;
	p2 = poly2;
	while (p1 && p2)
	{
		if (p1->power > p2->power)
		{
			poly = InsertPoly(p1->coeff, p1->power, poly);
			p1 = Next(p1);
		}
		else if (p1->power < p2->power)
		{
			poly = InsertPoly(p2->coeff, p2->power, poly);
			p2 = Next(p2);
		}
		else
		{
			poly = InsertPoly(p1->coeff + p2->coeff, p1->power, poly);
			p1 = Next(p1);
			p2 = Next(p2);
		}
	}
	while (p1)
	{
		poly = InsertPoly(p1->coeff, p1->power, poly);
		p1 = Next(p1);
	}
	while (p2)
	{
		poly = InsertPoly(p2->coeff, p2->power, poly);
		p2 = Next(p2);
	}
	return(poly);
}

POLY* PolyMul(POLY* poly1, POLY* poly2)
{
	POLY* p1, *pnew, *pmul ,*prod;
	prod = NULL;
	for (; poly2; poly2 = Next(poly2))
	{
		for (p1 = poly1, pmul = NULL; p1; p1 = Next(p1))
			pmul = InsertPoly(p1->coeff*poly2->coeff, p1->power + poly2->power, pmul);
		pnew = PolyAdd(prod, pmul);
		prod = FreePoly(prod);
		pmul = FreePoly(pmul);
		prod = pnew;
	}
	return(prod);
}

int main()
{
	int choice;
	//clrscr();			//required when used in Turbo C++
	system("cls");		//not required when used in Turbo C++

	POLY *poly1, *poly2, *poly;
	poly1 = poly2 = poly = NULL;
	cout << "<--------Polynomial Program-------->" << endl;

	cout << "\nEnter the First Polynomial :\t";
	poly1 = CreatePoly();
	cout << "\nEntered First Polynomial :\t";
	DisplayPoly(poly1);

	cout << "\nEnter the Second Polynomial :\t";
	poly2 = CreatePoly();
	cout << "\nEntered Second Polynomial :\t";
	DisplayPoly(poly2);
	
	while (true)
	{
		cout << "\n====================================";
		cout << "\nEnter your Choice :";
		cout << "\n1. Addition of Polynomial";
		cout << "\n2. Multiplication Of Polynomial";
		cout << "\n3. Exit\n";
		cout << "====================================" << endl;
		cin >> choice;

		switch (choice)
		{
			case 1:
				poly = PolyAdd(poly1, poly2);
				cout << "\nResultant Addition Polynomial :" << endl;
				break;
			case 2:
				poly = PolyMul(poly1, poly2);
				cout << "\nResultant Multiplication Polynomial :" << endl;
				break;
			case 3:
			default:
				return(0);
		}
		DisplayPoly(poly);
		poly = FreePoly(poly);
	}
	return(0);
	//getch();			//required when used in Turbo C++
}