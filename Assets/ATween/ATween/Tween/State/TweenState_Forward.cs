namespace Tween.State
{
    internal class TweenState_Forward : TweenState
    {
        public static TweenState_Forward Instance { get; private set; }
        static TweenState_Forward() { Instance = new TweenState_Forward(); }
        private TweenState_Forward() { }

        public override bool IsComplete(LimitValue<float> time)
        {
            return time.Value >= time.Max;
        }
        public override void OnReset(LimitValue<float> time)
        {
            time.Value = time.Min;
        }
        public override void OnUpdate(LimitValue<float> time, float deltaTime)
        {
            time.Value += deltaTime;
        }
    }
}