using System.Collections;

namespace New.Common
{
    public interface IWrappedCollection : IList
    {
        object UnderlyingCollection { get; }
    }
}
