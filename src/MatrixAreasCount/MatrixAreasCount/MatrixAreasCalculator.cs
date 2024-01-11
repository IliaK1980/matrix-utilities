namespace MatrixAreasCount
{
    internal class MatrixAreasCalculator : IMatrixAreasCalculator
    {
        public int CountAreas(bool[,] matrix)
        {
            var areasCount = 0;
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);

            var visited = new bool[rows, columns];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    if (matrix[i, j] && !visited[i, j])
                    {
                        VisitMatrixCell(matrix, visited, i, j);
                        areasCount++;
                    }
                }
            }

            return areasCount;
        }

        private static void VisitMatrixCell(bool[,] matrix, bool[,] visited, int row, int column)
        {
            var neighborRows = new int[] { -1, 0, 0, 1 };
            var neighborColumns = new int[] { 0, -1, 1, 0 };

            visited[row, column] = true;

            for (var k = 0; k < 4; k++)
            {
                var r = row + neighborRows[k];
                var c = column + neighborColumns[k];
                if (CanVisitMatrixCell(matrix, visited, r, c))
                {
                    VisitMatrixCell(matrix, visited, r, c);
                }
            }
        }

        private static bool CanVisitMatrixCell(bool[,] matrix, bool[,] visited, int row, int column)
        {
            return (row >= 0) && (row < matrix.GetLength(0)) &&
                   (column >= 0) && (column < matrix.GetLength(1)) &&
                   matrix[row, column] && !visited[row, column];
        }
    }
}
