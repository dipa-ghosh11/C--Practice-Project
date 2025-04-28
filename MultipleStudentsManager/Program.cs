// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Student{
    public string name;
    public int age;
    public char grade;

    public Student(string studName, int studAge, char studGrade)
    {
        name = studName;
        age = studAge;
        grade = studGrade;

    }

    public void displayInfo()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
        Console.WriteLine("Grade : " + grade);
        Console.WriteLine();
    }
}


class MultipleStudentsManager{
   public static void Main(string[] args){
        Console.WriteLine("How many students you want to enter?");
        int x= Convert.ToInt32(Console.ReadLine());
        Student[] students = new Student[x];

        for (int i=0;i<x;i++){
            Console.WriteLine($"\n---Enter details for student {i+1}---");

            Console.WriteLine("Enter name of student: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age of student");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter grade of student");
            char grade = Convert.ToChar(Console.ReadLine());

            students[i]=new Student(name,age,grade);
        }

        Console.WriteLine("\n--- Displaying all student details ---\n");
        for (int i=0;i <x; i++)
        {
          
            students[i].displayInfo();
        }
    }
}