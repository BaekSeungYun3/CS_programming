// 1. (입출력) 자신의 학번과 이름을 입력으로 받아 화면에 출력

int num;
string name;

Console.Write("학번을 입력하세요: ");
num = int.Parse(Console.ReadLine());

Console.Write("이름을 입력하세요: ");
name =Console.ReadLine();

Console.Write("학번: ");
Console.WriteLine(num);
Console.Write("이름: ");
Console.WriteLine(name);
