using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherSettleModel : AopObject
    {
        /// <summary>
        /// 优惠券活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 购买商家兑换券的营销订单号。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 注：针对同一次结算请求，如果调用接口失败或异常了，重试时需要保证结算请求号不能变更，防止该笔交易重复结算。支付宝会保证同样的结算请求号多次请求只会一次。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
