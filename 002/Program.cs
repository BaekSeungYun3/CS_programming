//2. (산술연산자) 정수 2개를 입력받아 덧셈, 뺄셈, 곱셈, 나눗셈, 나머지 값을 출력

int x, y;

Console.Write("첫번째 숫자를 입력하세요: ");
x = int.Parse(Console.ReadLine());
Console.Write("두번째 숫자를 입력하세요: ");
y = int.Parse(Console.ReadLine());

Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
Console.WriteLine("{0} % {1} = {2}", 3.14, 2.56, 3.14 % 2.56);



