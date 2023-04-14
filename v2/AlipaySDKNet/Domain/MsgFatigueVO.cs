using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgFatigueVO Data Structure.
    /// </summary>
    [Serializable]
    public class MsgFatigueVO : AopObject
    {
        /// <summary>
        /// 表示疲劳度控制总量，如控制疲劳度为2天10次，则value=2，total=10，unit=day
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }

        /// <summary>
        /// 以天或周为疲劳度计量单位，如控制疲劳度为2天10次，则value=2，total=10，unit=day
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 疲劳度单位前的数值，如控制疲劳度为2天10次，则value=2，total=10，unit=day
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
