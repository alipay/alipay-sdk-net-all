using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MaiseDataSATest Data Structure.
    /// </summary>
    [Serializable]
    public class MaiseDataSATest : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("key_a")]
        public string KeyA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("key_b")]
        public bool KeyB { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("key_c")]
        public string KeyC { get; set; }
    }
}
