using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineFrequency Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineFrequency : AopObject
    {
        /// <summary>
        /// 单次剂量数值（克）
        /// </summary>
        [XmlElement("dosage")]
        public string Dosage { get; set; }

        /// <summary>
        /// 单位支持片、克、毫克、毫升、IU、杯、粒、颗、袋、支、瓶、滴、匙
        /// </summary>
        [XmlElement("dosage_unit")]
        public string DosageUnit { get; set; }

        /// <summary>
        /// 次
        /// </summary>
        [XmlElement("frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// 时间数（次）
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 单位支持小时；日；周；月；年
        /// </summary>
        [XmlElement("time_unit")]
        public string TimeUnit { get; set; }
    }
}
