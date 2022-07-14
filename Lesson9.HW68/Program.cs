// Задача 68
Console.WriteLine();
Console.WriteLine("Задача 68");

int akn(int m,int n){
    if(m==0)
        return n+1;
    if((m>0)&&(n==0))
        return akn(m-1,1);
    if((m>0)&&(n>0))
        return akn(m-1,akn(m,n-1));
    return 0;
}

int m = 3;
int n = 2;
Console.WriteLine("A("+m+","+n+") = " + akn(m,n));
