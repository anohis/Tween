namespace Tween.State
{
    internal interface ITweenState
    {
        bool IsComplete(LimitValue<float> time);
        void OnReset(LimitValue<float> time);
        void OnUpdate(LimitValue<float> time, float deltaTime);
    }
}