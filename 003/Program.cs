//3. (관계연산자) 정수 2개를 입력받아 6개 관계연산자로 계산한 결과 출력

int x, y;

Console.Write("x를 입력하세요: ");
x = int.Parse(Console.ReadLine());
Console.Write("y를 입력하세요: ");
y = int.Parse(Console.ReadLine());

Console.WriteLine("{0} > {1} = {2} ", x, y, x > y);
Console.WriteLine("{0} >= {1} = {2} ", x, y, x >= y);
Console.WriteLine("{0} < {1} = {2} ", x, y, x < y);
Console.WriteLine("{0} <= {1} = {2} ", x, y, x <= y);
Console.WriteLine("{0} == {1} = {2} ", x, y, x == y);
Console.WriteLine("{0} != {1} = {2} ", x, y, x != y);
