using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;

namespace LinqToGpuTest
{
    class OpenCLTranslator : ExpressionVisitor
    {
        private static MethodInfo Queryable_Select;
        private static MethodInfo Queryable_SelectIndex;

        static OpenCLTranslator()
        {
            Type queryable = typeof(Queryable);

            Queryable_Select = queryable.GetMethod("Select", BindingFlags.Static | BindingFlags.Public);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            


            return base.VisitMethodCall(node);
        }
    }
}
