#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;

template <class T, class Compare = less<T>>
struct node {
	T key;
	unsigned char height;
	node *left;
	node *right;
	int number;
	node(int k) {
		key = k;
		left = right = NULL;
		height = 1;
		number = 0;
	}
};

template <class T, class Compare = less<T>>
class BST {
private:
	node<T> *root;

	unsigned char height(node<T> *element) {
		if (element) {
			return  element->height;
		}
		else {
			return 0;
		}
	}

	int b_factor(node<T> *element) {
		if (element) {
			return height(element->right) - height(element->left);
		}
		else {
			return 0;
		}
	}

	void fix_height(node<T> *element) {
		unsigned char hl = height(element->left);
		unsigned char hr = height(element->right);
		element->height = (hl > hr ? hl : hr) + 1;
	}

	node<T> *rotate_right(node<T> *element) {
		node<T> *New = element->left;
		element->left = New->right;
		New->right = element;
		fix_height(element);
		fix_height(New);
		return New;
	}

	node<T> *rotate_left(node<T> *element) {
		node<T> *New = element->right;
		element->right = New->left;
		New->left = element;
		fix_height(element);
		fix_height(New);
		return New;
	}

	node<T> *balance(node<T> *element) {
		fix_height(element);
		if (b_factor(element) == 2) {
			if (b_factor(element->right) < 0) {
				element->right = rotate_right(element->right);
			}
			return rotate_left(element);
		}
		if (b_factor(element) == -2) {
			if (b_factor(element->left) > 0) {
				element->left = rotate_left(element->left);
			}
			return rotate_right(element);
		}
		return element;
	}

	node<T> *find_max(node<T> *element) {
		while (element->right) {
			element = element->right;
		}
		return element;
	}

	node<T> *find_min(node<T> *element) {
		while (element->left) {
			element = element->left;
		}
		return element;
	}

	void recursive_print(node<T> *element) {
		if (element->left) {
			recursive_print(element->left);
		}
		cout << element->key << ' ';
		if (element->right) {
			recursive_print(element->right);
		}
	}

	node<T> *recursive_insert(node<T> *element, const T &value) {
		if (!element) {
			return new node<T>(value);
		}
		if (value < element->key) {
			element->left = recursive_insert(element->left, value);
		}
		if (value > element->key) {
			element->right = recursive_insert(element->right, value);
		}
		return balance(element);
	}

	node<T> *remove_max(node<T> *element) {
		if (element->right == 0) {
			return element->left;
		}
		element->right = remove_max(element->right);
		return balance(element);
	}

	node<T> *recursive_remove(node<T> *element, const T &value) {
		if (!element) {
			return 0;
		}
		if (value < element->key) {
			element->left = recursive_remove(element->left, value);
		}
		else if (value > element->key) {
			element->right = recursive_remove(element->right, value);
		}
		else {
			node<T> *Left = element->left;
			node<T> *Right = element->right;
			delete element;
			if (!Left) {
				return Right;
			}
			node<T> *min = find_max(Left);
			min->left = remove_max(Left);
			min->right = Right;
			return balance(min);
		}
		return balance(element);
	}

	void recursve_count(node<T> *element, size_t &count) {
		if (element) {
			recursve_count(element->left, count);
			recursve_count(element->right, count);
			count++;
		}
	}

//public public public public public public public public public public public public public public public public public 
public:
	BST() {
		root = NULL;
	}

	BST(const BST<T> &old) {
		root = old.root;
	}

	BST<T> &operator=(const BST<T> &old) {
		this->root = old.root;
	}

	node<T> *begin() {
		return find_min(this->root);
	}

	node<T> *end() {
		return find_max(this->root);
	}

	node<T> *insert(const T &value) {
		this->root = recursive_insert(this->root, value);
		return this->root;
	}

	node<T> *remove(const T &value) {
		this->root = recursive_remove(this->root, value);
		return this->root;
	}

	node<T> *fined(const T &value) {
		node<T> *element = this->root;
		while (element) {
			if (value < element->key) {
				element = element->left;
				continue;
			}
			else if (value > element->key) {
				element = element->right;
				continue;
			}
			else {
				return element;
			}
		}
		return NULL;
	}

	const node<T> *find(const T &value) const{
		node<T> *element = this->root;
		while (element) {
			if (value < element->key) {
				element = element->left;
				continue;
			}
			else if (value > element->key) {
				element = element->right;
				continue;
			}
			else {
				return element;
			}
		}
		return NULL;
	}

	void print() {
		node<T> *element = this->root;
		if (element) {
			recursive_print(element);
			cout << '\n';
		}
	}

	bool empty() const{
		if (!this->root) {
			return true;
		}
		else {
			return false;
		}
	}
	size_t size() {
		size_t count = 0;
		recursve_count(this->root, count);
		return count;
	}
};

int main() {
	BST <int> bst;
	bst.insert(5);
	bst.print();
	bst.insert(2);
	bst.print();
	cout << bst.fined(5)->key << "\n";
	cout << bst.fined(5)->left->key << "\n";
	bst.insert(3);
	bst.print();
	cout << bst.fined(3)->key << "\n";
	cout << bst.fined(3)->left->key << "\n";
	cout << bst.fined(3)->right->key << "\n";
	bst.insert(7);
	bst.print();
	cout << bst.fined(5)->key << "\n";
	bst.insert(58);
	bst.print();
	bst.insert(53);
	bst.print();
	bst.insert(95);
	bst.print();
	bst.remove(5);
	bst.print();
	BST <int> bst1(bst);
	bst1.print();
	BST <int> bst2 = bst;
	bst2.print();
	cout << bst.empty() << '\n';
	cout << int(bst.size()) << '\n';
	cout << bst.begin()->key << '\n';
	cout << bst.end()->key << '\n';
	int a;
	cin >> a;
	return 0;
}