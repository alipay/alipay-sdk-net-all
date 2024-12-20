using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandDirectAgentQueryResponse.
    /// </summary>
    public class AntMerchantExpandDirectAgentQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户支付宝账号对应的商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 支付宝风控审核不通过原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 商户进件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
