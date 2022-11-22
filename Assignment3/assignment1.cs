using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class student
    {
        public int rollno;
        public string name;
        public student(int r,string n)
        {
            rollno = r;
            name = n;
        }
        public void Displaydetails()
        {
            Console.WriteLine("Rollno is="+ rollno + "and Name is= "+ name );
        }
        
    }
   public class assignment1
    {
        static void Main(string[] args)
        {
            student obj1 = new student(1,"Appu");
            student obj2 = new student(2, "Ammu");
            obj1.Displaydetails();
            obj2.Displaydetails();

        }
    }
}
