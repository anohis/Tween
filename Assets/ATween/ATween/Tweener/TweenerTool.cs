using Tweener.Plugin;

namespace Tweener
{
    public static class TweenerTool
    {
        public static ATweener<T> Create<T>(float during, TweenerPlugin<T> plugin)
        {
            ATweener<T> t = new ATweener<T>(plugin, during);
            return t;
        }
    }
}