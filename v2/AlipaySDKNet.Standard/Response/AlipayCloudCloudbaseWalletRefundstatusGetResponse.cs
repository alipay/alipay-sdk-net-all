using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletRefundstatusGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletRefundstatusGetResponse : AopResponse
    {
        /// <summary>
        /// 提现状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
