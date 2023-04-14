using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingDiscountDecisionResponse.
    /// </summary>
    public class AlipayInsMarketingDiscountDecisionResponse : AopResponse
    {
        /// <summary>
        /// 该订单可以享受的事后权益
        /// </summary>
        [XmlArray("mkt_coupon_campaigns")]
        [XmlArrayItem("ins_mkt_coupon_campaign_d_t_o")]
        public List<InsMktCouponCampaignDTO> MktCouponCampaigns { get; set; }

        /// <summary>
        /// 本次优惠咨询可以使用的权益权益列表
        /// </summary>
        [XmlArray("mkt_coupons")]
        [XmlArrayItem("ins_mkt_coupon_d_t_o")]
        public List<InsMktCouponDTO> MktCoupons { get; set; }
    }
}
