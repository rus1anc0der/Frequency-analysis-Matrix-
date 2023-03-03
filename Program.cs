Console.WriteLine("Введите размер матрицы");
Console.Write("Строк?: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбцов?: ");
int col = int.Parse(Console.ReadLine());

int [,] matrix = getMatrix(row,col);

for (int i = 0; i < matrix.GetLength(0); i++){

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine($"{matrix[i,j]} встречается в матрице: {find(matrix, i ,j)} раз ");
    }
}
// Создаем матрицу из случайных значений
int [,] getMatrix (int row , int col){

    int[,] matrix = new int[row,col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,50);
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}
//Находим повторяющиеся значения, считаем и возвращаем 
int find(int [,]matrix, int row, int col){
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[row,col] == matrix[i,j]){
                count +=1;
            }
        }
    }
    return count;
}

