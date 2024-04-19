using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodBarrierGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseAntifloodBarrierGetResponse : AopResponse
    {
        /// <summary>
        /// 封禁时长（秒） [60, 3*86400]
        /// </summary>
        [XmlElement("ban_duration")]
        public long BanDuration { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 请求量上限 [100, 1000000000]
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
