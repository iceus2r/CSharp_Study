using System;
using System.IO;
using System.Collections.Generic;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int[,] sudoku = new int[9, 9];
List<Tuple<int, int>> blank = new List<Tuple<int, int>>();

bool isOK = false;

for (int row = 0; row < 9; row++)
{
    string[] input = sr.ReadLine().Split();
    for (int col = 0; col < 9; col++)
    {
        int number = int.Parse(input[col]);
        sudoku[row, col] = number;
        if (number == 0) blank.Add(new Tuple<int, int>(row, col));
    }
}

InputNumber(0);

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        sw.Write(sudoku[i, j]);
        sw.Write(" ");
    }
    sw.WriteLine();
}

sw.Close();

void InputNumber(int blankIdx)
{
    if (blankIdx == blank.Count)
    {
        isOK = true;
        return;
    }

    int row = blank[blankIdx].Item1;
    int col = blank[blankIdx].Item2;

    for (int i = 1; i <= 9; i++)
    {
        if (Check(row, col, i))
        {
            sudoku[row, col] = i;
            InputNumber(blankIdx + 1);
        }

        if (isOK) return;
    }

    sudoku[row, col] = 0;
}

bool Check(int row, int col, int num)
{
    for (int i = 0; i < 9; i++)
    {
        if (sudoku[row, i] == num || sudoku[i, col] == num) return false;
    }

    int rowBy3 = row / 3 * 3;
    int colBy3 = col / 3 * 3;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (sudoku[rowBy3 + i, colBy3 + j] == num) return false;
        }
    }

    return true;
}