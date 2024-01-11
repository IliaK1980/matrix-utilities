namespace MatrixAreasCount
{
    internal class MatrixParser : IMatrixParser
    {
        public bool[,] ParseMatrix(string matrixString)
        {
            var rows = matrixString.Split(';');
            var numRows = rows.Length;
            var numCols = rows[0].Split(',').Length;
            var matrix = new bool[numRows, numCols];

            for (var i = 0; i < numRows; i++)
            {
                var cols = rows[i].Split(',');
                for (var j = 0; j < numCols; j++)
                {
                    matrix[i, j] = cols[j] == "1";
                }
            }

            return matrix;
        }
    }
}
