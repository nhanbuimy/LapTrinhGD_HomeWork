#include<iostream>
using namespace std;
int arr[10];
int search(int& p);
int main()
{
	for (int i = 0; i < 5; i++)
	{
		cout << "Nhap = ";
		cin >> arr[i];
	}
	int p;
	cout << "Nhap so can tim = ";
	cin >> p;
	int kl = search(p);
	if (p <= -1)
		cout << -100 << endl;
		
	else
		cout << 100 << endl;
	system("pause");
	return 0;
}
int search(int& p)
{
	for (int i = 0; i < 5; i++)
	{
		if (p == arr[i])
			return i;
	}
	return -1;
}