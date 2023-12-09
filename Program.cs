using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.XPath;
Random rdm = new ();


// +++++    +++++   +++++   +++++   +++++   Task # 1
/*int num1 = rdm.Next(1,10);
int num2 = rdm.Next(11,20);

string GapNum = "";

int GapSum (int n1, int n2)
{

    if (n1 > n2) {
        Console.WriteLine(GapNum);
        return 0;
    };

    GapNum += n1 + " ";

    n1++;

    return GapSum(n1, n2);
};

GapSum(num1,num2);*/



//+++++    +++++    +++++   +++++   +++++   Task #2
/*int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        throw new ArgumentException("Invalid input");
    }
}

int res = Ackermann(4,0);
Console.WriteLine(res);*/



//+++++    +++++   +++++   +++++   +++++   Task #3

int [] ArrNumber = new int [] {1, 2, 3, 4, 5};
int count = ArrNumber.Length - 1;

int ArrConsole ( int [] arr)
{
    if (count >= 0)
    {
        Console.Write(arr[count] + "\t");
        count--;
        return ArrConsole(arr);
    }
    else
    {
        return 0;
    }
}

ArrConsole(ArrNumber);
