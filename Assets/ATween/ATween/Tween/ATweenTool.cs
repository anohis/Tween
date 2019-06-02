using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tween
{
    public static class ATweenTool
    {
        public static void Forward(this ATween t)
        {
            TweenManager.Instance.Forward(t);
        }
        public static void Backward(this ATween t)
        {
            TweenManager.Instance.Backward(t);
        }
        public static void Pause(this ATween t)
        {
            TweenManager.Instance.Pause(t);
        }
    }
}