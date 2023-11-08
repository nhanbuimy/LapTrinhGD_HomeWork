//Cho mảng gồm các số nguyên có giá trị trong khoảng từ 1 đến k(k < 100).Viết
//hàm in ra số lần xuất hiện của mỗi phần tử trong mảng.
#include <iostream>
using namespace std;
void nhap(int a, int n);
void CountX(int a, int n);
int main13() 
{
    int a[100];
    int n;
    nhap(a, n);
    CountX(a, n);
    system("pause");
    return 0;
}
void nhap(int a[], int n)
{
    do 
    {
        cout << ("Nhap n: ");
        cin >> n;
    } while (n < 2 || n>99);
    for (int i = 0; i < n; i++) 
    {
        cout << "a[" << i << "]: ";
        cin >> a[i];
    }
}
void xuat(int a[], int n) 
{
    for (int i = 0; i < n; i++) 
    {
        cout << "  " << a[i];
    }
}
void CountX(int a[], int n) 
{
    int count = 0, x;

    cout << "\nNhap phan tu can dem: ";
    cin >> x;
    for (int i = 0; i < n; i++) 
    {
        if (a[i] == x)
            count++;
    }
    cout << "\nPhan tu " << x << "xuat hien " << count << "lan" << endl;
}