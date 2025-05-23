using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeTemplateDetailRes Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeTemplateDetailRes : AopObject
    {
        /// <summary>
        /// 该模板元素描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 元素可选值信息集合,针对一些特殊的key只能选择配置上的可选值
        /// </summary>
        [XmlArray("enum_rules")]
        [XmlArrayItem("infra_template_enum_rule_resp")]
        public List<InfraTemplateEnumRuleResp> EnumRules { get; set; }

        /// <summary>
        /// 展示元素英文名称
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 该创意模板元素可支持传入最大个数,相同key下可传入value值的最大数目(如果该值不存在,则默认最多传入1个)
        /// </summary>
        [XmlElement("max_num")]
        public long MaxNum { get; set; }

        /// <summary>
        /// 金额限制规则集合
        /// </summary>
        [XmlArray("money_rules")]
        [XmlArrayItem("infra_template_money_rule_resp")]
        public List<InfraTemplateMoneyRuleResp> MoneyRules { get; set; }

        /// <summary>
        /// 是否必须(true代表必填,false代表非必填)
        /// </summary>
        [XmlElement("need")]
        public bool Need { get; set; }

        /// <summary>
        /// 创意模板元素限制规则集合
        /// </summary>
        [XmlArray("rules")]
        [XmlArrayItem("infra_template_rule_resp")]
        public List<InfraTemplateRuleResp> Rules { get; set; }

        /// <summary>
        /// 元素展示中文名称
        /// </summary>
        [XmlElement("show_name")]
        public string ShowName { get; set; }

        /// <summary>
        /// 当前模版元素类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
