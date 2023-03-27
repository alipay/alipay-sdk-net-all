using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KongsuTest Data Structure.
    /// </summary>
    [Serializable]
    public class KongsuTest : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("json")]
        public string Json { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s_open_id")]
        public string SOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }
    }
}
