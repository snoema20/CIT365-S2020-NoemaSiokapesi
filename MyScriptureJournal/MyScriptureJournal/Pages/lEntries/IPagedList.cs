namespace My_Scripture_Journal.Pages.Entries
{
    public interface IPagedList<T>
    {
        int PageCount { get; }
    }
}