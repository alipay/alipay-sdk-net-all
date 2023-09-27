using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodBarrierSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseAntifloodBarrierSetModel : AopObject
    {
        /// <summary>
        /// 封禁时长（秒） [60, 3*86400]
        /// </summary>
        [XmlElement("ban_duration")]
        public long BanDuration { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 请求量上限 [100, 99999999]
        /// </summary>
        [XmlElement("request_limit")]
        public long RequestLimit { get; set; }

        /// <summary>
        /// 时间窗口（秒） [60, 86400]
        /// </summary>
        [XmlElement("time_window")]
        public long TimeWindow { get; set; }
    }
}
