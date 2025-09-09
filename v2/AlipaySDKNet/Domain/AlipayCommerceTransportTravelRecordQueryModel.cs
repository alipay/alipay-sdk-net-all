using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTravelRecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTravelRecordQueryModel : AopObject
    {
        /// <summary>
        /// 结束时间，精确到秒，小于结束时间（不包含结束时间）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 起始时间，精确到秒，大于等于起始时间（包含起始时间）
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
