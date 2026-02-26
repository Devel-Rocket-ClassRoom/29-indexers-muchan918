using System;
using System.Collections;

Catalog catalog = new Catalog();
Console.WriteLine(catalog[0]); // 개체명[인덱스] 형태로 호출
Console.WriteLine(catalog[1]);
Console.WriteLine(catalog[2]);

Car car = new Car(3);

// 인덱서를 통해 배열처럼 값 저장
car[0] = "CLA";
car[1] = "CLS";
car[2] = "AMG";

// for 문으로 순회하며 출력
for (int i = 0; i < car.Length; i++)
{
    Console.WriteLine(car[i]);
}

Week week = new Week(3);

week[0] = "일요일";
week[1] = "월요일";
week[2] = "화요일";

for (int i = 0; i < week.Length; i++)
{
    Console.WriteLine(week[i]);
}

var nick = new NickName();

nick["홍길동"] = "RedPlus";
nick["김철수"] = "BlueStar";

Console.WriteLine($"{nick["홍길동"]}, {nick["김철수"]}");

MultiIndexer multi = new MultiIndexer();

// 정수 인덱서 사용
multi[0] = "첫 번째 값";

// 문자열 인덱서 사용
multi["name"] = "홍길동";
multi["city"] = "서울";

Console.WriteLine($"multi[0] = {multi[0]}");
Console.WriteLine($"multi[\"name\"] = {multi["name"]}");
Console.WriteLine($"multi[\"city\"] = {multi["city"]}");

Example ex = new Example();

// 속성 사용
ex.Name = "홍길동";
Console.WriteLine(ex.Name);

// 인덱서 사용
ex[0] = "첫 번째";
ex[1] = "두 번째";
Console.WriteLine($"{ex[0]}, {ex[1]}");