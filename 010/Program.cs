//10. (배열) 10개의 숫자를 랜덤으로 만들어 배열에 저장하고,평균 ,최소, 최대값 출력

Random r = new Random();
int[] a = new int[10];

for(int i = 0; i < 10; i++)
    a[i] = r.Next(100);

foreach(var x in a)
    Console.WriteLine(x);

int sum = 0;
int min = a[0];
int max = a[0];

foreach(var x in a)
{
    sum += x;
    if (x < min)
        min = x;
    if (x > max)
        max = x;
}
Console.WriteLine("평균 = {0}",sum / 10);
Console.WriteLine("최솟값 = {0}", min);
Console.WriteLine("최댓값 = {0}", max);
