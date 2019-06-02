using System;

namespace Tweener.Plugin
{
    public abstract class TweenerPlugin<T>
    {
        protected T _from;
        protected T _to;

        public event Action<T> Setter;

        public TweenerPlugin(T from, T to)
        {
            _from = from;
            _to = to;
        }

        public abstract void Execute(float stepRatio);

        protected void Set(T value)
        {
            Setter?.Invoke(value);
        }
    }
}
