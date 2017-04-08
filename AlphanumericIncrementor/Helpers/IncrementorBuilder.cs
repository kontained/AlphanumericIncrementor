using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphanumericIncrementor.Core;

namespace AlphanumericIncrementor.Helpers
{
    /// <summary>
    /// Use this class to easily help you build an alphanumeric incrementor
    /// Example: var incrementor = IncrementorBuilder.Build();
    /// </summary>
    public static class IncrementorBuilder
    {
        public static IIncrementor Build()
        {
            return new Incrementor(new Determinator(), new Formatter(), new RuleFactory());
        }
    }
}
