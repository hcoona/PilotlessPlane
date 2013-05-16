using System;
using System.IO;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using BIT.PilotlessPlane.Providers.Implement.Local.Properties;
using BIT.PilotlessPlane.Providers.Interface;

namespace BIT.PilotlessPlane.Providers.Implement.Local
{
    public class LocalFrameProvider : IFrameProvider
    {
        private readonly int delay;
        private readonly byte[] data;
        private readonly IObservable<byte> observable;

        public LocalFrameProvider(string resourceName = "_20130510_txt", int delay = 34)
        {
            this.delay = delay;
            this.data = (byte[])Resources.ResourceManager.GetObject(resourceName);
            this.observable = Observable.Using<byte, Stream>(
                () => new MemoryStream(this.data),
                s => Observable.Create<byte>(observer => Task.Factory.StartNew(() =>
                {
                    try
                    {
                        int b;
                        while ((b = s.ReadByte()) != -1)
                        {
                            observer.OnNext((byte)b);
                            Thread.Sleep(delay);
                        }
                        observer.OnCompleted();
                    }
                    catch (Exception ex)
                    {
                        observer.OnError(ex);
                    }
                })));
        }

        public IObservable<byte> GetBytes()
        {
            return this.observable;
        }
    }
}
