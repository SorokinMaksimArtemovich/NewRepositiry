#pragma once
#include <vector>

class Search
{
private:
	const int max = 65535;
	class Polly {
	public:
		int a, c, m;
	};
public:
	std::vector <Polly> Coefficients;
	Search(int, int, int, int);
};

