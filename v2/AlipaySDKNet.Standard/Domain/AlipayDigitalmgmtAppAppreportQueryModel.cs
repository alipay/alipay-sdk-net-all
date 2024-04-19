using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtAppAppreportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtAppAppreportQueryModel : AopObject
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
        /// 检测结果对外唯一标识id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
