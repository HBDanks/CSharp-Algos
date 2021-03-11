/*
Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
*/

public class PascalTriangleSolution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> triangle = new List<IList<int>>();
        while(numRows > 0)
        {
            List<int> row = new List<int>();
            row.Add(1);
            int lastRow = triangle.Count-1;
            if(lastRow > 0)
            {
                for(int i = 1; i < triangle[lastRow].Count; i++)
                {
                    row.Add(triangle[lastRow][i] + triangle[lastRow][i-1]);
                }
            }
            if (lastRow >= 0)
            {
                row.Add(1);
            }
            triangle.Add(row);
            numRows -= 1;
        }
        return triangle;
    }
}