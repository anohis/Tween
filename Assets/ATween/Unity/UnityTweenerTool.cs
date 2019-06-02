using Tweener;
using UnityEngine;
using UnityTween.TweenerPlugin;

namespace UnityTween
{
    public static class UnityTweenerTool
    {
        public static ATweener<Vector3> Move(this Transform transform, Vector3 from, Vector3 to, float during)
        {
            TweenerPlugin_Vector3 plugin = new TweenerPlugin_Vector3(from, to);

            plugin.Setter += (position) =>
            {
                transform.position = position;
            };

            ATweener<Vector3> t = new ATweener<Vector3>(plugin, during);
            return t;
        }
    }
}