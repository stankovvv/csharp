using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
//use arrs instead of vars
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] chrisScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] ericScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] gregorScores = new int[] { 90, 95, 87, 88, 96, 96 };
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[] { 10 };

string currentStudentLetterGrade = "";
    
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;
//add some new guys to test
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int sumAssigmentScores = 0;
    
    decimal currentStudentGrade = 0;

    int gradeAssigments = 0;
    


    foreach (int score in studentScores)
    {
        gradeAssigments+= 1;

        if (gradeAssigments <= currentAssignments)
            sumAssigmentScores += score;

        else 
            sumAssigmentScores += score/10;

    }

    currentStudentGrade = (decimal)sumAssigmentScores / currentAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

   
    Console.WriteLine($"{name}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

}
Console.WriteLine("Press any key to continue.");
Console.ReadKey();