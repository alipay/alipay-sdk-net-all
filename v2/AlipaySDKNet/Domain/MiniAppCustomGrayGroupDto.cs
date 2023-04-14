using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppCustomGrayGroupDto Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppCustomGrayGroupDto : AopObject
    {
        /// <summary>
        /// 灰度分组id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 灰度code
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }
    }
}
