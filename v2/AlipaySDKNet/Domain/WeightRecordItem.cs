using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeightRecordItem Data Structure.
    /// </summary>
    [Serializable]
    public class WeightRecordItem : AopObject
    {
        /// <summary>
        /// 记录日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 记录业务 ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 记录时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("record_time")]
        public string RecordTime { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 体重 kg，最多 2 位小数
        /// </summary>
        [XmlElement("weight_value")]
        public string WeightValue { get; set; }
    }
}
