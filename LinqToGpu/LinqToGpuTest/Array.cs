using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace LinqToGpuTest
{
    public class Array<T> : IQueryable<T>
    {

        private AcceleratorView m_associatedAccView;

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Type IQueryable.ElementType
        {
            get { return typeof(T); }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return Expression.Constant(this); }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new ComputeQueryProvider(m_associatedAccView); }
        }
    }
}
