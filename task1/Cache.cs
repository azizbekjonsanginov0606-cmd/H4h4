namespace task1;

    public static class Cache<T>
{
    private static List<T> _storage = new List<T>();

    public static void Add(T value)
    {
        _storage.Add(value);
    }

    public static T GetIndex(int index)
    {
        return _storage[index];
    }
    public static T? GetValue(T value)
    {
            return _storage.Find(x => EqualityComparer<T>.Default.Equals(x, value));
    }
    

    public static void RemoveValue(T value)
    {
        _storage.Remove(value);
    }
    public static void Removeindex(int index)
    {
        _storage.RemoveAt(index);
    }
}
