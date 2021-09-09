using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrderRefundModel : AopObject
    {
        /// <summary>
        /// 购买者的支付宝uid.  用于水平权限校验。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 购买商家兑换券的营销订单号。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。   注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。  该外部业务单号会在后续alipay.marketing.activity.message.refund 退款消息中带上。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退款活动信息列表
        /// </summary>
        [XmlArray("refund_activity_info_list")]
        [XmlArrayItem("refund_activity_info")]
        public List<RefundActivityInfo> RefundActivityInfoList { get; set; }

        /// <summary>
        /// 退款类型： USER_REFUND：用户主动发起退款  AUTO_EXPIRE：过期自动退款
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }
    }
}
