namespace SomeWSRApp.Domain.Layer.Queries
{
    public class CreateViewQuery<TView> : IQuery<TView> where TView: new ()
    {
        public TView Execute()
        {
            return new TView();
        }
    }
}