Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (99<a & a<1000){
    int fist = a/10;
    int sec = fist%10;
    Console.WriteLine(sec);
}
else
Console.WriteLine("Ведите именно трехзначное число");
