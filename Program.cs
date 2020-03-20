using System;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = 1;
            while (command == 1)
            {
                Console.WriteLine("         1.数的相加");
                Console.WriteLine("         2.求素数");
                Console.WriteLine("         3.最大公约数");
                Console.WriteLine("         4.打印乘法表");
                Console.WriteLine("         5.求解二次方程的根");
                Console.WriteLine("         6.求最大数");
                Console.WriteLine("         7.排序");
                Console.WriteLine("         8.退出");
                Console.WriteLine("请选择：");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Add(); break;
                    case 2: sushu(); break;
                    case 3: max_yue(); break;
                    case 4: chnengfa(); break;
                    case 5: erci(); break;
                    case 6: max_num(); break;
                    case 7: paixu(); break;
                    case 8: command = 0; break;
                }
            }
            static void Add()
            {
                int[] a = new int[5];
                int sum = 0;
                Console.WriteLine("请输入相加的数:");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    sum += a[i];
                }
                Console.WriteLine(sum);
            }
            
            static void sushu()
            {
                Console.WriteLine("请输入一个数：");
                int flag = 1;
                int a = int.Parse(Console.ReadLine());
                for (int i = 2; i < Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine("该数是素数！");
                else
                    Console.WriteLine("该数不是素数！");
            }
            static void max_yue()
            {
                Console.WriteLine("454687");
            }
            static void chnengfa()
            {
                Console.WriteLine("454687");
            }
            static void erci()
            {
                Console.WriteLine("454687");
            }
            static void max_num()
            {
                int[] a = new int[5];
                int max = 0;
                Console.WriteLine("请输入五个数字:");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if (a[i] > max)
                        max = a[i];
                }
                Console.WriteLine(max);

            }
            static void paixu()
            {
                int[] a = new int[5];
                int temp = 0;
                Console.WriteLine("请输入五个数字:");
                for (int i = 0; i < a.Length; i++)
                    a[i] = int.Parse(Console.ReadLine());
                for (int i = 0; i < a.Length - 1; i++)
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] > a[j + 1])
                        {
                            temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                for (int k = 0; k < a.Length; k++)
                {
                    Console.Write("{1}", k, a[k]);
                }
            }
        }
    }
}
