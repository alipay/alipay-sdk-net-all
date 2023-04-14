using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductAsyncPayResponse.
    /// </summary>
    public class AlipayEbppPdeductAsyncPayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 商户代扣业务流水
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扣款流水状态
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
