using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalShopTimePeriod Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalShopTimePeriod : AopObject
    {
        /// <summary>
        /// 时间段结束时间。 结束时间必须大于起始时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 时间段起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
