using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExtension
{
    public static class LINQ 
    {
        public static IEnumerable<TResult> SelectExt<TSource, TResult>(this IEnumerable<TSource> source, 
                                                                       Func<TSource, TResult> selector)
        {


            return null;
        }

        public static IEnumerable<TSource> WhereExt<TSource>(this IEnumerable<TSource> source,
                                                                       Func<TSource, bool> selector)
        {


            return null;
        }



    }
}
