using System.Collections;

namespace New.Common
{
    public interface IWrappedList : IList
    {
        object UnderlyingList { get; }
    }
}
