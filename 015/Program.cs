// 15.  (재귀함수) 4개의 원반이 놓여있는 하노이탑 문제에서 원반을 이동하는 순서 출력 

static void HanoiTower(int n, char from, char via, char to)
{
    if (n == 1)
        Console.WriteLine("{0}->{1}", from, to);
    else
    {
        HanoiTower(n-1,from,to,via);
        Console.WriteLine("{0}->{1}",from,to);
        HanoiTower(n-1,via,from,to);
    }
}

HanoiTower(4, 'A', 'B', 'C');
