using System.Collections.Generic;
using BIT.PilotlessPlane.Models;

namespace BIT.PilotlessPlane.Providers.Interface
{
    public interface IFrameProvider
    {
        IEnumerator<IReceivedFrame> GetFrames();
    }
}
