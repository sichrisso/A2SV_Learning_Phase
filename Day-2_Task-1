using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Student Grade Calculator");

        Console.Write("Enter your name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter the number of subjects: ");
        if (!int.TryParse(Console.ReadLine(), out int numSubjects) || numSubjects <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the number of subjects.");
            return;
        }

        Dictionary<string, double> subjectGrades = new Dictionary<string, double>();

        for (int i = 0; i < numSubjects; i++)
        {
            Console.Write($"Enter the name of subject {i + 1}: ");
            string subjectName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(subjectName))
            {
                Console.WriteLine("Subject name cannot be empty. Please try again.");
                i--;
                continue;
            }

            Console.Write($"Enter the grade for {subjectName}: ");
            if (!double.TryParse(Console.ReadLine(), out double grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Please enter a valid numeric grade between 0 and 100.");
                i--;
                continue;
            }

            subjectGrades[subjectName] = grade;
        }
        
        double totalGrade = 0;
        foreach (var grade in subjectGrades.Values)
        {
            totalGrade += grade;
        }
        double averageGrade = totalGrade / numSubjects;

       
        Console.WriteLine($"Student Name: {studentName} ");
        Console.WriteLine("Subject Grades:");
        foreach (var subject in subjectGrades)
        {
            Console.WriteLine($"{subject.Key}: {subject.Value}");
        }
        Console.WriteLine($"Average Grade: {averageGrade}");
    }
}
