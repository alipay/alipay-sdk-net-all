using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleLimitContent Data Structure.
    /// </summary>
    [Serializable]
    public class RuleLimitContent : AopObject
    {
        /// <summary>
        /// 门店编号类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 外部或内部门店编号
        /// </summary>
        [XmlElement("limit_value")]
        public string LimitValue { get; set; }
    }
}
