using System;

FruitPriceList Fruits = new FruitPriceList(5);
Fruits.Add("사과", 1500);
Fruits.Add("바나나", 3000);
Fruits.Add("딸기", 8000);

Console.WriteLine($"등록된 과일 수: {Fruits.Count}개");
Console.WriteLine();

Console.WriteLine($"사과 가격: {Fruits["사과"]}");
Console.WriteLine($"바나나 가격: {Fruits["바나나"]}");
Console.WriteLine($"포도 가격: {Fruits["포도"]}");
Console.WriteLine();

for(int i = 0; i < Fruits.Count; i++)
{
    Console.WriteLine($"{i}번: {Fruits[i]}");
}