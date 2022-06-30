using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTaskEventCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTaskEventCreateModel : AopObject
    {
        /// <summary>
        /// 规则事件
        /// </summary>
        [XmlArray("event_list")]
        [XmlArrayItem("string")]
        public List<string> EventList { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务规则配置
        /// </summary>
        [XmlElement("rule_config")]
        public TaskRuleConfig RuleConfig { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
