using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivitySettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivitySettleQueryModel : AopObject
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
        /// 兑换券发起结算之后返回的结算单号，用于查询对应的结算明细
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }
    }
}
