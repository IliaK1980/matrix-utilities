namespace MatrixAreasCount
{
    internal interface IMatrixParser
    {
        bool[,] ParseMatrix(string matrixString);
    }
}