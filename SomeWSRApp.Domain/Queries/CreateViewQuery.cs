using System;

namespace SomeWSRApp.Domain.Layer.Queries
{
    public class CreateViewQuery<TView> : IQuery<TView> where TView: new ()
    {

        private readonly Action<TView> _onCreating;

        public CreateViewQuery(Action<TView> onCreating = null!)
        {
            _onCreating = onCreating;
        }

        public virtual TView Execute()
        {
            var view = new TView();
            _onCreating?.Invoke(view);
            return view;
        }
    }
}