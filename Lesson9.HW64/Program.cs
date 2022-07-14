// Задача 64
Console.WriteLine("Задача 64");
void printRec(int N){
    Console.Write(N+" ");
    if(N-1>=1) printRec(N-1);
}
Console.WriteLine();
int N = 5;
printRec(N);