using System.Collections;
using System.Collections.Generic;
using Tween;
using UnityEngine;

namespace UnityTween
{
    public class TweenPlayer : MonoBehaviour
    {
        public enum TweenType
        {
            None,
            Move
        }

        public enum FromToType
        {
            FromTo,
            From,
            To
        }

        private ATween _tween;
        private TweenType _tweenType;
        private FromToType _fromToType;
    }
}