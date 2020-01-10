using System.Collections;

namespace New.Common
{
    public interface IWrappedDictionary : IDictionary
    {
        object UnderlyingDictionary { get; }
    }
}
