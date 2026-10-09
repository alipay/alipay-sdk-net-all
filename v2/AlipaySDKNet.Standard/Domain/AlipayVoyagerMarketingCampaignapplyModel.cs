using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerMarketingCampaignapplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerMarketingCampaignapplyModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型（可选）：VOYAGER_ACTIVITY / DOLPHIN_CAMP
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 环境信息
        /// </summary>
        [XmlElement("env_info")]
        public VoyagerEnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 扩展信息（Map 的 JSON string）
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 幂等键兜底
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 投放流量位ID
        /// </summary>
        [XmlElement("polymer_block_code")]
        public string PolymerBlockCode { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 幂等键
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 用户userid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
