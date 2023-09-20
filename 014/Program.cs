// 14.  (재귀함수) 정수를 입력받아 재귀함수를 사용하여 팩토리얼 계산

static int Facto(int n)
{
    if (n == 1)
        return 1;
    else
        return Facto(n - 1) * n;
}

Console.Write("n을 입력하세요: ");
int n = int .Parse(Console.ReadLine());

int fact = 1;
for (int i = 1; i <= n; i++)
    fact *= 1;

Console.WriteLine("{0}! = {1}", n, fact);

Console.WriteLine("{0}! = {1}",n,Facto(n));

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0,2}! = {1,8}",i,Facto(i));
}