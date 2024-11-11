using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuaranteeServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GuaranteeServiceInfo : AopObject
    {
        /// <summary>
        /// 基础保障
        /// </summary>
        [XmlElement("basic_guarantee")]
        public GuaranteeService BasicGuarantee { get; set; }

        /// <summary>
        /// 更多保障服务列表
        /// </summary>
        [XmlArray("more_services")]
        [XmlArrayItem("guarantee_service")]
        public List<GuaranteeService> MoreServices { get; set; }

        /// <summary>
        /// 详细规则链接
        /// </summary>
        [XmlElement("rule_detail_page_url")]
        public string RuleDetailPageUrl { get; set; }

        /// <summary>
        /// 所有保障服务的概括性规则
        /// </summary>
        [XmlElement("rule_text")]
        public string RuleText { get; set; }
    }
}
