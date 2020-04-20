#include <iostream>
#include "Search.h"

int main()
{
	int x1, x2, x3, x4, x5;
	std::cout << "Enter 4 numbers:\n";
	std::cin >> x1 >> x2 >> x3 >> x4;
	Search SearchOfCoefficients(x1, x2, x3, x4);
	std::cout << "x5 a m c\n";
	for (auto i : SearchOfCoefficients.Coefficients) {
		x5 = (i.a * x4 + i.c) % i.m;
		std::cout << x5 << " " << i.a << " " << i.c << " " << i.m << "\n";
	}
	return 0;
}