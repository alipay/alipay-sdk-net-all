using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHmDailySleepRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHmDailySleepRecord : AopObject
    {
        /// <summary>
        /// 睡眠数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 睡眠日期yyyyMMdd
        /// </summary>
        [XmlElement("sleep_date")]
        public string SleepDate { get; set; }

        /// <summary>
        /// 睡眠数据集合
        /// </summary>
        [XmlElement("sleepdata")]
        public string Sleepdata { get; set; }
    }
}
