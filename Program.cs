//PRINT TRIANGLE- AND ALLOW USER TO SET HEIGHT OF IT IN.
class pyramidpattern
{
    static void Main(string[] args)
    {
        int space,length=1,row;
        Console.WriteLine("Enter row number:");
        row=Convert.ToInt32(Console.ReadLine());
        space=row-1;

        for(int i=1;i<=row;i++)
        {
            for(int r=1;r<=space;r++)
            {
                Console.Write(" ");
            }
            for(int s=1;s<=length;s++)
            {
                Console.Write("*");
            }
            space--;
            length=length+2;
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}
