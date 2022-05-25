using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTipsDeliveryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTipsDeliveryCreateModel : AopObject
    {
        /// <summary>
        /// 收藏引导文案内容，不得超过14个字
        /// </summary>
        [XmlElement("delivery_content")]
        public string DeliveryContent { get; set; }

        /// <summary>
        /// 收藏引导活动名称
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 匹配类型：GLOBAL为全局生效，TARGETURL为目标页面生效，需配置相应页面地址match_url。
        /// </summary>
        [XmlElement("match_type")]
        public string MatchType { get; set; }

        /// <summary>
        /// 目标页面地址
        /// </summary>
        [XmlElement("match_url")]
        public string MatchUrl { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
