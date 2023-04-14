using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundLimit Data Structure.
    /// </summary>
    [Serializable]
    public class FundLimit : AopObject
    {
        /// <summary>
        /// 限制类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 限制商圈id，以”,“分隔
        /// </summary>
        [XmlElement("limit_value")]
        public string LimitValue { get; set; }
    }
}
