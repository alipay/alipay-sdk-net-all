using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradingStageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TradingStageDTO : AopObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("begin")]
        public long Begin { get; set; }

        /// <summary>
        /// 是否包含开始时间
        /// </summary>
        [XmlElement("begin_included")]
        public bool BeginIncluded { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end")]
        public long End { get; set; }

        /// <summary>
        /// 是否包含结束时间
        /// </summary>
        [XmlElement("end_included")]
        public bool EndIncluded { get; set; }

        /// <summary>
        /// 交易时间段状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 交易时间状态描述
        /// </summary>
        [XmlElement("state_desc")]
        public string StateDesc { get; set; }
    }
}
