// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator {
    
    private IEnumerator<int> _iterator;
    
    private int location = -1;
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator) {
        // initialize any member here.
        _iterator = iterator;
        _iterator.Reset();
    }
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() {
        _iterator.MoveNext();
        int temp = _iterator.Current;
        int i = -1;
        _iterator.Reset();
        while(i < location)
        {
            i++;
            _iterator.MoveNext();
        }
        return temp;
    }
    
    // Returns the next element in the iteration and advances the iterator.
    public int Next() {
        _iterator.MoveNext();
        location ++;
        return _iterator.Current;
    }
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() {
        return this.Peek() != 0;
    }
}