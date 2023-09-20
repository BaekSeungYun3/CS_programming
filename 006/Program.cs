//6. (반복문) 두 정수 x,y를 입력받아 x의 y승을 계산

Console.Write("x를 입력하세요: ");
int x = int.Parse(Console.ReadLine());
Console.Write("y를 입력하세요: ");
int y = int.Parse(Console.ReadLine());

int power = 1;
for (int i = 0; i < y; i++)
    power *= x;

Console.WriteLine("{0} ^ {1} = {2}",x,y,power);