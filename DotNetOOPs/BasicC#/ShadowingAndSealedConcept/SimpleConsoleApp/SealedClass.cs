namespace SealedDemo;

sealed class SealDemo
{
    int a=1000;
    int b=1000;
      int Add()
    {
        return a+b;
    }
}

// public class Sub:SealDemo
// {
//     int c=1000;
//     int d=2000;

//     public override int Add()
//     {
//         return c+d;
//     }
// }  so here we can inherit another class because here we declare the class as the sealed class