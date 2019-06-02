using System.Collections;
using System.Collections.Generic;
using Tweener.Plugin;
using UnityEngine;

namespace UnityTween.TweenerPlugin
{
    public class TweenerPlugin_Vector3 : TweenerPlugin<Vector3>
    {
        public TweenerPlugin_Vector3(Vector3 from, Vector3 to) : base(from, to) { }

        public override void Execute(float stepRatio)
        {
            var current = (_to - _from) * stepRatio + _from;
            Set(current);
        }
    }
}