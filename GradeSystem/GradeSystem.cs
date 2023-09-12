using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeConvert
{
    internal class Grade
    {


        static void ReadScore(string[] subject, int[] point)
        {
            for (int i = 0; i < subject.Length; i++)
            {

                Console.WriteLine("Type in " + subject[i] + " score" + ":");

                int score = Convert.ToInt32(Console.ReadLine());
                point[i] = score;

            }
        }

        static void ConvertScore(string[] subject, int[] point, char[] grade)
        {

            for (int i = 0; i < subject.Length; i++)

            {
                if (point[i] == 100)
                    grade[i] = 'A';
                else if (point[i] >= 90 && point[i] < 100)
                    grade[i] = 'B';
                else if (point[i] >= 80 && point[i] < 90)
                    grade[i] = 'C';
                else if (point[i] >= 70 && point[i] < 80)
                    grade[i] = 'C';
                else if (point[i] >= 60 && point[i] < 70)
                    grade[i] = 'D';
                else
                    grade[i] = 'F';
            }
        }

        static void PrintGrade(string[] subject, char[] grade)
        {

            for (int i = 0; i < subject.Length; i++)
                Console.WriteLine("Grade for " + subject[i] + ": " + grade[i]);
        }

        static void CountNumber(string[] subject, char[] grade, int[] point)
        {
            int numA = 0;
            int numC = 0;
            int numF = 0;
            int sum = 0;

            for (int i = 0; i < subject.Length; i++)
            {

                if (grade[i] == 'A') numA++;

                else if (grade[i] == 'C') numC++;

                else if (grade[i] == 'F') numF++;

                sum = sum + point[i];
            }

            Console.WriteLine("You have " + numA + " A");
            Console.WriteLine("You have " + numC + " C");
            Console.WriteLine("You have " + numF + " F");
            Console.WriteLine("Your total score is：" + sum);


        }

        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to log in !---");
            string[] subject = { "Mathematics", "Swedish", "English", "History", "Physics" };
            int[] point = new int[5];
            char[] grade = new char[6];
            ReadScore(subject, point);
            ConvertScore(subject, point, grade);
            PrintGrade(subject, grade);
            CountNumber(subject, grade, point);
            Console.WriteLine("Thank you!");

        }


    }
}
