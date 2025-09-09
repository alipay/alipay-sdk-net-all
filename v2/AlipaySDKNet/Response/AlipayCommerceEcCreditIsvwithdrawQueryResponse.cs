using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditIsvwithdrawQueryResponse.
    /// </summary>
    public class AlipayCommerceEcCreditIsvwithdrawQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行审核失败原因，情况状态为APPROVE_FAIL时必填
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 银行取款状态，枚举类型
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
