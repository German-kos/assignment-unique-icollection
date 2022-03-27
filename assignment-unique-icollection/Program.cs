using System.Collections;

UniqueList<int> myList = new UniqueList<int>();
myList.Add(0);
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
myList.Add(5);
myList.Add(5);
foreach(int i in myList)
    Console.Write(i);
myList.Remove(3);
Console.WriteLine();
foreach (int i in myList)
    Console.Write(i);
myList.Clear();
Console.WriteLine();
foreach (int i in myList)
    Console.Write(i);
class UniqueList<T> : ICollection<T>
{
    private List<T> _list = new List<T>();
    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T input)
    {
        bool valueExists = false;
        foreach (T item in _list)
            if (item.Equals(input)) valueExists = true;
        if (valueExists) Console.WriteLine("The value already exists, please enter another value.");
        else
        {
            Console.WriteLine($"{input} has been added to the list.");
            _list.Add(input);
        }
    }

    public void Clear()
    {
        _list.Clear();
    }

    public bool Contains(T item)
    {
        return _list.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        _list.CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in _list)
        {
            yield return item;
        }
    }

    public bool Remove(T item)
    {
        return _list.Remove(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}