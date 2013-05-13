﻿using System;
using System.Collections.Generic;
using System.IO;
using BIT.PilotlessPlane.Models.Underlying;
using BIT.PilotlessPlane.Providers.Implement.Local.Properties;
using BIT.PilotlessPlane.Providers.Interface;
using ZhangShuai.Extensions;
using IReceivedFrame = BIT.PilotlessPlane.Models.IReceivedFrame;

namespace BIT.PilotlessPlane.Providers.Implement.Local
{
    public class LocalFrameProvider : IFrameProvider
    {
        private static readonly int FRAME_SIZE = 36;
        private readonly byte[] data;

        public LocalFrameProvider(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }
            this.data = data;
        }

        public IEnumerator<IReceivedFrame> GetFrames()
        {
            using (var ms = new MemoryStream(this.data))
            {
                var e = ms
                    .ToEnumerable(StreamToEnumerable)
                    .ToWindowed(FRAME_SIZE)
                    .GetEnumerator();
                while(e.MoveNext())
                {
                    var buffer = e.Current;
                    if(FrameValidator.Validate(buffer))
                    {
                        yield return Parse(buffer);
                        System.Threading.Thread.Sleep(50);
                    }
                }
            }
        }

        private static IEnumerable<byte> StreamToEnumerable(Stream s)
        {
            int n = s.ReadByte();
            while (n != -1)
            {
                yield return (byte)n;
                n = s.ReadByte();
            }
        }

        private static IReceivedFrame Parse(byte[] buffer)
        {
            if (FrameValidator.Validate(buffer))
            {
                switch (Convert.ToChar(buffer[3]))
                {
                    case 'A':
                        {
                            var frame = ByteStructureConverter<FrameA>.FromBytes(buffer);
                            return new Models.FrameA(frame);
                        }
                    case 'B':
                        {
                            var frame = ByteStructureConverter<FrameB>.FromBytes(buffer);
                            return new Models.FrameB(frame);
                        }
                    case 'C':
                        {
                            var frame = ByteStructureConverter<FrameC>.FromBytes(buffer);
                            return new Models.FrameC(frame);
                        }
                    default:
                        throw new InvalidDataException("Wrong Frame Character!");
                }
            }
            else
            {
                throw new InvalidDataException("Wrong DATA!");
            }
        }
    }
}
