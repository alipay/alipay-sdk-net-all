using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampaignDrawcampTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampaignDrawcampTriggerModel : AopObject
    {
        /// <summary>
        /// 营销的渠道，需开发前协商确认
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 用户红包码，可拼接营销前后缀，如：【碰一下红包4II1ZMNO】
        /// </summary>
        [XmlElement("claim_code")]
        public string ClaimCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务id，幂等控制，用于判断是否重复调用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
