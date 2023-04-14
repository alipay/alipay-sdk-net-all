using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntstarshipHomeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntstarshipHomeQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
