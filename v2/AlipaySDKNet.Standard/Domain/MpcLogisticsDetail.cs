using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcLogisticsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MpcLogisticsDetail : AopObject
    {
        /// <summary>
        /// 物流发生时间
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 物流描述信息
        /// </summary>
        [XmlElement("stand_desc")]
        public string StandDesc { get; set; }
    }
}
