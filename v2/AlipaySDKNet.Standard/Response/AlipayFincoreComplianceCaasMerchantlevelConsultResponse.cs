using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceCaasMerchantlevelConsultResponse.
    /// </summary>
    public class AlipayFincoreComplianceCaasMerchantlevelConsultResponse : AopResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
