using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public class QuadrilateralEnum : IEnumerator
    {
        public Quadrilateral[] _quadrilateral;

        int position = -1;

        public QuadrilateralEnum(Quadrilateral[] list)
        {
            _quadrilateral = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _quadrilateral.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Quadrilateral Current
        {
            get
            {
                try
                {
                    return _quadrilateral[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
