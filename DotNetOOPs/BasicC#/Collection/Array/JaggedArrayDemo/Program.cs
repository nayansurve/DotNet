namespace JaggedArrayDemo;

public class Program
{
    public static void Main(string [] args)
    {
        int[][] numbers=new int[3][];

        numbers[0]=new int[]{10,20,30};
        numbers[1]=new int[]{40,50,60,70};
        numbers[2]=new int[]{80,90};

        for(int i=0;i<numbers.Length;i++)
        {
            for(int j=0;j<numbers[i].Length;j++)
            {
                Console.Write(numbers[i][j]+" ");
            }
            Console.WriteLine();
        }
    }
}