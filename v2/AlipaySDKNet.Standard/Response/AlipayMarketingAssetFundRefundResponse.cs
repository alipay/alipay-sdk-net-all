using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingAssetFundRefundResponse.
    /// </summary>
    public class AlipayMarketingAssetFundRefundResponse : AopResponse
    {
        /// <summary>
        /// 当笔资产资金操作的流水id
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }
    }
}
