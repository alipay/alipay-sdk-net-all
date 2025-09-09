using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationValueLongDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OperationValueLongDTO : AopObject
    {
        /// <summary>
        /// 指标上个周期的数值，不含包金额数值单位
        /// </summary>
        [XmlElement("last_period_value")]
        public long LastPeriodValue { get; set; }

        /// <summary>
        /// 指标的当前值与上期值的环比率，不含包金额数值
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 指标当前时间的数值，不含包金额数值单位
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
