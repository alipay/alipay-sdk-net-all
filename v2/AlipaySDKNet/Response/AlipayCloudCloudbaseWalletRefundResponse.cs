using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletRefundResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletRefundResponse : AopResponse
    {
        /// <summary>
        /// 提现单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }
    }
}
