#include <iostream>

using namespace std;

int main() {
//dem so lan xuat hien cua ki tu

	string s;
	cout << "Nhap S: ";
	cin >> s;
	char k;
	cout << "Nhap ki tu K: ";
	cin >> k;
	int sum = 0;
	for (int i = 0; i < s.length(); i++) {
		if (s[i] == k) {
			sum++;
		}
	}
	cout << "So lan xuat hien ki tu K: " << sum;
}
