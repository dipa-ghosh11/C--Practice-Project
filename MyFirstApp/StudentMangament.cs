using System;

class Student{

    
        public string name;
        public int age;
       public  char grade;

        public Student(string studName,int studAge, char studGrade){
            name=studName;
            age=studAge; 
            grade=studGrade;

        }

        public void  displayInfo(){
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Age : "+age);
            Console.WriteLine("Grade : "+grade);
        }

    
}

class StudentManagement{
    public static void Main(string[] args) {
        Console.WriteLine ("Enter name of student: ");
        string name=Console.ReadLine();

        Console.WriteLine ("Enter age of student");
        int age= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Enter grade of student");
        char grade= Convert.ToChar(Console.ReadLine());


        Student stu= new Student(name, age, grade);
        stu.displayInfo();
    }
}