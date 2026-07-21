public class Program
{
    public static void Main(string [] args)
    
    {
        int[,] matrix=new int[2,3]
        {
            {10,20,30},
            {40,50,60}
        };

    //   Console.WriteLine("Value= "+ matrix[0,0]);
    //   Console.WriteLine("Value = "+ matrix[0,1]);
    //   Console.WriteLine("Value = "+ matrix[0,2]);
    //   Console.WriteLine("Value = "+ matrix[1,0]);
    //   Console.WriteLine("Value = "+ matrix[1,1]);
    //   Console.WriteLine("Value = "+ matrix[1,2]);

    for(int i=0;i<2;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(matrix[i,j]+"\t");
            }
            Console.WriteLine();
        }
      
    }
}