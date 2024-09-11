using System;
public class baitap
{
    public void baitap1()
    {
        Console.WriteLine("nhap so luong mang:");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        Console.WriteLine("nhap phan tu mang:");
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
        int Tong = 0;
        for (int i = 0; i < n; i++)
        {
            Tong += A[i];
        }
        Console.WriteLine("tong cac phan tu trong mang la:" + Tong);
    }
    public void baitap2()
    {
        int dem = 0;
        Console.WriteLine("nhap vao chuoi ky tu:");
        string Chuoi = Console.ReadLine();
        for (int i = 0; i < Chuoi.Length; i++)
        {
            if (Chuoi[i] != ' ' && Chuoi[i] != ',')
            {
                dem++;
            }

        }
        Console.WriteLine("Tong so luong: " + dem);
    }
    public void baitap3()
    {
        Console.WriteLine("nhap so luong mang:");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        Console.WriteLine("nhap tung phan tu mang:");
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
            }
        }
        Console.WriteLine("Phan tu lon nhat trong mang :" + max);
    }
    public void baitap4()
    {
        Console.WriteLine("Nhap vao chuoi:");
        string Chuoi = Console.ReadLine();
        Char[] CHUOI = Chuoi.ToCharArray();
        Array.Reverse(CHUOI);
        string Chuoi_new = new string(CHUOI);
        Console.WriteLine("chuoi sau khi dau nguoc la: " + Chuoi_new);
    }
    public void baitap5()
    {
        int[] A = { 1, 3, 4, 3, 1 };
        int checkin = 1;
        for (int i = 0; i < A.Length / 2; i++)
            if (A[i] != A[A.Length - i - 1])
            {
                checkin = 0;
                break;
            }
        if (checkin == 1)
            Console.WriteLine("Mang doi xung!");
        else
            Console.WriteLine("Khong doi xung!");
    }
    public void baitap6()
    {
        Console.WriteLine("nhap vao chuoi ky tu:");
        string Chuoi = Console.ReadLine();
        char[] CHUOI = Chuoi.ToCharArray();
        Console.WriteLine("nhap vao ky tu can dem:");
        char n = Convert.ToChar(Console.ReadLine());
        int dem = 0;
        for (int i = 0; i < CHUOI.Length; i++)
        {
            if (CHUOI[i] == n)
            {
                dem++;
            }
        }
        Console.WriteLine($"so luot cua {n}:" + dem);
    }
}
