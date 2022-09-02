using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWeek05
{
    internal class Program
    {
        #region Task2
        //static void Main(string[] args)
        //{
        //    //2-Write a program to calculate all files and directories count in a given directory(including files and folder in any subdirectory)
        //    DirectoryInfo file = new DirectoryInfo(@"C:\Users\User\OneDrive\Рабочий стол\Lab\MyDatabase");
        //    FileInfo[] nums = file.GetFiles("*", SearchOption.TopDirectoryOnly);
        //    Console.WriteLine(nums.Length.ToString());
        //}
        #endregion Task2 
        #region Task3
        //Create new MyList class from scratch, which work mostly as List.
        //It hsould have void Add(T item), void Remove(T item), void Clear(), bool Contains(T item) methods and Count poperty.
        //We also can iterate this collection via foreach
        //public class MyList<T>
        //{
        //    public T[] asList;           
        //    public MyList()
        //    {
        //        asList = new object[0] as T[];
        //    }   
        //    public void add(T t)
        //    {                
        //        T[] temp = new object[asList.Length + 1] as T[];
        //        for(int i = 0; i < asList.Length; i++)
        //        {
        //            temp[i] = asList[i];
        //        }
        //        temp[asList.Length] = t;
        //        asList = temp;
        //    }
        //    public void remove(int index)
        //    {
        //        if (index < 0 || index >= asList.Length)
        //            return;
        //        T[] temp = new object[asList.Length - 1] as T[];

        //        bool found = false;
        //        for(int i = 0; i < asList.Length; i++)
        //        {
        //            if (i == index)
        //            {
        //                found = true; continue;
        //            }
        //            temp[i - (found ? 1 : 0)] = asList[i];
        //        }
        //        asList = temp;
        //    }
        //    public T get(int index)
        //    {
        //        return asList[index];
        //    }
        //}
        #endregion Task3
        #region Task4
        //Finish TODO section
        //static List<string> ProcessToKill(List<string> process)
        //{
        //    List<string> ProcessToKill = new List<string>(3);
        //    Console.WriteLine(string.Format("capacity{0}", ProcessToKill.Capacity));
        //    Console.WriteLine(string.Format("capacity{0}", ProcessToKill.Count));

        //    foreach (var p in process)
        //    {
        //        if (!p.Equals("Explorer.exe"))
        //        {
        //            ProcessToKill.Add(p);
        //        }
        //        foreach (var p in ProcessToKill) { Console.WriteLine(p); }
        //        return ProcessToKill;
        //    }
        //}
        #endregion Task4
        #region Task5 
        public static void Main()
        {
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };
            foreach (KeyValuePair<string, bool> pair in characters)
            {
                Console.WriteLine(pair.Key);
            }
            Console.WriteLine();
            characters.Remove("Han");
            foreach (KeyValuePair<string, bool> pair in characters)
            {
                Console.WriteLine(pair.Key);
            }
        }
        #endregion Task5
    }
}
