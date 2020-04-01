using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09._GC
{
    class Elements : IEnumerable, IDisposable
    {
        List<int> elements = new List<int>();

        public Elements(List<int> elements)
        {
            this.elements = elements;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Sorting()
        {
            this.elements.Sort();
        }
        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}