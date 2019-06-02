namespace Tween.State
{
    internal abstract class TweenState : ITweenState
    {
        public abstract bool IsComplete(LimitValue<float> time);
        public abstract void OnReset(LimitValue<float> time);
        public abstract void OnUpdate(LimitValue<float> time, float deltaTime);
    }
}