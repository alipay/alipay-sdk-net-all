using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyoutestopenidOne Data Structure.
    /// </summary>
    [Serializable]
    public class JinyoutestopenidOne : AopObject
    {
        /// <summary>
        /// 我晚点
        /// </summary>
        [XmlElement("c_1")]
        public string C1 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("q")]
        public string Q { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("q_1_open_id")]
        public string Q1OpenId { get; set; }
    }
}
