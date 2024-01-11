namespace MatrixAreasCount
{
    internal class App(IMatrixParser matrixParser, IMatrixAreasCalculator matrixAreasCalculator)
    {
        public void Run()
        {
            Console.WriteLine("Enter the matrix string:");
            var matrixString = Console.ReadLine();
            var matrix = matrixParser.ParseMatrix(matrixString);
            var areaCount = matrixAreasCalculator.CountAreas(matrix);
            Console.WriteLine("Output: " + areaCount);
        }
    }
}
