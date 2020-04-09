using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ScoreManage
{
    public class CPerson 
    {
        private string name;
        private int number;
        private string sex;

        public CPerson(string name1, int number1, string sex1)
        {
            name = name1;
            number = number1;
            sex = sex1;
        }


        public CPerson()
        {
            name = "";
            number = 0;
            sex = "";

        }

        public virtual void input_data()
        {
            Console.WriteLine("请输入您的姓名：");
            string name = Console.ReadLine();
            set_name(name);
            Console.WriteLine("请输入您的姓别：");
            string sex = Console.ReadLine();
            set_sex(sex);
            Console.WriteLine("请输入您的编号：");
            int number = int.Parse(Console.ReadLine());
            set_number(number);
        }
        public virtual void output_data()
        {
            //Console.WriteLine("您的姓名为：{0}  ","您的编号为：{1}  ","您的性别为：{2}",this.get_name(),this.get_number(),this.get_sex());
            Console.WriteLine("您的姓名为：{0}   您的编号为：{1}   您的性别为：{2}", this.get_name(), this.get_number(), this.get_sex());
            Console.WriteLine();
        }
        public string get_name()
        {
            return name;
        }
        public int get_number()
        {
            return number;
        }
        public string get_sex()
        {
            return sex;
        }
        public void set_name(string name1)
        {
            name = name1;
        }
        public void set_number(int number1)
        {
            number = number1;
        }
        public void set_sex(string sex1)
        {
            sex = sex1;
        }
    }
    public class CStudent:CPerson                     //定义了一个学生类
    {
        ArrayList ID = new ArrayList(3);     //把学生的学号，姓名，英语、数学、C#成绩分别放在动态数组中。
        ArrayList Name = new ArrayList(3);
        ArrayList English_Score = new ArrayList(3);
        ArrayList Math_Score = new ArrayList(3);
        ArrayList VisualCshap_Score = new ArrayList(3);
        public void Menu()                   //主菜单
        {
            Console.WriteLine("主菜单：");
            Console.WriteLine("1.编写学生信息。");
            Console.WriteLine("2.查看学生信息。");
            Console.WriteLine("3.删除学生信息。");
            Console.WriteLine("4.生成学生成绩单。");
            Console.WriteLine("5.安全退出。");
            Console.WriteLine("______________________________________");
            Console.WriteLine("请选择（以回车键结束）。");
        }
        public void Menu1()                  //小菜单1
        {
            Console.WriteLine("1.添加学生信息。");
            Console.WriteLine("2.插入学生信息。");
            Console.WriteLine("3.修改学生信息。");
            Console.WriteLine("______________________________________");
            Console.WriteLine("请选择（以回车键结束）。");
        }
        public void Menu2()                 //小菜单2
        {
            Console.WriteLine("1.按学号查询");
            Console.WriteLine("2.按姓名查询");
            Console.WriteLine("______________________________________");
            Console.WriteLine("请选择（以回车键结束）。");
        }
        public void Menu3()                 //小菜单3
        {
            Console.WriteLine("1.按学号删除");
            Console.WriteLine("2.按姓名删除");
            Console.WriteLine("______________________________________");
            Console.WriteLine("请选择（以回车键结束）。");
        }
        public void Menu4()                //小菜单4
        {
            Console.WriteLine("1.按录入顺序输出成绩单");
            Console.WriteLine("2.按总成绩排序输出成绩单");
            Console.WriteLine("3.按英语成绩输出成绩单");
            Console.WriteLine("4.按数学成绩输出成绩单");
            Console.WriteLine("5.按C#成绩输出成绩单");
            Console.WriteLine("______________________________________");
            Console.WriteLine("请选择（以回车键结束）。");
        }
        public void input()               //添加学生信息的函数
        {
            Console.Write("学号:\t");
            ID.Add(Console.ReadLine());
            Console.Write("姓名:\t");
            Name.Add(Console.ReadLine());
            Console.Write("英语成绩:\t");
            English_Score.Add(Console.ReadLine());
            Console.Write("数学成绩:\t");
            Math_Score.Add(Console.ReadLine());
            Console.Write("visual C#成绩:\t");
            VisualCshap_Score.Add(Console.ReadLine());
        }
        public void insert(int i)          //插入学生信息的函数，使用动态数组插入函数
        {
            Console.Write("学号:\t");
            ID.Insert(i, Console.ReadLine());
            Console.Write("姓名:\t");
            Name.Insert(i, Console.ReadLine());
            Console.Write("英语成绩:\t");
            English_Score.Insert(i, Console.ReadLine());
            Console.Write("数学成绩:\t");
            Math_Score.Insert(i, Console.ReadLine());
            Console.Write("visual C#成绩:\t");
            VisualCshap_Score.Insert(i, Console.ReadLine());
        }
        public void index_show(int i)      //输出索引结果的函数
        {
            double Sum;
            double Ave;
            Sum = (Convert.ToDouble(English_Score[i]) + Convert.ToDouble(Math_Score[i]) + Convert.ToDouble(VisualCshap_Score[i]));
            Ave = (Convert.ToDouble(Sum) / 3);
            Console.WriteLine("学号:\t姓名:\t英语:\t数学:\tC#分:\t总分:\t平均分:\t");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6:#.00}\t", ID[i], Name[i], English_Score[i], Math_Score[i], VisualCshap_Score[i], Sum, Ave);
        }
        public void move_show()           //输出排序后信息的函数
        {
            for (int i = 0; i < ID.Count; i++)
            {
                double Sum;
                double Ave;
                Sum = (Convert.ToDouble(English_Score[i]) + Convert.ToDouble(Math_Score[i]) + Convert.ToDouble(VisualCshap_Score[i]));
                Ave = (Convert.ToDouble(Sum) / 3);
                Console.WriteLine("学号:\t姓名:\t英语:\t数学:\tC#分:\t总分:\t平均分:\t");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6:#.00}\t", ID[i], Name[i], English_Score[i], Math_Score[i], VisualCshap_Score[i], Sum, Ave);
            }
        }
        public void index_remove(int i)           //删除学生信息的函数
        {
            ID.RemoveAt(i);
            Name.RemoveAt(i);
            English_Score.RemoveAt(i);
            Math_Score.RemoveAt(i);
            VisualCshap_Score.RemoveAt(i);
        }
        public void move(ArrayList temp)              //排序的函数
        {
            for (int i = ID.Count - 1; i > 0; i--)      //冒泡排序法
            {
                for (int j = 0; j < i; j++)
                {
                    if (Convert.ToDouble(temp[j]) < Convert.ToDouble(temp[j + 1]))
                    {
                        object Temp;
                        Temp = ID[j];
                        ID[j] = ID[j + 1];
                        ID[j + 1] = Temp;
                        Temp = Name[j];
                        Name[j] = Name[j + 1];
                        Name[j + 1] = Temp;
                        Temp = English_Score[j];
                        English_Score[j] = English_Score[j + 1];
                        English_Score[j + 1] = Temp;
                        Temp = Math_Score[j];
                        Math_Score[j] = Math_Score[j + 1];
                        Math_Score[j + 1] = Temp;
                        Temp = VisualCshap_Score[j];
                        VisualCshap_Score[j] = VisualCshap_Score[j + 1];
                        VisualCshap_Score[j + 1] = Temp;
                    }
                }
            }
        }
        public void move_Sum(ArrayList temp1, ArrayList temp2, ArrayList temp3)   //按总成绩排序的函数
        {
            for (int i = ID.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Convert.ToDouble(temp1[j]) + Convert.ToDouble(temp2[j]) + Convert.ToDouble(temp3[j]) < Convert.ToDouble(temp1[j + 1]) + Convert.ToDouble(temp2[j + 1]) + Convert.ToDouble(temp3[j + 1]))
                    {
                        object Temp;
                        Temp = ID[j];
                        ID[j] = ID[j + 1];
                        ID[j + 1] = Temp;
                        Temp = Name[j];
                        Name[j] = Name[j + 1];
                        Name[j + 1] = Temp;
                        Temp = English_Score[j];
                        English_Score[j] = English_Score[j + 1];
                        English_Score[j + 1] = Temp;
                        Temp = Math_Score[j];
                        Math_Score[j] = Math_Score[j + 1];
                        Math_Score[j + 1] = Temp;
                        Temp = VisualCshap_Score[j];
                        VisualCshap_Score[j] = VisualCshap_Score[j + 1];
                        VisualCshap_Score[j + 1] = Temp;
                    }
                }
            }
        }
        public int index(ArrayList temp)                          //检索方法，返回索引值
        {
            int T;
            return T = temp.IndexOf(Console.ReadLine());
        }
        public void operate()                                  //《《主程序方法》》
        {
            CStudent student = new CStudent();                  //学生类初始化对象
        Return: Console.Clear();                // goto Return;用于返回主菜单的语句的标签所在
            student.Menu();
            byte Number;
            Number = Convert.ToByte(Console.ReadLine());
            switch (Number)
            {
                case 1:                                     //实现编写学生信息的代码
                    Console.Clear();
                    student.Menu1();
                    Number = Convert.ToByte(Console.ReadLine());
                    switch (Number)
                    {
                        case 1:                            //实现添加学生信息的代码。
                            Console.Clear();
                            Console.WriteLine("请输入学生信息（以回车键结束）。");
                            student.input();
                            Console.WriteLine("是否继续输入？是请输入‘y’返回主菜单请输入‘n’(以回车键结束！)");
                            char ch = char.Parse(Console.ReadLine());
                            while (ch == 'y')
                            {
                                Console.Clear();
                                student.input();
                                Console.WriteLine("是否继续输入？是请输入‘y’返回主菜单请输入‘n’(以回车键结束！)");
                                ch = char.Parse(Console.ReadLine());
                            }
                            break;
                        case 2:                                 //实现插入学生信息的代码。
                            Console.Clear();
                            Console.WriteLine("1.按学号插入学生信息。");
                            Console.WriteLine("2.按索引插入学生信息。");
                            Console.WriteLine("______________________________________");
                            Console.WriteLine("请选择（以回车键结束）。");
                            Number = Convert.ToByte(Console.ReadLine());
                            switch (Number)
                            {
                                case 1:
                                    Console.WriteLine("请输入要插入的学生的前一个人的学号");
                                    int j = student.index(student.ID); //没有找到时返回值是-1
                                    if (j == -1)
                                    {
                                        Console.WriteLine("查无此人！无法插入信息。");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("请输入要插入的学生信息。（以回车键结束。");
                                        student.insert(j + 1);
                                    }
                                    Console.WriteLine("按回车键返回主菜单");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("请输入要插入信息的位置(索引从0开始，以回车键结束！)");
                                    int i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("请输入要插入的学生信息。（以回车键结束)");
                                    student.insert(i);
                                    Console.WriteLine("按回车键返回主菜单");
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case 3:                               //实现修改学生信息的代码
                            Console.Clear();
                            Console.WriteLine("请输入要修改信息的学生学号");
                            int n = index(student.ID);
                            Console.WriteLine("请输入要修改的学生信息");
                            student.index_remove(n);
                            student.insert(n);
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("输入错误！请按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                    }
                    goto Return;
                case 2:                                          // 2.查看学生信息。
                    Console.Clear();
                    student.Menu2();
                    Number = Convert.ToByte(Console.ReadLine());
                    switch (Number)
                    {
                        case 1:
                            Console.Clear();                  //实现按学号查询的代码
                            Console.WriteLine("请输入学生学号（以回车键结束）。");
                            int j = student.index(student.ID);      //没有找到时返回值是-1
                            if (j == -1)
                            {
                                Console.WriteLine("查无此人！");
                            }
                            else
                            {
                                student.index_show(j);
                            }
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();                       //实现按姓名查询的代码
                            Console.WriteLine("请输入学生姓名以回车键结束）。");
                            j = student.index(student.Name);
                            if (j == -1)
                            {
                                Console.WriteLine("查无此人！");
                            }
                            else
                            {
                                student.index_show(j);
                            }
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                    }
                    goto Return;
                case 3:                                              //3.删除学生信息。
                    Console.Clear();
                    Console.WriteLine("3.删除学生信息。");
                    student.Menu3();
                    Number = Convert.ToByte(Console.ReadLine());
                    switch (Number)
                    {
                        case 1:                                     // 实现按学号删除的代码
                            Console.Clear();
                            Console.WriteLine("请输入学生学号（以回车键结束）。");
                            int j = student.index(student.ID);       //没有找到时返回值是-1
                            if (j == -1)
                            {
                                Console.WriteLine("查无此人！无法删除！！！");
                            }
                            else
                            {
                                student.index_remove(j);
                            }
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                        case 2:                                     //实现按姓名删除的代码
                            Console.Clear();
                            Console.WriteLine("请输入学生姓名（以回车键结束）。");
                            j = student.index(student.Name);         //没有找到时返回值是-1
                            if (j == -1)
                            {
                                Console.WriteLine("查无此人！无法删除！！！");
                            }
                            else
                            {
                                student.index_remove(j);
                            }
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                    }
                    goto Return;
                case 4:                                     //4.查看学生成绩单,学生成绩排序。
                    Console.Clear();
                    student.Menu4();
                    Number = Convert.ToByte(Console.ReadLine());
                    switch (Number)
                    {
                        case 1:                             //实现按录入顺序输出成绩单的代码
                            Console.Clear();
                            student.move_show();
                            Console.WriteLine("按回车健返回主菜单");
                            Console.ReadLine();
                            break;
                        case 2:                         //实现按总成绩排序输出成绩单的代码
                            Console.Clear();
                            student.move_Sum(student.English_Score, student.Math_Score, student.VisualCshap_Score);
                            student.move_show();
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                        case 3:                           //实现按英语成绩输出成绩单的代码
                            Console.Clear();
                            student.move(student.English_Score);
                            student.move_show();
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                        case 4:                          //实现按数学成绩输出成绩单的代码
                            Console.Clear();
                            student.move(student.Math_Score);
                            student.move_show();
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                        case 5:                       // 实现按C#成绩输出成绩单的代码
                            Console.Clear();
                            student.move(student.VisualCshap_Score);
                            student.move_show();
                            Console.WriteLine("按回车键返回主菜单");
                            Console.ReadLine();
                            break;
                    }
                    goto Return;
                case 5:                                        //安全退出
                    Console.Clear();
                    Console.WriteLine("5.安全退出。");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("输入错误！请重输。");
                    goto Return;
            }
        }
    }

    public class CTeacher:CPerson
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            CStudent stud = new CStudent();
            stud.operate();                       //调用主程序函数的语句
        }
    }
}
