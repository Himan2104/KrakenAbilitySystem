using System;
using UnityEngine.Events;

namespace Kraken.AbilitySystem
{
    public class Attribute
    {
        private float _currentValue = 0.0f;
        private float _baseValue = 0.0f;
        private UnityEvent<float, float> _onBaseValueChanged = new UnityEvent<float, float>();
        private UnityEvent<float, float> _onCurrentValueChanged = new UnityEvent<float, float>();

        public float fCurrentValue
        {
            get { return _currentValue; }
            set
            {
                var _oldValue = _currentValue;
                _currentValue = value;
                _onCurrentValueChanged.Invoke(_oldValue, _currentValue);
            }
        }

        public float fBaseValue
        {
            get { return _baseValue; }
            set
            {
                var _oldValue = _baseValue;
                _baseValue = value;
                _onBaseValueChanged.Invoke(_oldValue, _baseValue);
            }
        }

        public UnityEvent<float, float> onBaseValueChanged { get { return _onBaseValueChanged; } }
        public UnityEvent<float, float> onCurrentValueChanged { get { return _onCurrentValueChanged; } }
    }


    public class AttributeSet
    {
        private AbilitySystemComponent _owner;
        public AbilitySystemComponent GetOwningAbilitySystemComponent()
        {
            return _owner;
        }
    }
}