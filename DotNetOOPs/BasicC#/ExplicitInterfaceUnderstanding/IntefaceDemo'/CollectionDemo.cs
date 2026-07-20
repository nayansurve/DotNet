namespace CollectionDemo;
using System.Collections;
using System.Collections.Generic;
public class MyCustomCollection : IEnumerable<int>
{
    private int [] data={10,20,30,40};

    public IEnumerator<int> GetEnumerator()
    {
        foreach(var item in data)
        yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}