using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPeriod Data Structure.
    /// </summary>
    [Serializable]
    public class RentPeriod : AopObject
    {
        /// <summary>
        /// 期数的步长，单位：天/月/年
        /// </summary>
        [XmlElement("step")]
        public long Step { get; set; }

        /// <summary>
        /// 总的期数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 期数的单位，默认月
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
