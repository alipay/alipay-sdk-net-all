using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceSignListApplyResponse.
    /// </summary>
    public class AlipayFincoreComplianceSignListApplyResponse : AopResponse
    {
        /// <summary>
        /// 业务请求单号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 用印记录id
        /// </summary>
        [XmlElement("file_code")]
        public string FileCode { get; set; }
    }
}
