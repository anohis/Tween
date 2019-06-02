namespace Tweener.Plugin
{
    public class TweenerPlugin_Float : TweenerPlugin<float>
    {
        public TweenerPlugin_Float(float from, float to) : base(from, to) { }

        public override void Execute(float stepRatio)
        {
            var current = (_to - _from) * stepRatio + _from;
            Set(current);
        }
    }
}
