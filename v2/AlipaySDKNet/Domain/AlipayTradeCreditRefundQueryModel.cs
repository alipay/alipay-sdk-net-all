using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditRefundQueryModel : AopObject
    {
        /// <summary>
        /// 信用支付单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 退款请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
