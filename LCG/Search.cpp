#include "Search.h"


Search::Search(int x1, int x2, int x3, int x4) {
	long long int num = (x3 - x1) * (x3 - x2) - (x4 - x2) * (x2 - x1);
	int m, a;
	std::vector <int> Multipliers;
	for (int i = 2; i <= max; i++) {
		if (num % i == 0) {
			Multipliers.push_back(i);
		}
	}
	for (auto i : Multipliers) {
		for (int j = -i; j < i; j++) {
			if ((x3 - x2 - (j * i)) % (x2 - x1) == 0 && ((x3 - x2 - j * i) / (x2 - x1)) < i) {
				m = i;
				a = ((x3 - x2 - j * i) / (x2 - x1));
				int MaxValue = m;
				if (m > (m + a * x1 - x2) / m) {
					MaxValue = (m + a * x1 - x2) / m;
					if ((m + a * x1 - x2) % m != 0) {
						MaxValue++;
					}
				}
				for (int b = 0; b < MaxValue; b++) {
					if ((b * m + x2 - x1 * a) > 0 && (b * m + x2 - x1 * a) < m && (a * x1 + (b * m + x2 - x1 * a)) % m == x2 && (a * x2 + (b * m + x2 - x1 * a)) % m == x3 && (a * x3 + (b * m + x2 - x1 * a)) % m == x4) {
						Polly Buffer;
						Buffer.a = a;
						Buffer.c = b * m + x2 - x1 * a;
						Buffer.m = m;
						Coefficients.push_back(Buffer);
					}
				}
			}
		}
	}
}
