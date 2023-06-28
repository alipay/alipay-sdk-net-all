using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AAAAAtest Data Structure.
    /// </summary>
    [Serializable]
    public class AAAAAtest : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_openid")]
        public string AOpenid { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("b_openid")]
        public string BOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("e")]
        public string E { get; set; }
    }
}
