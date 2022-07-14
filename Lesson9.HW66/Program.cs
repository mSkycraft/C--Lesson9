// Задача 66
Console.WriteLine();
Console.WriteLine("Задача 64");
int sumRange(int N,int M){

    if(N==M)  
    {   
        return M;
    }
    else
        return N+sumRange(N+1,M);
}

int x = 1;
int y = 15;

Console.WriteLine(sumRange(x,y));
