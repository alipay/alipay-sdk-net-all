using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceSignStatusQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceSignStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 用印状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
