namespace Tween.State
{
    internal class TweenState_Backward : TweenState
    {
        public static TweenState_Backward Instance { get; private set; }
        static TweenState_Backward() { Instance = new TweenState_Backward(); }
        private TweenState_Backward() { }

        public override bool IsComplete(LimitValue<float> time)
        {
            return time.Value <= time.Min;
        }
        public override void OnReset(LimitValue<float> time)
        {
            time.Value = time.Max;
        }
        public override void OnUpdate(LimitValue<float> time, float deltaTime)
        {
            time.Value -= deltaTime;
        }
    }
}