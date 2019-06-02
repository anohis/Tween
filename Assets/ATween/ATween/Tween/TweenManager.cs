using System.Collections.Generic;

namespace Tween
{
    public class TweenManager
    {
        internal static TweenManager Instance { get; private set; }

        private List<ATween> ActiveTweenList;
        private List<ATween> DeactiveTweenList;

        static TweenManager() { Instance = new TweenManager(); }
        private TweenManager()
        {
            ActiveTweenList = new List<ATween>();
            DeactiveTweenList = new List<ATween>();
        }

        public static void Update(float deltaTime)
        {
            Instance.UpdateActiveTweenList(deltaTime);
            Instance.UpdateDeactiveTweenList();
        }

        public void Forward(ATween t)
        {
            t.Forward();
            ActiveTweenList.Add(t);
        }
        public void Backward(ATween t)
        {
            t.Backward();
            ActiveTweenList.Add(t);
        }
        public void Reset(ATween t)
        {
            t.Reset();
        }
        public void Pause(ATween t)
        {
            t.IsPause = true;
        }

        private void UpdateActiveTweenList(float deltaTime)
        {
            for (int i = ActiveTweenList.Count - 1; i >= 0; i--)
            {
                var tween = ActiveTweenList[i];
                tween.Update(deltaTime);
                if (NeedDeactivate(tween))
                {
                    ActiveTweenList.RemoveAt(i);
                    DeactiveTweenList.Add(tween);
                }
            }
        }
        private void UpdateDeactiveTweenList()
        {
            for (int i = DeactiveTweenList.Count - 1; i >= 0; i--)
            {
                var tween = DeactiveTweenList[i];
                if (NeedActivate(tween))
                {
                    DeactiveTweenList.RemoveAt(i);
                    ActiveTweenList.Add(tween);
                }
            }
        }

        private bool NeedDeactivate(ATween t)
        {
            bool needDeactive = false;
            if (t.IsComplete)
            {
                t.OnCompleteEvent?.Invoke();
                needDeactive = true;
            }
            if (t.IsPause)
            {
                t.OnPauseEvent?.Invoke();
                needDeactive = true;
            }
            return needDeactive;
        }
        private bool NeedActivate(ATween t)
        {
            if (t.IsPause == false
                && t.IsComplete == false)
            {
                t.OnStartEvent?.Invoke();
                return true;
            }
            return false;
        }
    }
}