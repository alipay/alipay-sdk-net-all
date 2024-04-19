using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransEntrustTransferResponse.
    /// </summary>
    public class AlipayFundTransEntrustTransferResponse : AopResponse
    {
        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转账单据状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
