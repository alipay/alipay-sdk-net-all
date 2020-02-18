using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishRuleQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 规则的返回集合
        /// </summary>
        [XmlArray("kb_dish_rule_info_list")]
        [XmlArrayItem("kbdish_rule_info")]
        public List<KbdishRuleInfo> KbDishRuleInfoList { get; set; }
    }
}
