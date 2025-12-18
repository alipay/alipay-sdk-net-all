using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingPayinstCouponSendResponse.
    /// </summary>
    public class AnttechMorseMarketingPayinstCouponSendResponse : AopResponse
    {
        /// <summary>
        /// 同入参的活动id
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 券码id
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 发券的投放凭证号，唯一id。
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 券发放状态
        /// </summary>
        [XmlElement("send_status")]
        public string SendStatus { get; set; }
    }
}
