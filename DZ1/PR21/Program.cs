// следующая задача №21

Console.WriteLine("Задача №21");
Console.WriteLine("----------------------------------------");

double xa, xb, ya, yb, za, zb, ab;

double rasst(double xa, double ya, double za, double xb, double yb, double zb)
{
    if (xa==xb && ya==yb && za==zb)
    {
        Console.Write("Это одна и та же точка!");
        return 0;
    }
    else 
    {
        double ab = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));
        return ab;
    }
}

Console.Write("Введите точку Xa = ");
xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку Ya = ");
ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку Za = ");
za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку Xb = ");
xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку Yb = ");
yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку Zb = ");
zb = Convert.ToInt32(Console.ReadLine());

ab = rasst(xa,ya,za,xb,yb,zb);

if (ab!=0)
{
    Console.WriteLine("Расстояние между двумя точками (" + xa + ", " + ya + ", " + za +") и ("  + xb + ", " + yb  + ", " + zb +") = " + ab);
}