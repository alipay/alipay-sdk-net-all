using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PushDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PushDTO : AopObject
    {
        /// <summary>
        /// 推进计算类型，如计次:CAL_COUNT
        /// </summary>
        [XmlElement("cal_type")]
        public string CalType { get; set; }

        /// <summary>
        /// 推进值
        /// </summary>
        [XmlElement("inc_value")]
        public long IncValue { get; set; }
    }
}
