using System;

class FruitPriceList
{
    private string[] _names;
    private int[] _price;
    private int _count;

    public FruitPriceList(int capacity)
    {
        _names = new string[capacity];
        _price = new int[capacity];
        _count = 0; 
    }

    public int Count
    {
        get { return _count; }
    }

    public void Add(string name, int price)
    {
        if(Count > _names.Length)
        {
            Console.WriteLine("가격표가 가득 찼습니다");
            return;
        }
        _names[Count] = name;
        _price[Count] = price;
        _count++;
    }

    public int this[string key]
    {
        get
        {
            for (int i = 0; i < _names.Length; i++)
            {
                if (_names[i] == key)
                    return _price[i];
            }
            return -1;
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < Count)
                return _names[index];
            else
                return "";
        }
    }
}