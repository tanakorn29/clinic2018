using System;
using System.Runtime.Serialization;

namespace textBox1
{
    [Serializable]
    internal class Text : Exception
    {
        public Text()
        {
        }

        public Text(string message) : base(message)
        {
        }

        public Text(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Text(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}