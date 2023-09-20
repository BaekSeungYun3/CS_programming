//4. (판단문) 실수 (double)로 키(cm)와 체중(kg)을 입력받아 BMI를 계산하고 비만정도를 출력

double height, weight;

Console.Write("키를 입력하세요(cm): ");
height = double.Parse(Console.ReadLine());
Console.Write("체중를 입력하세요(kg): ");
weight = double.Parse(Console.ReadLine());

height = height / 100;
double bmi = weight / (height * height);

Console.WriteLine("BMI = {0}", bmi);

if (bmi < 20)
    Console.WriteLine("저체중");
else if (bmi < 25)
    Console.WriteLine("정상체중");
else if (bmi < 30)
    Console.WriteLine("경도비만");
else if (bmi < 40)
    Console.WriteLine("비만");
else
    Console.WriteLine("고도비만");
