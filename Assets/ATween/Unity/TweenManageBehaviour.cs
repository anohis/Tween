using Tween;
using UnityEngine;

namespace UnityTween
{
    public sealed class TweenManageBehaviour : MonoBehaviour
    {
        public TweenManageBehaviour Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<TweenManageBehaviour>();
                }
                return _instance;
            }
        }
        private static TweenManageBehaviour _instance = null;

        private void Awake()
        {
            if (_instance == null || _instance == this)
            {
                _instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(this);
            }
        }

        private void Update()
        {
            TweenManager.Update(Time.deltaTime);
        }
    }
}