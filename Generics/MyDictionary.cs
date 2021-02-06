using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyDictionary<T, A>
    {
        T[] _keyArray;
        A[] _valueArray;

        T[] _tempKeyArray;
        A[] _tempValueArray;

        public MyDictionary()
        {
            _keyArray = new T[0];
            _valueArray = new A[0];
        }

        public void Add(T key, A value)
        {
            _tempKeyArray = _keyArray;
            _tempValueArray = _valueArray;

            _keyArray = new T[_keyArray.Length + 1];
            _valueArray = new A[_valueArray.Length + 1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
                _valueArray[i] = _tempValueArray[i];
            }

            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_valueArray.Length - 1] = value;
        }

        public int Count
        {
            get { return _keyArray.Length; }
        }

    }
}
