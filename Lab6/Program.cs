internal class Program
{
    private static void Main(string[] args)
    {
        int chuc = 0;
        int donvi = 0;
        Console.WriteLine("Nhap mot so:");
        int so = int.Parse(Console.ReadLine());
        if(0<=so&&so<999)
        {
            if(0<=so&&so<10)
            {
                if (so==0) Console.WriteLine("khong");
                else if (so==1) Console.WriteLine("mot");
                else if (so==2) Console.WriteLine("hai");
                else if (so==3) Console.WriteLine("ba");
                else if (so==4) Console.WriteLine("bon");
                else if (so==5) Console.WriteLine("nam");
                else if (so==6) Console.WriteLine("sau");
                else if (so==7) Console.WriteLine("bay");
                else if (so==8) Console.WriteLine("tam");
                else Console.WriteLine("chin");
            }
            else if(10<=so&&so<99)
            {
                chuc = so/10;
                donvi = so%10;
                if (so==1) Console.WriteLine("mot");
                else if (chuc==2) Console.Write("hai");
                else if (chuc==3) Console.Write("ba");
                else if (chuc==4) Console.Write("bon");
                else if (chuc==5) Console.Write("nam");
                else if (chuc==6) Console.Write("sau");
                else if (chuc==7) Console.Write("bay");
                else if (chuc==8) Console.Write("tam");
                else Console.WriteLine("chin");
                if (donvi==1) Console.WriteLine("mot");
                else if (donvi==2) Console.Write("hai");
                else if (donvi==3) Console.Write("ba");
                else if (donvi==4) Console.Write("bon");
                else if (donvi==5) Console.Write("nam");
                else if (donvi==6) Console.Write("sau");
                else if (donvi==7) Console.Write("bay");
                else if (donvi==8) Console.Write("tam");
                else Console.WriteLine("chin");
            }
            else
            {

            }
        }
        else
        {
            Console.WriteLine("Nhap sai gia tri chay lai chuong trinh");
        }
    }
}