using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceRedinvoiceApplyResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoiceRedinvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desp")]
        public string ResultDesp { get; set; }
    }
}
