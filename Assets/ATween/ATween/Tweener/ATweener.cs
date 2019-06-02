using Tween;
using Tweener.Plugin;

namespace Tweener
{
    public sealed class ATweener<T> : ATween
    {
        public float StepRatio
        {
            get { return TimeRatio; }
        }

        private TweenerPlugin<T> _plugin;

        public ATweener(TweenerPlugin<T> plugin, float during) : base(during)
        {
            _plugin = plugin;
        }

        internal override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            _plugin.Execute(StepRatio);
        }
    }
}