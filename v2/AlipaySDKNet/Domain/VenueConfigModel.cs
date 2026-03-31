using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VenueConfigModel Data Structure.
    /// </summary>
    [Serializable]
    public class VenueConfigModel : AopObject
    {
        /// <summary>
        /// 最多可容纳签到的人数
        /// </summary>
        [XmlElement("max_capacity")]
        public long MaxCapacity { get; set; }

        /// <summary>
        /// 用户停留的最短时长，单位：分钟
        /// </summary>
        [XmlElement("min_stay_minutes")]
        public long MinStayMinutes { get; set; }
    }
}
