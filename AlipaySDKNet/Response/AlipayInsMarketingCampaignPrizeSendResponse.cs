using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignPrizeSendResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignPrizeSendResponse : AopResponse
    {
        /// <summary>
        /// 资产Id，如单品券权益类型，则对应的资产Id即为券Id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 活动Id
        /// </summary>
        [XmlElement("compaign_id")]
        public string CompaignId { get; set; }

        /// <summary>
        /// 用户权益Id
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型：  single_voucher：单品券  full_jfb：集分宝
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值，如优惠券则表示金额
        /// </summary>
        [XmlElement("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 发奖流水Id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
