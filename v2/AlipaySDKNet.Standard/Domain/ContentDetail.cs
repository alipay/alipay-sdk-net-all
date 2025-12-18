using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ContentDetail : AopObject
    {
        /// <summary>
        /// 蚂蚁服务端计算静置时间差（写入时的服务器时间-当前服务器时间）
        /// </summary>
        [XmlElement("rtc_time_difference")]
        public string RtcTimeDifference { get; set; }

        /// <summary>
        /// 唯一序号
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
