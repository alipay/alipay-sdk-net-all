using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboDowntimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboDowntimeInfo : AopObject
    {
        /// <summary>
        /// 停运结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 停运开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }
    }
}
