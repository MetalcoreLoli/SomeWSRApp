namespace SomeWSRApp.Domain.Layer.Queries
{
    public interface IQuery<out TResult>
    {
        TResult Execute();
    }
}