using System;

namespace class_inharitence_console_program
{

    class student
    {
        protected string name;
        protected int rollno;
        public void setstudent(string name, int roll)
        {
            this.name = name;
            this.rollno = roll;
        }

        public void getstudent()
        {
            Console.WriteLine("Student Name : " + name + " Student Roll No : " + rollno);
        }
    }

    class subject : student
    {
        protected string sub_name;
        protected int sub_no;
        public void setsubject(string name, int roll)
        {
            this.sub_name = name;
            this.sub_no = roll;
        }

        public void getsubject()
        {
            Console.WriteLine("Subject Name : " + sub_name + " Subject No : " + sub_no);
        }
    }
    class teacher : subject
    {

        public void setv(string sname, int sroll, string sb, int sno)
        {
            setstudent(sname, sroll);
            setsubject(sb, sno);
        }

        public void getv()
        {
            getstudent();
            getsubject();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            teacher obj = new teacher();
            Console.WriteLine("Enter Student Name");
            string std_name = Console.ReadLine();
            Console.WriteLine("Enter Student Roll No");
            int std_roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject Name");
            string sub_name = Console.ReadLine();
            Console.WriteLine("Enter Subject No");
            int sub_roll = Convert.ToInt32(Console.ReadLine());
            obj.setv(std_name,std_roll,sub_name,sub_roll);
            obj.getv();
            
         Console.ReadKey();

        }
    }
}
