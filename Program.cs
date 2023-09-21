int totalExams = 5;
string studentGrade = "";
string[] studentNames = {"Shubhu","Nakul","Pritam","Gaurav"};
int[] shubMarks = {87, 76, 92, 89, 90};
int[] nakulMarks = {97, 70, 91, 85, 98};
int[] pritamMarks = {82, 86, 90, 82, 100};
int[] gauravMarks = {89, 77, 96, 89, 95};

int[] currentStuMarks = new int[10];

Console.WriteLine($"\nStudent\t\tScore\tGrade\n");    
foreach (string name in studentNames){
    string currentStudent = name;

    if(currentStudent == "Shubhu"){
        currentStuMarks = shubMarks;
    }else if(currentStudent == "Nakul"){
        currentStuMarks = nakulMarks;
    }else if(currentStudent == "Pritam"){
        currentStuMarks = pritamMarks;
    }else{
        currentStuMarks = gauravMarks;
    }

    int marksSum = 0;
    decimal totalScore = 0;
    int gradedExam = 0;

    foreach(int marks in currentStuMarks){
        gradedExam +=1;
        if(gradedExam <= totalExams){
            marksSum += marks;
        }
    }
    totalScore = (decimal)marksSum/totalExams;

    if(totalScore >= 97){
        studentGrade = "A+";
    } else if(totalScore >=93){
        studentGrade = "A";
    } else if(totalScore >=90){
        studentGrade = "A-";
    } else if(totalScore >=87){
        studentGrade = "B+";
    } else if(totalScore >=83){
        studentGrade = "B";
    } else if(totalScore >=80){
        studentGrade = "B-";
    } else if(totalScore >=77){
        studentGrade = "C+";
    } else if(totalScore >=73){
        studentGrade = "C";
    } else if(totalScore >=70){
        studentGrade = "C-";
    } else if(totalScore >=67){
        studentGrade = "D+";
    } else if(totalScore >=63){
        studentGrade = "D";
    } else if(totalScore >=60){
        studentGrade = "D-";
    } else {
        studentGrade = "F";
    }

    Console.WriteLine($"{currentStudent}\t\t{totalScore}\t{studentGrade}");    
}
