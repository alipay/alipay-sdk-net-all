using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationValueBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OperationValueBaseDTO : AopObject
    {
        /// <summary>
        /// 指标的上周期的数值, 如果是转化率的类型值，则保留4位小数，如果是金额类型的值，则保留2位小数，单位：元。
        /// </summary>
        [XmlElement("last_period_value")]
        public string LastPeriodValue { get; set; }

        /// <summary>
        /// 指标的当前值与上周期的值的环比率
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 指标的当前日期的数值，如果是转化率的类型值，则保留4位小数，如果是金额类型的值，则保留2位小数，单位：元。
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
