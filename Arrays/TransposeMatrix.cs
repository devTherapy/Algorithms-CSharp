using System.Numerics;
public static class TransaposeMatrix {
    public static int[,] TransposeMatrix(int[,] matrix) {
		// Write your code here.

        int [,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); i++)
            {
                newMatrix[j, i] =   matrix[i, j];
            }
        }

		return newMatrix;
	}
}