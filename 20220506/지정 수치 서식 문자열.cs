using System;

class Program
{
    static void Main()
    {
        //C = countOfCases
        int C = int.Parse(Console.ReadLine());
        for (int i = 0; i < C; i++)
        {
            string[] Input = Console.ReadLine().Split(' ');
            int numberOfStudents = int.Parse(Input[0]);
            float[] scores = new float[numberOfStudents];
            for (int j = 0; j < numberOfStudents; j++)
            {
                scores[j] = int.Parse(Input[j + 1]);
            }
            //점수 전체의 합
            float total = 0f;
            for (int j = 0; j < numberOfStudents; j++)
            {
                total = total + scores[j];
            }
            //평균점수
            float average = total / numberOfStudents;
            //평균점수 이상 점수의 갯수
            float countOfOverScore = 0f;
            for (int j = 0; j < numberOfStudents; j++)
            {
                if (scores[j] > average)
                {
                    countOfOverScore++;
                }
            }
            //결과값
            float result = (countOfOverScore / numberOfStudents);

            Console.WriteLine("{0:0.000%}", result);
        }
    }
}

//지정 수치 서식 문자열
//https://blog.hexabrain.net/128