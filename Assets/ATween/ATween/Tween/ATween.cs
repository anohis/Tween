using System;
using Tween.State;

namespace Tween
{
    public class ATween
    {
        public Action OnStartEvent;
        public Action OnCompleteEvent;
        public Action OnPauseEvent;

        public bool IsComplete { get { return _state.IsComplete(_time); } }
        public float TimeRatio { get { return _time.Value / _time.Max; } }
        public bool IsPause;

        protected LimitValue<float> _time = new LimitValue<float>();

        private ITweenState _state;

        public ATween(float during)
        {
            _time.Max = during;
        }

        internal virtual void Reset()
        {
            _state.OnReset(_time);
        }
        internal virtual void Forward()
        {
            _state = TweenState_Forward.Instance;
        }
        internal virtual void Backward()
        {
            _state = TweenState_Backward.Instance;
        }
        internal virtual void Update(float deltaTime)
        {
            _state.OnUpdate(_time, deltaTime);
        }
    }
}