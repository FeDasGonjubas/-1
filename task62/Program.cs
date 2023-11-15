// Задача 62: Заполните спирально массив 4 на 4

int[][,] FillMtrxFrLeftToRight(int[][,] mtrx)
{
    int[] Start = {mtrx[1][0, 0], mtrx[1][0, 1]};
    int l = mtrx[0].GetLength(1) - mtrx[3][0, 0];
    int value = mtrx[2][0, 0];
    for (int i = 0; i < l; i++)
    {
        mtrx[0][Start[0], Start[1] + i] = value + i;
    }
    mtrx[3][0, 0]++;
    mtrx[2][0, 0] = mtrx[2][0, 0] + l;
    mtrx[1][0, 0] = Start[0] + 1;
    mtrx[1][0, 1] = Start[1] + l - 1;
    // при условии, что следующий элемент равен 0, вызвать следующий метод
    if (mtrx[0][mtrx[1][0, 0], mtrx[1][0, 1]] == 0)
    {
        mtrx = FillMtrxFrUpToDown(mtrx);
        return mtrx;
    }
    else
    {
        return mtrx;
    }
}

int[][,] FillMtrxFrUpToDown(int[][,] mtrx)
{
    int[] Start = {mtrx[1][0, 0], mtrx[1][0, 1]};
    int l = mtrx[0].GetLength(0) - mtrx[3][0, 0];
    int value = mtrx[2][0, 0];
    for (int i = 0; i < l; i++)
    {
        mtrx[0][Start[0] + i, Start[1]] = value + i;
    }
    mtrx[2][0, 0] = mtrx[2][0, 0] + l;
    mtrx[1][0, 0] = Start[0] + l - 1;
    mtrx[1][0, 1] = Start[1] - 1;
    // при условии, что следующий элемент равен 0, вызвать следующий метод
    if (mtrx[0][mtrx[1][0, 0], mtrx[1][0, 1]] == 0)
    {
        mtrx = FillMtrxFrRightToLeft(mtrx);
        return mtrx;
    }
    else
    {
        return mtrx;
    }
}

int[][,] FillMtrxFrRightToLeft(int[][,] mtrx)
{
    int[] Start = {mtrx[1][0, 0], mtrx[1][0, 1]};
    int l = mtrx[0].GetLength(1) - mtrx[3][0, 0];
    int value = mtrx[2][0, 0];
    for (int i = 0; i < l; i++)
    {
        mtrx[0][Start[0], Start[1] - i] = value + i;
    }
    mtrx[3][0, 0]++;
    mtrx[2][0, 0] = mtrx[2][0, 0] + l;
    mtrx[1][0, 0] = Start[0] - 1;
    mtrx[1][0, 1] = Start[1] - l + 1;
    // при условии, что следующий элемент равен 0, вызвать следующий метод
    if (mtrx[0][mtrx[1][0, 0], mtrx[1][0, 1]] == 0)
    {
        mtrx = FillMtrxFrDownToUp(mtrx);
        return mtrx;
    }
    else
    {
        return mtrx;
    }
    // return mtrx;
}

int[][,] FillMtrxFrDownToUp(int[][,] mtrx)
{
    int[] Start = {mtrx[1][0, 0], mtrx[1][0, 1]};
    int l = mtrx[0].GetLength(0) - mtrx[3][0, 0];
    int value = mtrx[2][0, 0];
    for (int i = 0; i < l; i++)
    {
        mtrx[0][Start[0] - i, Start[1]] = value + i;
    }
    // mtrx[3][0, 0]++;
    mtrx[2][0, 0] = mtrx[2][0, 0] + l;
    mtrx[1][0, 0] = Start[0] - l + 1;
    mtrx[1][0, 1] = Start[1] + 1;
    // при условии, что следующий элемент равен 0, вызвать следующий метод
    if (mtrx[0][mtrx[1][0, 0], mtrx[1][0, 1]] == 0)
    {
        mtrx = FillMtrxFrLeftToRight(mtrx);
        return mtrx;
    }
    else
    {
        return mtrx;
    }
    // return mtrx;
}

void PrintDoubleArray(int[][,] arr)
{
    for (int i = 0; i < arr[0].GetLength(0); i++)
    {
        for (int j = 0; j < arr[0].GetLength(1); j++)
        {
            Console.Write(arr[0][i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

int[][,] Matrix = new int[4][,];
Matrix[0] = new int[6,6]; // матрица
Matrix[1] = new int[1, 2]; // координаты точки для начала заполнения линии
Matrix[2] = new int[1, 1]; // значение, с которого начинается заполнение линии
Matrix[2][0, 0] = 1; // значение, с которого начинается заполнение линии
Matrix[3] = new int[1, 1]; // количество уже сделанных вторых поворотов
Matrix = FillMtrxFrLeftToRight(Matrix);
PrintDoubleArray(Matrix);