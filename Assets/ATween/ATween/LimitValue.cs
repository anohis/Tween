using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitValue<T> where T : struct, IComparable
{
    public event Action<LimitValue<T>> OnChangeValueEvent;

    public T Min
    {
        get { return _min; }
        set
        {
            _min = value;
            if (_min.CompareTo(_max) > 0)
            {
                _min = _max;
            }
            CheckValue();
        }
    }
    public T Max
    {
        get { return _max; }
        set
        {
            _max = value;
            if (_max.CompareTo(_min) < 0)
            {
                _min = _max;
            }
            CheckValue();
        }
    }
    public T Value
    {
        get { return _value; }
        set
        {
            _value = value;
            CheckValue();
            OnChangeValueEvent?.Invoke(this);
        }
    }

    private T _min;
    private T _max;
    private T _value;

    private void CheckValue()
    {
        if (_value.CompareTo(_max) > 0)
        {
            Value = _max;
        }
        else if (_value.CompareTo(_min) < 0)
        {
            Value = _min;
        }
    }
}
