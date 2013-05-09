using System.Collections.Generic;

namespace BIT.PilotlessPlane.Providers.Interface
{
    public interface IFrameProvider
    {
        IEnumerator<object> GetFrames();
    }
}
