using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsurancePeriod Data Structure.
    /// </summary>
    [Serializable]
    public class InsurancePeriod : AopObject
    {
        /// <summary>
        /// 保障期限，正整数
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 保障期限单位，年月日 枚举:YEAR/MONTH/DAY
        /// </summary>
        [XmlElement("period_unit")]
        public string PeriodUnit { get; set; }
    }
}
