using System.Drawing;

internal class Program
{
    static int Sum(int x, int y)
    {
        return x+ y;
    }
    static void Main(string[] args)
    {
        #region Error Types
        #region Syntax Error- Copilation Error
        console.WriteLine("hallo");
        iint z;
        #endregion
        #region RunTime Error
        int x = 5;
        int y = 0;
        Console.WriteLine(x / y);
        #endregion
        #region Logic Error
        int a = 10;
        int b = 5;
        Console.WriteLine(Sum (a , b));
        #endregion
        #region Warning
        int x;
        #endregion
        #endregion
        #region CTS-CLS
        int d = 5;// 4Bytes

        string Name = "test"; //string arry of carracter =2*letters

        #endregion
        #region value type
        int x;  //4 bytes
                // Console.WriteLine(x);
        x = 4;
        int y = 9; //4bytes
        y = x; //4
        x++; //5
        Console.WriteLine(x);
        Console.WriteLine(y);
        #endregion

        #region Referance Type
        Point P01;
        P01 = new Point();
        Point P02 = new Point();
        P02 = P01;
        P01.X = 10;
        Console.WriteLine(P02.X);
        #endregion
        #region Object
        //Point P01 =new Point();
        //P01
        object obj01 = new object();
        //obj = 1;
        //obj = "Hallo";
        //obj = 'A';
        //obj = true;
        object obj02 = new object();  //defrent value
        Console.WriteLine(obj01.GetHashCode());
        Console.WriteLine(obj02.GetHashCode());

        obj01 = obj02; //same value
        Console.WriteLine("***********************");
        Console.WriteLine(obj01.GetHashCode());
        Console.WriteLine(obj02.GetHashCode());

        #endregion
        #region Fraction and Discard
        //int num01 = 12334456789;
        long num02 = 12334456789;

        double num03 = 22.2;
        float num04 = 22.2f;
        decimal num05 = 22.2m;

        int num06 = 1_000_000; //disccard

        #endregion
    }
}