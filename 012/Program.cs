//12.  (함수) 두 개의 숫자 중 더 큰 숫자를 반환하는 Larger()함수를 이용하여
//세 개의 숫자 중 가장 큰 수 반환하는 프로그램

static int Larger(int x, int y)
{
//    if(x > y)
//        return x;
//    else
//        return y;

    return (x > y) ? x : y;
}

int x, y, z;
Console.Write("첫번째 값을 입력하세요: ");
x = int.Parse(Console.ReadLine());
Console.Write("두번째 값을 입력하세요: ");
y = int.Parse(Console.ReadLine());
Console.Write("세번째 값을 입력하세요: ");
z = int.Parse(Console.ReadLine());

Console.WriteLine("최대값은 {0}", Larger(Larger(x, y), z));