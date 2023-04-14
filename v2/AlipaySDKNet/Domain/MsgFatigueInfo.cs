using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgFatigueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MsgFatigueInfo : AopObject
    {
        /// <summary>
        /// 表示疲劳度控制总量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 以天或周为疲劳度计量单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 如控制疲劳度为2天10次，则value=2，total=10，unit=day
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
