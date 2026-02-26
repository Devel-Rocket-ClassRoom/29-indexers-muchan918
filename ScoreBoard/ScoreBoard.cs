using System;

class ScoreBoard
{
    private string[] _names;
    private int[] _scores;
    private int _count;

    public ScoreBoard(int capacity)
    {
        _names = new string[capacity];
        _scores = new int[capacity];
        _count = 0;
    }

    public int Count { get { return _count; } }

    public void Register(string name, int score)
    {
        if(_count > _names.Length)
        {
            Console.WriteLine("성적표가 가득 찼습니다");
            return;
        }

        _names[_count] = name;
        _scores[_count] = score;
        _count++;
    }

    public string this[int index]
    {
        get
        {
            if(index >= 0 && index < Count)
            {
                return _names[index];
            }
            else
            {
                return "";
            }
        }
    }

    public int this[string name]
    {
        get
        {
            for (int i = 0; i < _names.Length; i++)
            {
                if (_names[i] == name)
                {
                    return _scores[i];
                }
            }
            return -1;
        }
        set
        {
            for (int i = 0; i < _names.Length; i++)
            {
                if (_names[i] == name)
                {
                    _scores[i] = value;
                }
            }
        }
    }
}