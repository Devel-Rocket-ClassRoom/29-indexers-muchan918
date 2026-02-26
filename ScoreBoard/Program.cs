using System;

ScoreBoard scoreBoard = new ScoreBoard(5);

scoreBoard.Register("김민수", 85);
scoreBoard.Register("이지영", 92);
scoreBoard.Register("박서준", 78);

Console.WriteLine($"등록된 학생 수: {scoreBoard.Count}명");
Console.WriteLine();

for (int i = 0; i < scoreBoard.Count; i++)
{
    Console.WriteLine($"{i}번: {scoreBoard[i]}");
}
Console.WriteLine();

Console.WriteLine($"김민수 점수: {scoreBoard["김민수"]}");
Console.WriteLine($"이지영 점수: {scoreBoard["이지영"]}");
Console.WriteLine($"홍길동 점수: {scoreBoard["홍길동"]}");
Console.WriteLine();

scoreBoard["김민수"] = 95;
Console.WriteLine($"김민수 수정된 점수: {scoreBoard["김민수"]}");