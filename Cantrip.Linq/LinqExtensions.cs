namespace Cantrip.Linq;

public static class LinqExtensions
{
    public static bool None<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return !collection.Any(predicate);
    }
}