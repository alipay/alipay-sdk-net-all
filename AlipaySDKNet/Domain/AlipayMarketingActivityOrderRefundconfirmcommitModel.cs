using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrderRefundconfirmcommitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrderRefundconfirmcommitModel : AopObject
    {
        /// <summary>
        /// 买家的支付宝uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家的支付宝openId
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 购买商家兑换券的营销订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款前向商户确认退款结果活动列表明细
        /// </summary>
        [XmlArray("refund_confirm_commit_activity_info_list")]
        [XmlArrayItem("refund_confirm_commit_activity_info")]
        public List<RefundConfirmCommitActivityInfo> RefundConfirmCommitActivityInfoList { get; set; }

        /// <summary>
        /// 订单退款类型
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }
    }
}
