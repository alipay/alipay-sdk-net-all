using System.IO;

namespace AlipaySDKNet.OpenAPI.Util.Model
{
    public class CustomStream : Stream
    {
        private MemoryStream memoryStream;
        public string Name { get; set; }

        public CustomStream(string name, byte[] buffer)
        {
            Name = name;
            memoryStream = new MemoryStream(buffer);
        }

        public override void Flush()
        {
            memoryStream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return memoryStream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return memoryStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            memoryStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            memoryStream.Write(buffer, offset, count);
        }

        public override bool CanRead => memoryStream.CanRead;
        public override bool CanSeek => memoryStream.CanSeek;
        public override bool CanWrite => memoryStream.CanWrite;
        public override long Length => memoryStream.Length;

        public override long Position
        {
            get => memoryStream.Position;
            set => memoryStream.Position = value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                memoryStream?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}