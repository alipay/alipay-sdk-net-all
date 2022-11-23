using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDumQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDumQueryModel : AopObject
    {
        /// <summary>
        /// 122
        /// </summary>
        [XmlElement("cc_open_id")]
        public string CcOpenId { get; set; }

        /// <summary>
        /// 122
        /// </summary>
        [XmlElement("ccc")]
        public long Ccc { get; set; }

        /// <summary>
        /// ccdd
        /// </summary>
        [XmlElement("f")]
        public JinyoutestopenidThree F { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
