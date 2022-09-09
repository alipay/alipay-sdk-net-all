using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampaignPrize Data Structure.
    /// </summary>
    [Serializable]
    public class CampaignPrize : AopObject
    {
        /// <summary>
        /// 优惠渠道描述优惠来源信息
        /// </summary>
        [XmlElement("campaign_channel")]
        public string CampaignChannel { get; set; }

        /// <summary>
        /// 活动渠道码信息，用于标识活动渠道，主要是简称
        /// </summary>
        [XmlElement("campaign_channel_code")]
        public string CampaignChannelCode { get; set; }

        /// <summary>
        /// 活动id描述本次查询命中的活动标识
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 创意文案信息标识命中活动露出的创意文案信息，可以通过管理平台配置并露出给调用方，自定义信息，一般是json格式，配置自定义创意时必选
        /// </summary>
        [XmlElement("idea_content")]
        public string IdeaContent { get; set; }

        /// <summary>
        /// 创意类型标识外部展示采用的方式，摩斯平台配置，配置自定义创意时必选
        /// </summary>
        [XmlElement("idea_type")]
        public string IdeaType { get; set; }

        /// <summary>
        /// 命中后返回的跳转链接，配置跳转链接时必选
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 最大优惠金额用于标识咨询活动可以享受的最大优惠金额，配置权益时必选
        /// </summary>
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 最小优惠金额用于标识咨询活动可以享受的最小优惠金额，配置权益时必选
        /// </summary>
        [XmlElement("min_amount")]
        public string MinAmount { get; set; }

        /// <summary>
        /// 优惠门槛金额类型，标识订单金额需要满此金额才能享受优惠，配置权益时必选
        /// </summary>
        [XmlElement("threshold")]
        public string Threshold { get; set; }
    }
}
