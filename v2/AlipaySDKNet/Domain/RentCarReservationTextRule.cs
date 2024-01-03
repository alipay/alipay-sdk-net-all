using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarReservationTextRule Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarReservationTextRule : AopObject
    {
        /// <summary>
        /// 规则文案列表
        /// </summary>
        [XmlArray("rule_text_list")]
        [XmlArrayItem("string")]
        public List<string> RuleTextList { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
