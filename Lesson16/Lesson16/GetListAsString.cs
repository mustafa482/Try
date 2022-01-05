using System.Collections.Generic;

namespace Lesson16
{
    internal class GetListAsString : List<int>
    {
        public GetListAsString(IEnumerable<int> collection) : base(collection)
        {
        }
    }
}