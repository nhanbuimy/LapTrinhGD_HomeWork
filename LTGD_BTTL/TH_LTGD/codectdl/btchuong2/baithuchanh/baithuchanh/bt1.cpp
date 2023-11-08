#include<iostream>
using namespace std;
const int Max = 100;
int a[Max];
int n;
void nhapn(int &n)
{
	do {
		cout << "Nhap so phan tu = ";
		cin >> n;
		if (n<0 || n>Max)
			cout << "Nhap sai, nhap lai. ";
	} while (n<0 || n>Max);
}
void nhapds(int &n)
{
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap a[" << i << "] = ";
		cin >> a[i];
	}
}
void xuatds(int &n)
{
	for (int i = 0; i < n; i++)
	{
		 
		cout << "a[" << i << "] = " << a[i] << "\t";
	}
}
int search(int& p)
{
	for (int i = 0; i < n; i++)
	{
		if (p == a[i])
			return i;
	}
	return -1;
}
int insertlast(int& x, int& n)
{
	if (n < Max)
	{
		a[n] = x;
		n++;
		return 1;
	}
	return 0;
}
int deletetlast(int& n)
{
	if (n > 0)
	{
		n--;
		return 1;
	}
	return 0;
}
int deletex(int& x, int vt)
{
	for (int i = vt; i < n; i++)
	{
		a[i] = a[i + 1];
	}
	n--;
	return 1;
}
//int delete_vitri(int& x, int& n)
//{
//	int kq = tim(x);
//	if (kq > -1)
//	{
//		if (kq == n - 1)
//		{
//			if (deletetlast(n) == 1)
//			{
//				cout << "Xoa phan tu trung hop nam o cuoi\n";
//				xuatds(n);
//			}
//		}
//		else
//		{
//			if (deletex(x, kq) == 1)
//			{
//				cout << "Xoa phan tu tai 1 vi tri = " << kq << endl;
//				xuatds(n);
//			}
//		}
//		return 1;
//	}
//	return 0;
//}
int main()
{
	int n, x;
	nhapn(n);
	nhapds(n);
	xuatds(n);
	int p;
	cout << "Nhap so can tim = ";
	cin >> p;
	int kl = search(p);
	if (p > -1)
		cout << "Tim thay\n";
	else
		cout << "Khong tim thay\n";
	system("pause");
	return 0;
}