using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataShuanqQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataShuanqQueryModel : AopObject
    {
        /// <summary>
        /// rfdss
        /// </summary>
        [XmlElement("cert_no")]
        public long CertNo { get; set; }

        /// <summary>
        /// 的改动染发膏
        /// </summary>
        [XmlElement("name")]
        public bool Name { get; set; }

        /// <summary>
        /// 萨芬圣德芬
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
