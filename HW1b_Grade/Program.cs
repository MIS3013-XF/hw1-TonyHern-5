// HW1b Grade

// Your Name: Tony Hernandez
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double hw;
            double participation;
            double exam1;
            double exam2;
            double exam3;
            double finalgrade;

            string HWString;
            string ParticipationString;
            string Exam1String;
            string Exam2String;
            string Exam3String;
            string FirstName;
            string LastName;
            string StudentID;
            


            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            StudentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            HWString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for class participation?");
            ParticipationString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            Exam1String = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            Exam2String = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 3 ?");
            Exam3String = Console.ReadLine();

            hw = Convert.ToDouble(HWString);
            participation = Convert.ToDouble(ParticipationString);
            exam1 = Convert.ToDouble(Exam1String);
            exam2 = Convert.ToDouble(Exam2String);
            exam3 = Convert.ToDouble(Exam3String);

            double WeightHW;
            double WeightParticipation;
            double WeightExam1;
            double WeightExam2;
            double WeightExam3;

            WeightHW = hw * 0.2;
            WeightParticipation = participation * 0.15;
            WeightExam1 = exam1 * 0.15;
            WeightExam2 = exam2 * 0.25;
            WeightExam3 = exam3 * 0.25;


            finalgrade = WeightHW + WeightParticipation + WeightExam1 + WeightExam2 + WeightExam3;

            Console.WriteLine($"{FirstName} {LastName} ({StudentID}), your final grade is {finalgrade}%");

            Console.ReadKey();

            


        }
    }
}
