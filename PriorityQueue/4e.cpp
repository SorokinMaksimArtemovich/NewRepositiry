#include <iostream>
#include <cstdlib>
#include <string>
#include <vector>


using namespace std;
FILE * input;
FILE * output;

void down(vector <int> &heap, int number, int count, vector <int> &Vector, int digit) {
	int element = number, min, min_number, a2, a1;
	while (element <= (count >> 1) - 1) {
		if (((element + 1) << 1 == count) || (heap[((element + 1) << 1) - 1] < heap[((element + 1) << 1)])) {
			min = heap[((element + 1) << 1) - 1];
			min_number = ((element + 1) << 1) - 1;
		}
		else {
			min = heap[(element + 1) << 1];
			min_number = (element + 1) << 1;
		}
		if (min < heap[element]) {
			for (int i = 0; i <= digit; i++) {
				if (Vector[i] == element) {
					a1 = i;
					break;
				}
			}
			for (int i = 0; i <= digit; i++) {
				if (Vector[i] == min_number) {
					a2 = i;
					break;
				}
			}
			Vector[a2] = element;
			Vector[a1] = min_number;
			heap[min_number] = heap[element];
			heap[element] = min;
			element = min_number;
		}
		else {
			break;
		}
	}

}

void up(vector <int> &heap, int number, vector <int> &Vector, int digit) {
	int element = number, min;
	while (element > 0) {
		if (heap[((element + 1) >> 1) - 1] > heap[element]) {
			int a2, a1;
			for (int i = 0; i <= digit; i++) {
				if (Vector[i] == element) {
					a1 = i;
					break;
				}
			}
			for (int i = 0; i <= digit; i++) {
				if (Vector[i] == ((element + 1) >> 1) - 1) {
					a2 = i;
					break;
				}
			}
			Vector[a1] = ((element + 1) >> 1) - 1;
			Vector[a2] = element;
			min = heap[element];
			heap[element] = heap[((element + 1) >> 1) - 1];
			heap[((element + 1) >> 1) - 1] = min;
			element = ((element + 1) >> 1) - 1;
		}
		else {
			break;
		}
	}
}

void extract_min(vector <int> &heap, int &number, vector <int> &Vector, int digit) {
	cout << heap[0] << endl;
	int min = heap[0],i;
	heap[0] = heap[number];
	heap[number] = min;
	for (i = 0; i < digit; i++) {
		if (Vector[i] == 0) {
			break;
		}
	}
	Vector[i] = number;
	for (i = 0; i < digit; i++) {
		if (Vector[i] == number) {
			break;
		}
	}
	Vector[i] = 0;
	number--;
	down(heap, 0, number, Vector, digit);
}

int main() {
	string command;
	int number, digit = -1, count = -1;
	vector <int> Vector(1000000), heap(1000000);
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	freopen_s(&input, "priorityqueue.in", "r", stdin);
	freopen_s(&output, "priorityqueue.out", "w", stdout);
	while (cin >> command) {
		if (command[0] == 'p') {
			digit++;
			count++;
			cin >> heap[digit];
			Vector[count] = digit;
			up(heap, digit, Vector, count);
		}
		else if (command[0] == 'e') {
			if (digit >= 0) {
				extract_min(heap, digit, Vector, count);
			}
			else {
				cout << "*\n";
			}
		}
		else {
			cin >> number;
			cin >> heap[Vector[number - 1]];
			up(heap, Vector[number - 1], Vector, count);
			down(heap, Vector[number - 1], digit, Vector, count);
		}
	}
	return 0;
}