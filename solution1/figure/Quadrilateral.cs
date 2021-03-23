using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public class Quadrilateral
    {
        public Quadrilateral(string Name, bool Equilateral, int GreyColor)
        {
            this.Name = Name;
            this.Equilateral = Equilateral;
            this.GreyColor = GreyColor;
        }
        public string Name;
        public bool Equilateral;
        public int GreyColor;
    }
    public class Quadrilaterals : IEnumerable
    {
        private Quadrilateral[] _quadrilaterals;
        public Quadrilaterals(Quadrilateral[] qArray)
        {
            _quadrilaterals = new Quadrilateral[qArray.Length];

            for (int i = 0; i < qArray.Length; i++)
            {
                _quadrilaterals[i] = qArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public QuadrilateralEnum GetEnumerator()
        {
            return new QuadrilateralEnum(_quadrilaterals);
        }
    }
}
