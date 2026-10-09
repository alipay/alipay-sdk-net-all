using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtAppUrlforuploadQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtAppUrlforuploadQueryModel : AopObject
    {
        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 来源站点
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
